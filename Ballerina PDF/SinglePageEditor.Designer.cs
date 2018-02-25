namespace Ballerina_PDF
{
    partial class SinglePageEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxRotateCW = new System.Windows.Forms.PictureBox();
            this.pictureBoxRotateCCW = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateCW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateCCW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRotateCW
            // 
            this.pictureBoxRotateCW.Image = global::Ballerina_PDF.Properties.Resources.RotateCW;
            this.pictureBoxRotateCW.Location = new System.Drawing.Point(130, 227);
            this.pictureBoxRotateCW.Name = "pictureBoxRotateCW";
            this.pictureBoxRotateCW.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRotateCW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRotateCW.TabIndex = 3;
            this.pictureBoxRotateCW.TabStop = false;
            // 
            // pictureBoxRotateCCW
            // 
            this.pictureBoxRotateCCW.Image = global::Ballerina_PDF.Properties.Resources.RotateCCW;
            this.pictureBoxRotateCCW.Location = new System.Drawing.Point(100, 227);
            this.pictureBoxRotateCCW.Name = "pictureBoxRotateCCW";
            this.pictureBoxRotateCCW.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRotateCCW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRotateCCW.TabIndex = 2;
            this.pictureBoxRotateCCW.TabStop = false;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Image = global::Ballerina_PDF.Properties.Resources.delete;
            this.pictureBoxRemove.Location = new System.Drawing.Point(227, 3);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRemove.TabIndex = 1;
            this.pictureBoxRemove.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxPage.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 0;
            this.pictureBoxPage.TabStop = false;
            // 
            // SinglePageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxRotateCW);
            this.Controls.Add(this.pictureBoxRotateCCW);
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.pictureBoxPage);
            this.Name = "SinglePageEditor";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateCW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateCCW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private System.Windows.Forms.PictureBox pictureBoxRotateCCW;
        private System.Windows.Forms.PictureBox pictureBoxRotateCW;
    }
}
