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

            return document.Render(pageNumber, 500, 500, false);
        }

        private void PopulateListView(string pdfFilePath)
        {
            PdfDocument document = PdfDocument.Load(pdfFilePath);
            for (int i = 0; i < document.PageCount; i++)
            {
                SinglePageEditor pageEditor = new SinglePageEditor();
                pageEditor.Image = GetPageAsImage(pdfFilePath, i);
                pageEditor.PageDoubleClick += PageEditor_PageDoubleClick;
                pageEditor.Remove += PageEditor_Remove;
                pageEditor.RotateCCW += PageEditor_RotateCCW;
                pageEditor.RotateCW += PageEditor_RotateCW;

                flowLayoutPanel1.Controls.Add(pageEditor);
            }
        }

        #region Page Events
        private void PageEditor_PageDoubleClick(PictureBox sender)
        {
            Image clickedImage = sender.Image;
            SinglePageViewer pageView = new SinglePageViewer(clickedImage);
            pageView.ShowDialog();
        }

        private void PageEditor_Remove(SinglePageEditor sender)
        {
            flowLayoutPanel1.Controls.Remove(sender);
        }

        private void PageEditor_RotateCCW(SinglePageEditor sender)
        {

        }

        private void PageEditor_RotateCW(SinglePageEditor sender)
        {

        }
        #endregion Page Events
    }
}
