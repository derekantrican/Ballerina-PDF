using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballerina_PDF
{
    public partial class SinglePageViewer : Form
    {
        public SinglePageViewer(Image image)
        {
            InitializeComponent();

            pictureBoxPage.Image = image;
        }
    }
}
