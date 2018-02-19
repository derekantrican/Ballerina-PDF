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

            LoadPDF(filePath);
        }

        private void LoadPDF(string filePath)
        {
            //PdfDocument document = PdfDocument.Load(filePath);
            PdfDocument document = PdfDocument.Load(new FileStream(filePath, FileMode.Open));
            pdfViewer1.Renderer.Load(document);
        }
    }
}
