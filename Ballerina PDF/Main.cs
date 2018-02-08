using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ballerina_PDF
{
    public partial class Main : Form
    {
        PdfDocument document;
        PdfDocument tempDocument;
        List<int> newPageOrder = new List<int>();
        string filePath;
        string tempFilePath;
        string fileChooserDirectory;
        public Main()
        {
            InitializeComponent();

            comboBoxAction.SelectedIndex = 0;
            radioButtonAll.Checked = true;
            radioButton0.Checked = true; //the numericUpDown is 0  to start with, so this should be checked
            UpdateStatusLabel("");
        }

        private void LoadPDF(string filePath)
        {
            this.filePath = filePath;
            PdfReader reader = new PdfReader(filePath);
            document = new PdfDocument(reader);
            newPageOrder = Enumerable.Range(1, document.GetNumberOfPages()).ToList();
            labelFileLocation.Text = filePath;
            toolTip1.SetToolTip(labelFileLocation, filePath);

            tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
            PdfWriter writer = new PdfWriter(tempFilePath);
            tempDocument = new PdfDocument(writer);

            File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);

            UpdateStatusLabel("Loaded PDF");
        }

        private void LoadNewPDF(string filePath)
        {
            ReorderPages(newPageOrder); //This needs to be done in order to copy the pages to tempDocument (it won't close if it has no pages)

            document.Close();
            tempDocument.Close();

            File.Delete(tempFilePath);

            LoadPDF(filePath);
        }

        private void SavePDF(bool closing = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a pdf first");
                return;
            }

            ReorderPages(newPageOrder);

            document.Close();
            tempDocument.Close();

            File.Delete(filePath);
            File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
            File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)

            if (!closing)
            {
                LoadPDF(filePath);
                UpdateStatusLabel("Saved PDF");
            }
        }

        private void MovePage(int currentLocation, int newLocation)
        {
            newPageOrder.Insert(newLocation - 1, currentLocation); //"- 1" because lists are zero-index-based and pages are not
            newPageOrder.Remove(currentLocation);
        }

        private void RotatePage(int pageIndex, int degreesToRotate)
        {
            document.GetPage(pageIndex).SetRotation(document.GetPage(pageIndex).GetRotation() + degreesToRotate);
        }

        private void ReorderPages(List<int> newPageOrder)
        {
            foreach (int i in newPageOrder)
                tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.InitialDirectory = string.IsNullOrEmpty(fileChooserDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : fileChooserDirectory;
            fileChooser.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult dialogResult = fileChooser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                fileChooserDirectory = Path.GetDirectoryName(fileChooser.FileName);

                if (!string.IsNullOrEmpty(filePath) && fileChooser.FileName != filePath)
                    LoadNewPDF(fileChooser.FileName);
                else
                    LoadPDF(fileChooser.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePDF();
        }

        private void radioButtonSpecific_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSpecificPages.Enabled = radioButtonSpecific.Checked;
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAction.Text)
            {
                case "Remove":
                    numericUpDownAngle.Visible = false;

                    radioButton0.Visible = false;
                    radioButton180.Visible = false;
                    radioButton90.Visible = false;
                    radioButtonNegative90.Visible = false;
                    break;
                case "Rotate":
                    numericUpDownAngle.Visible = true;

                    radioButton0.Visible = true;
                    radioButton180.Visible = true;
                    radioButton90.Visible = true;
                    radioButtonNegative90.Visible = true;
                    break;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a pdf first");
                return;
            }

            switch (comboBoxAction.Text)
            {
                case "Remove":
                    if (radioButtonAll.Checked)
                    {
                        newPageOrder.Clear();
                        UpdateStatusLabel("Removed all pages");
                    }
                    else if (radioButtonEven.Checked)
                    {
                        List<int> evenPages = newPageOrder.Where(p => p % 2 == 0).ToList();
                        foreach (int i in evenPages)
                            newPageOrder.Remove(i);

                        UpdateStatusLabel("Removed pages " + string.Join(",", evenPages));
                    }
                    else if (radioButtonOdd.Checked)
                    {
                        List<int> oddPages = newPageOrder.Where(p => p % 2 != 0).ToList();
                        foreach (int i in oddPages)
                            newPageOrder.Remove(i);

                        UpdateStatusLabel("Removed pages " + string.Join(",", oddPages));
                    }
                    else if (radioButtonSpecific.Checked)
                    {
                        List<int> specificPages = ParseSpecificPages(textBoxSpecificPages.Text);
                        foreach (int i in specificPages)
                            newPageOrder.Remove(i);

                        UpdateStatusLabel("Removed pages " + string.Join(",", specificPages));
                    }
                    break;
                case "Rotate":
                    int angle = Convert.ToInt32(numericUpDownAngle.Value);

                    if (radioButtonAll.Checked)
                    {
                        foreach (int i in newPageOrder)
                            RotatePage(i, angle);

                        UpdateStatusLabel("Rotated all pages by " + angle + " degrees");
                    }
                    else if (radioButtonEven.Checked)
                    {
                        List<int> evenPages = newPageOrder.Where(p => p % 2 == 0).ToList();
                        foreach (int i in evenPages)
                            RotatePage(i, angle);

                        UpdateStatusLabel("Rotated pages " + string.Join(",", evenPages) + " by " + angle + " degrees");
                    }
                    else if (radioButtonOdd.Checked)
                    {
                        List<int> oddPages = newPageOrder.Where(p => p % 2 != 0).ToList();
                        foreach (int i in oddPages)
                            RotatePage(i, angle);

                        UpdateStatusLabel("Rotated pages " + string.Join(",", oddPages) + " by " + angle + " degrees");
                    }
                    else if (radioButtonSpecific.Checked)
                    {
                        List<int> specificPages = ParseSpecificPages(textBoxSpecificPages.Text);
                        foreach (int i in specificPages)
                            RotatePage(i, angle);

                        UpdateStatusLabel("Rotated pages " + string.Join(",", specificPages) + " by " + angle + " degrees");
                    }
                    break;
            }
        }

        private List<int> ParseSpecificPages(string input)
        {
            List<int> result = new List<int>();
            input = Regex.Replace(input, @"[^\d|,|-]", "");
            List<string> inputParts = input.Split(',').ToList();
            foreach (string part in inputParts)
            {
                if (part.Contains("-"))
                {
                    int first = Convert.ToInt32(part.Split('-').First());
                    int last = Convert.ToInt32(part.Split('-').Last());
                    result.AddRange(Enumerable.Range(first, last - first + 1)); //The second parameter in Enumerable.Range is "count"
                }
                else
                    result.Add(Convert.ToInt32(part));
            }

            return result;
        }

        private void UpdateStatusLabel(string statusText)
        {
            toolStripStatusLabel1.Text = statusText;
            statusStrip1.Update();
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ((new FileInfo(files.First())).Extension == ".pdf")
            {
                if (!string.IsNullOrEmpty(filePath) && files.First() != filePath)
                    LoadNewPDF(files.First());
                else
                    LoadPDF(files.First());
            }
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
                SavePDF(true);
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton0.Checked)
            {
                numericUpDownAngle.Value = 0;

                radioButton180.Checked = false;
                radioButtonNegative90.Checked = false;
                radioButton90.Checked = false;
            }
        }

        private void radioButton180_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton180.Checked)
            {
                numericUpDownAngle.Value = 180;

                radioButton0.Checked = false;
                radioButtonNegative90.Checked = false;
                radioButton90.Checked = false;
            }
        }

        private void radioButtonNegative90_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNegative90.Checked)
            {
                numericUpDownAngle.Value = -90;

                radioButton0.Checked = false;
                radioButton180.Checked = false;
                radioButton90.Checked = false;
            }
        }

        private void radioButton90_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton90.Checked)
            {
                numericUpDownAngle.Value = 90;

                radioButton0.Checked = false;
                radioButton180.Checked = false;
                radioButtonNegative90.Checked = false;
            }
        }

        private void numericUpDownAngle_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownAngle.Text))
            {
                radioButton0.Checked = false;
                radioButton180.Checked = false;
                radioButton90.Checked = false;
                radioButtonNegative90.Checked = false;
                return;
            }

            if (numericUpDownAngle.Value == 0)
                radioButton0.Checked = true;
            else if (numericUpDownAngle.Value == -90)
                radioButtonNegative90.Checked = true;
            else if (numericUpDownAngle.Value == 90)
                radioButton90.Checked = true;
            else if (numericUpDownAngle.Value == 180)
                radioButton180.Checked = true;
            else
            {
                radioButton0.Checked = false;
                radioButton180.Checked = false;
                radioButton90.Checked = false;
                radioButtonNegative90.Checked = false;
            }
        }
    }
}
