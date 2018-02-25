using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballerina_PDF
{
    public partial class SinglePageEditor : UserControl
    {
        public SinglePageEditor()
        {
            InitializeComponent();

            pictureBoxPage.DoubleClick += (sender, args) => { PageDoubleClick(pictureBoxPage); };
            pictureBoxRemove.Click += (sender, args) => { Remove(this); };
            pictureBoxRotateCCW.Click += (sender, args) => { RotateCounterClockwise(); };
            pictureBoxRotateCW.Click += (sender, args) => { RotateClockwise(); };
        }

        #region Methods
        private void RotateClockwise()
        {
            Image pageImage = pictureBoxPage.Image;
            pageImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxPage.Image = pageImage;
            RotateCW(this);
        }

        private void RotateCounterClockwise()
        {
            Image pageImage = pictureBoxPage.Image;
            pageImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxPage.Image = pageImage;
            RotateCCW(this);
        }
        #endregion Methods

        #region Public Properties
        public int PageIndex { get; set; }
        public Image Image
        {
            get { return pictureBoxPage.Image; }
            set { pictureBoxPage.Image = value; }
        }
        #endregion Public Properties

        #region Events
        public delegate void PageDoubleClickDelegate(PictureBox sender);
        public event PageDoubleClickDelegate PageDoubleClick;

        public delegate void PageRemoveDelegate(SinglePageEditor sender);
        public event PageRemoveDelegate Remove;

        public delegate void PageRotateCWDelegate(SinglePageEditor sender);
        public event PageRotateCWDelegate RotateCW;

        public delegate void PageRotateCCWDelegate(SinglePageEditor sender);
        public event PageRotateCCWDelegate RotateCCW;
        #endregion Events
    }
}
