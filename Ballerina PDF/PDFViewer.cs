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
    public enum PageChanges
    {
        None,
        Remove,
        Rotate90,
        Rotate180,
        Rotate270
    }
    public partial class PDFViewer : Form
    {
        private Dictionary<SinglePageEditor, PageChanges> changes = new Dictionary<SinglePageEditor, PageChanges>();
        private string filePath;

        #region Constructor
        public PDFViewer(string filePath)
        {
            InitializeComponent();

            this.filePath = filePath;
            PopulateListView();
        }
        #endregion Constructor

        #region Initialization
        private void PopulateListView()
        {
            //Get number of pages in document
            PdfDocument document = PdfDocument.Load(filePath);
            int pageCount = document.PageCount;
            document.Dispose();

            for (int i = 0; i < pageCount; i++)
            {
                SinglePageEditor pageEditor = new SinglePageEditor();
                pageEditor.PageIndex = i;
                pageEditor.Image = GetPageAsImage(filePath, i);
                pageEditor.PageDoubleClick += PageEditor_PageDoubleClick;
                pageEditor.Remove += PageEditor_Remove;
                pageEditor.RotateCCW += PageEditor_RotateCCW;
                pageEditor.RotateCW += PageEditor_RotateCW;

                flowLayoutPanel1.Controls.Add(pageEditor);
                changes.Add(pageEditor, PageChanges.None);
            }
        }
        #endregion Initialization

        #region Button Actions
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }
        #endregion Button Actions

        #region Methods
        private Image GetPageAsImage(string pdfFilePath, int pageNumber/*pages are zero-based indicies*/)
        {
            Image result;
            PdfDocument document = PdfDocument.Load(pdfFilePath);
            if (pageNumber > document.PageCount - 1)
                return null;

            result = document.Render(pageNumber, 500, 500, false);

            document.Dispose();

            return result;
        }

        private PageChanges IncrementPageRotation(PageChanges currentRotation)
        {
            switch (currentRotation)
            {
                case PageChanges.Rotate90:
                    return PageChanges.Rotate180;
                case PageChanges.Rotate180:
                    return PageChanges.Rotate270;
                case PageChanges.Rotate270:
                    return PageChanges.None;
                case PageChanges.Remove:
                    return PageChanges.Remove;
                case PageChanges.None:
                    return PageChanges.Rotate90;
                default:
                    return currentRotation;
            }
        }

        private PageChanges DecrementPageRotation(PageChanges currentRotation)
        {
            switch (currentRotation)
            {
                case PageChanges.Rotate90:
                    return PageChanges.None;
                case PageChanges.Rotate180:
                    return PageChanges.Rotate90;
                case PageChanges.Rotate270:
                    return PageChanges.Rotate180;
                case PageChanges.Remove:
                    return PageChanges.Remove;
                case PageChanges.None:
                    return PageChanges.Rotate270;
                default:
                    return currentRotation;
            }
        }

        private void SaveChanges()
        {
            foreach (KeyValuePair<SinglePageEditor, PageChanges> pair in changes)
            {
                //REMEMBER: iText page indicies are not zero-based, but rather start from 1
                switch (pair.Value)
                {
                    case PageChanges.Rotate90:
                        PDFActions.RotatePages(filePath, new List<KeyValuePair<int, int>>() { new KeyValuePair<int, int>(pair.Key.PageIndex + 1, 90) });
                        break;
                    case PageChanges.Rotate180:
                        PDFActions.RotatePages(filePath, new List<KeyValuePair<int, int>>() { new KeyValuePair<int, int>(pair.Key.PageIndex + 1, 180) });
                        break;
                    case PageChanges.Rotate270:
                        PDFActions.RotatePages(filePath, new List<KeyValuePair<int, int>>() { new KeyValuePair<int, int>(pair.Key.PageIndex + 1, 270) });
                        break;
                }
            }

            //Need to do the removing after all the rotating (because of page inde
            List<KeyValuePair<SinglePageEditor, PageChanges>> pagesToRemove = changes.Where(p => p.Value == PageChanges.Remove).ToList();
            for (int i = 0; i < pagesToRemove.Count; i++)
            {
                //REMEMBER: iText page indicies are not zero-based, but rather start from 1. Here we also need to adjust by "i" to
                //resolve the original page index (Key.PageIndex) with the new page indicies after removing pages
                PDFActions.RemovePages(filePath, new List<int>() { pagesToRemove[i].Key.PageIndex + 1 - i });
            }
        }
        #endregion Methods

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

            changes[sender] = PageChanges.Remove;
        }

        private void PageEditor_RotateCCW(SinglePageEditor sender)
        {
            changes[sender] = DecrementPageRotation(changes[sender]);
        }

        private void PageEditor_RotateCW(SinglePageEditor sender)
        {
            changes[sender] = IncrementPageRotation(changes[sender]);
        }
        #endregion Page Events
    }
}
