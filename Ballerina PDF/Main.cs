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
        #region Global Variables
        string filePath;
        string mergeFilePath;
        string fileChooserDirectory;
        #endregion Global Variables

        #region Initialization
        public Main()
        {
            InitializeComponent();
            BuildForm();
            SetDefaults();
        }

        private void BuildForm()
        {
            this.Width = 328;
            this.Height = 330;

            panelRotate.Left = 28;
            panelRotate.Top = 84;

            panelRemove.Left = 28;
            panelRemove.Top = 84;

            panelMergePDF.Left = 28;
            panelMergePDF.Top = 84;
        }

        private void SetDefaults()
        {
            comboBoxAction.SelectedIndex = 0;
            radioButtonRotateAll.Checked = true;
            radioButtonRemoveEven.Checked = true;
            radioButton0.Checked = true; //the numericUpDown is 0  to start with, so this should be checked
            radioButtonMergeBeginning.Checked = true;
            UpdateStatusLabel("");
        }
        #endregion Initialization

        #region PDF Loading Functions
        private void LoadPDF(string fileToLoad)
        {
            if (IsFileLocked(new FileInfo(fileToLoad)))
            {
                MessageBox.Show("File is in use. Please close the file first before editing");
                return;
            }

            this.filePath = fileToLoad;
            labelFileLocation.Text = filePath;
            toolTip1.SetToolTip(labelFileLocation, filePath);

            UpdateStatusLabel("Loaded PDF");
        }

        private void LoadMergePDF(string fileToLoad)
        {
            if (IsFileLocked(new FileInfo(fileToLoad)))
            {
                MessageBox.Show("File is in use. Please close the file first before editing");
                return;
            }

            this.mergeFilePath = fileToLoad;
            labelPDFtoMerge.Text = mergeFilePath;
            toolTip1.SetToolTip(labelPDFtoMerge, mergeFilePath);

            UpdateStatusLabel("Loaded PDF to merge");
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ((new FileInfo(files.First())).Extension == ".pdf")
                LoadPDF(files.First());
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        #endregion PDF Loading Functions

        #region Button Actions
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.InitialDirectory = string.IsNullOrEmpty(fileChooserDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : fileChooserDirectory;
            fileChooser.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult dialogResult = fileChooser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                fileChooserDirectory = Path.GetDirectoryName(fileChooser.FileName);
                LoadPDF(fileChooser.FileName);
            }
        }

        private void buttonLoadMergePDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.InitialDirectory = string.IsNullOrEmpty(fileChooserDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : fileChooserDirectory;
            fileChooser.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult dialogResult = fileChooser.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                fileChooserDirectory = Path.GetDirectoryName(fileChooser.FileName);
                mergeFilePath = fileChooser.FileName;

                labelPDFtoMerge.Text = mergeFilePath;
                toolTip1.SetToolTip(labelPDFtoMerge, mergeFilePath);
            }
        }

        private void buttonAppyRotation_Click(object sender, EventArgs e)
        {
            bool success;
            int angle = Convert.ToInt32(numericUpDownAngle.Value);

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a pdf first");
                return;
            }

            if (radioButtonRotateAll.Checked)
            {
                success = PDFActions.RotateAllPages(filePath, angle, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Rotated pages"); //Todo: this should be updated from PDFActions.RotateAllPages so that we have the specific page numbers
            }
            else if (radioButtonRotateEven.Checked)
            {
                success = PDFActions.RotateEvenPages(filePath, angle, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Rotated even pages"); //Todo: this should be updated from PDFActions.RotateEvenPages so that we have the specific page numbers
            }
            else if (radioButtonRotateOdd.Checked)
            {
                success = PDFActions.RotateOddPages(filePath, angle, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Rotated odd pages"); //Todo: this should be updated from PDFActions.RotateOddPages so that we have the specific page numbers
            }
            else if (radioButtonRotateSpecific.Checked)
            {
                List<KeyValuePair<int, int>> indiciesAndAngles = new List<KeyValuePair<int, int>>();
                foreach (int pageIndex in ParseSpecificPages(textBoxRotateSpecific.Text))
                    indiciesAndAngles.Add(new KeyValuePair<int, int>(pageIndex, angle));

                success = PDFActions.RotatePages(filePath, indiciesAndAngles, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Rotated pages"); //Todo: this should be updated from PDFActions.RotatePages so that we have the specific page numbers
            }
        }

        private void buttonApplyRemove_Click(object sender, EventArgs e)
        {
            bool success;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a pdf first");
                return;
            }

            if (radioButtonRemoveEven.Checked)
            {
                success = PDFActions.RemoveEvenPages(filePath, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Removed even pages"); //Todo: this should be updated from PDFActions.RemoveEvenPages so that we have the specific page numbers
            }
            else if (radioButtonRemoveOdd.Checked)
            {
                success = PDFActions.RemoveOddPages(filePath, true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Removed odd pages"); //Todo: this should be updated from PDFActions.RemoveOddPages so that we have the specific page numbers
            }
            else if (radioButtonRemoveSpecific.Checked)
            {
                success = PDFActions.RemovePages(filePath, ParseSpecificPages(textBoxRemoveSpecific.Text), true /*should be only for debugging mode?*/);

                if (success)
                    UpdateStatusLabel("Removed pages"); //Todo: this should be updated from PDFActions.RemovePages so that we have the specific page numbers
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            if (radioButtonMergeBeginning.Checked)
                PDFActions.MergePDFonBeginning(filePath, mergeFilePath, true /*should be only for debugging mode?*/);
            else if (radioButtonMergeEnd.Checked)
                PDFActions.MergePDFonEnd(filePath, mergeFilePath, true /*should be only for debugging mode?*/);

            UpdateStatusLabel("Merged " + Path.GetFileNameWithoutExtension(mergeFilePath) + " into " + Path.GetFileNameWithoutExtension(filePath));
        }
        #endregion Button Actions

        #region Misc Methods
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

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        #endregion Misc Methods

        #region Enable/Disable Functionality
        private void radioButtonRemoveSpecific_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRemoveSpecific.Enabled = radioButtonRemoveSpecific.Checked;
        }

        private void radioButtonRotateSpecific_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRotateSpecific.Enabled = radioButtonRotateSpecific.Checked;
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAction.Text)
            {
                case "Rotate":
                    panelRotate.Visible = true;
                    panelRemove.Visible = false;
                    panelMergePDF.Visible = false;
                    break;
                case "Remove":
                    panelRotate.Visible = false;
                    panelRemove.Visible = true;
                    panelMergePDF.Visible = false;
                    break;
                case "Merge":
                    panelRotate.Visible = false;
                    panelRemove.Visible = false;
                    panelMergePDF.Visible = true;
                    break;
            }
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton0.Checked)
                numericUpDownAngle.Value = 0;
        }

        private void radioButton180_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton180.Checked)
                numericUpDownAngle.Value = 180;
        }

        private void radioButtonNegative90_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNegative90.Checked)
                numericUpDownAngle.Value = -90;
        }

        private void radioButton90_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton90.Checked)
                numericUpDownAngle.Value = 90;
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

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAngle_KeyUp(null, null);
        }
        #endregion Enable/Disable Functionality
    }
}
