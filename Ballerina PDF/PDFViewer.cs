using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballerina_PDF
{
    public partial class PDFViewer : Form
    {
        public PDFViewer(string filePath)
        {
            InitializeComponent();

            //SavePDFPagesAsImages(filePath, @"C:\Users\derek.antrican\Desktop\Ballerina test");
            PopulateListView(filePath);
        }

        private void SavePDFPagesAsImages(string pdfFilePath, string outputFolder)
        {
            PdfDocument document = PdfDocument.Load(pdfFilePath);
            for (int i = 0; i < document.PageCount; i++)
                GetPageAsImage(pdfFilePath, i).Save(Path.Combine(outputFolder, (i + 1) + ".png"));
        }

        private Image GetPageAsImage(string pdfFilePath, int pageNumber/*pages are zero-based indicies*/)
        {
            PdfDocument document = PdfDocument.Load(pdfFilePath);
            if (pageNumber > document.PageCount - 1)
                return null;

            return document.Render(pageNumber, 300, 300, false);
        }

        private void PopulateListView(string pdfFilePath)
        {
            PdfDocument document = PdfDocument.Load(pdfFilePath);
            for (int i = 0; i < document.PageCount; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Gray;
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.Image = GetPageAsImage(pdfFilePath, i);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }
    }
}
