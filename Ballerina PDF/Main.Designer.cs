namespace Ballerina_PDF
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelFileLocation = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelRemove = new System.Windows.Forms.Panel();
            this.textBoxRemoveSpecific = new System.Windows.Forms.TextBox();
            this.radioButtonRemoveSpecific = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoveOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoveEven = new System.Windows.Forms.RadioButton();
            this.buttonApplyRemove = new System.Windows.Forms.Button();
            this.labelAction = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButtonNegative90 = new System.Windows.Forms.RadioButton();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.panelRotationAngles = new System.Windows.Forms.Panel();
            this.panelMergePDF = new System.Windows.Forms.Panel();
            this.radioButtonMergeEnd = new System.Windows.Forms.RadioButton();
            this.radioButtonMergeBeginning = new System.Windows.Forms.RadioButton();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.labelPDFtoMerge = new System.Windows.Forms.Label();
            this.buttonLoadMergePDF = new System.Windows.Forms.Button();
            this.panelRotate = new System.Windows.Forms.Panel();
            this.labelDegrees = new System.Windows.Forms.Label();
            this.radioButtonRotateAll = new System.Windows.Forms.RadioButton();
            this.textBoxRotateSpecific = new System.Windows.Forms.TextBox();
            this.radioButtonRotateSpecific = new System.Windows.Forms.RadioButton();
            this.radioButtonRotateOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonRotateEven = new System.Windows.Forms.RadioButton();
            this.buttonAppyRotation = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.panelRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panelRotationAngles.SuspendLayout();
            this.panelMergePDF.SuspendLayout();
            this.panelRotate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFileLocation
            // 
            this.labelFileLocation.Location = new System.Drawing.Point(94, 18);
            this.labelFileLocation.Name = "labelFileLocation";
            this.labelFileLocation.Size = new System.Drawing.Size(206, 13);
            this.labelFileLocation.TabIndex = 1;
            // 
            // panelRemove
            // 
            this.panelRemove.Controls.Add(this.textBoxRemoveSpecific);
            this.panelRemove.Controls.Add(this.radioButtonRemoveSpecific);
            this.panelRemove.Controls.Add(this.radioButtonRemoveOdd);
            this.panelRemove.Controls.Add(this.radioButtonRemoveEven);
            this.panelRemove.Controls.Add(this.buttonApplyRemove);
            this.panelRemove.Location = new System.Drawing.Point(466, 217);
            this.panelRemove.Name = "panelRemove";
            this.panelRemove.Size = new System.Drawing.Size(272, 174);
            this.panelRemove.TabIndex = 3;
            // 
            // textBoxRemoveSpecific
            // 
            this.textBoxRemoveSpecific.Enabled = false;
            this.textBoxRemoveSpecific.Location = new System.Drawing.Point(81, 46);
            this.textBoxRemoveSpecific.Name = "textBoxRemoveSpecific";
            this.textBoxRemoveSpecific.Size = new System.Drawing.Size(188, 20);
            this.textBoxRemoveSpecific.TabIndex = 4;
            // 
            // radioButtonRemoveSpecific
            // 
            this.radioButtonRemoveSpecific.AutoSize = true;
            this.radioButtonRemoveSpecific.Location = new System.Drawing.Point(3, 49);
            this.radioButtonRemoveSpecific.Name = "radioButtonRemoveSpecific";
            this.radioButtonRemoveSpecific.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRemoveSpecific.TabIndex = 3;
            this.radioButtonRemoveSpecific.TabStop = true;
            this.radioButtonRemoveSpecific.Text = "Specific...";
            this.radioButtonRemoveSpecific.UseVisualStyleBackColor = true;
            this.radioButtonRemoveSpecific.CheckedChanged += new System.EventHandler(this.radioButtonRemoveSpecific_CheckedChanged);
            // 
            // radioButtonRemoveOdd
            // 
            this.radioButtonRemoveOdd.AutoSize = true;
            this.radioButtonRemoveOdd.Location = new System.Drawing.Point(3, 26);
            this.radioButtonRemoveOdd.Name = "radioButtonRemoveOdd";
            this.radioButtonRemoveOdd.Size = new System.Drawing.Size(77, 17);
            this.radioButtonRemoveOdd.TabIndex = 2;
            this.radioButtonRemoveOdd.TabStop = true;
            this.radioButtonRemoveOdd.Text = "Odd pages";
            this.radioButtonRemoveOdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemoveEven
            // 
            this.radioButtonRemoveEven.AutoSize = true;
            this.radioButtonRemoveEven.Location = new System.Drawing.Point(3, 3);
            this.radioButtonRemoveEven.Name = "radioButtonRemoveEven";
            this.radioButtonRemoveEven.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRemoveEven.TabIndex = 1;
            this.radioButtonRemoveEven.TabStop = true;
            this.radioButtonRemoveEven.Text = "Even pages";
            this.radioButtonRemoveEven.UseVisualStyleBackColor = true;
            // 
            // buttonApplyRemove
            // 
            this.buttonApplyRemove.Location = new System.Drawing.Point(226, 148);
            this.buttonApplyRemove.Name = "buttonApplyRemove";
            this.buttonApplyRemove.Size = new System.Drawing.Size(43, 23);
            this.buttonApplyRemove.TabIndex = 7;
            this.buttonApplyRemove.Text = "Apply";
            this.buttonApplyRemove.UseVisualStyleBackColor = true;
            this.buttonApplyRemove.Click += new System.EventHandler(this.buttonApplyRemove_Click);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(12, 54);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(40, 13);
            this.labelAction.TabIndex = 4;
            this.labelAction.Text = "Action:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Rotate",
            "Remove",
            "Merge"});
            this.comboBoxAction.Location = new System.Drawing.Point(58, 51);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(78, 21);
            this.comboBoxAction.TabIndex = 5;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(59, 8);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownAngle.TabIndex = 6;
            this.numericUpDownAngle.ValueChanged += new System.EventHandler(this.numericUpDownAngle_ValueChanged);
            this.numericUpDownAngle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownAngle_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // radioButtonNegative90
            // 
            this.radioButtonNegative90.AutoSize = true;
            this.radioButtonNegative90.Location = new System.Drawing.Point(3, 32);
            this.radioButtonNegative90.Name = "radioButtonNegative90";
            this.radioButtonNegative90.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNegative90.TabIndex = 9;
            this.radioButtonNegative90.TabStop = true;
            this.radioButtonNegative90.Text = "-90°";
            this.radioButtonNegative90.UseVisualStyleBackColor = true;
            this.radioButtonNegative90.CheckedChanged += new System.EventHandler(this.radioButtonNegative90_CheckedChanged);
            // 
            // radioButton90
            // 
            this.radioButton90.AutoSize = true;
            this.radioButton90.Location = new System.Drawing.Point(53, 32);
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.Size = new System.Drawing.Size(41, 17);
            this.radioButton90.TabIndex = 10;
            this.radioButton90.TabStop = true;
            this.radioButton90.Text = "90°";
            this.radioButton90.UseVisualStyleBackColor = true;
            this.radioButton90.CheckedChanged += new System.EventHandler(this.radioButton90_CheckedChanged);
            // 
            // radioButton180
            // 
            this.radioButton180.AutoSize = true;
            this.radioButton180.Location = new System.Drawing.Point(53, 5);
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.Size = new System.Drawing.Size(47, 17);
            this.radioButton180.TabIndex = 12;
            this.radioButton180.TabStop = true;
            this.radioButton180.Text = "180°";
            this.radioButton180.UseVisualStyleBackColor = true;
            this.radioButton180.CheckedChanged += new System.EventHandler(this.radioButton180_CheckedChanged);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(3, 5);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(35, 17);
            this.radioButton0.TabIndex = 11;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0°";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // panelRotationAngles
            // 
            this.panelRotationAngles.Controls.Add(this.radioButton90);
            this.panelRotationAngles.Controls.Add(this.radioButton180);
            this.panelRotationAngles.Controls.Add(this.radioButton0);
            this.panelRotationAngles.Controls.Add(this.radioButtonNegative90);
            this.panelRotationAngles.Location = new System.Drawing.Point(114, 3);
            this.panelRotationAngles.Name = "panelRotationAngles";
            this.panelRotationAngles.Size = new System.Drawing.Size(103, 54);
            this.panelRotationAngles.TabIndex = 13;
            // 
            // panelMergePDF
            // 
            this.panelMergePDF.Controls.Add(this.radioButtonMergeEnd);
            this.panelMergePDF.Controls.Add(this.radioButtonMergeBeginning);
            this.panelMergePDF.Controls.Add(this.buttonMerge);
            this.panelMergePDF.Controls.Add(this.labelPDFtoMerge);
            this.panelMergePDF.Controls.Add(this.buttonLoadMergePDF);
            this.panelMergePDF.Location = new System.Drawing.Point(466, 429);
            this.panelMergePDF.Name = "panelMergePDF";
            this.panelMergePDF.Size = new System.Drawing.Size(272, 174);
            this.panelMergePDF.TabIndex = 14;
            // 
            // radioButtonMergeEnd
            // 
            this.radioButtonMergeEnd.AutoSize = true;
            this.radioButtonMergeEnd.Location = new System.Drawing.Point(6, 80);
            this.radioButtonMergeEnd.Name = "radioButtonMergeEnd";
            this.radioButtonMergeEnd.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMergeEnd.TabIndex = 4;
            this.radioButtonMergeEnd.TabStop = true;
            this.radioButtonMergeEnd.Text = "Append to end";
            this.radioButtonMergeEnd.UseVisualStyleBackColor = true;
            // 
            // radioButtonMergeBeginning
            // 
            this.radioButtonMergeBeginning.AutoSize = true;
            this.radioButtonMergeBeginning.Location = new System.Drawing.Point(6, 57);
            this.radioButtonMergeBeginning.Name = "radioButtonMergeBeginning";
            this.radioButtonMergeBeginning.Size = new System.Drawing.Size(123, 17);
            this.radioButtonMergeBeginning.TabIndex = 3;
            this.radioButtonMergeBeginning.TabStop = true;
            this.radioButtonMergeBeginning.Text = "Append to beginning";
            this.radioButtonMergeBeginning.UseVisualStyleBackColor = true;
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(214, 148);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(55, 23);
            this.buttonMerge.TabIndex = 2;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // labelPDFtoMerge
            // 
            this.labelPDFtoMerge.Location = new System.Drawing.Point(3, 29);
            this.labelPDFtoMerge.Name = "labelPDFtoMerge";
            this.labelPDFtoMerge.Size = new System.Drawing.Size(266, 13);
            this.labelPDFtoMerge.TabIndex = 1;
            // 
            // buttonLoadMergePDF
            // 
            this.buttonLoadMergePDF.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadMergePDF.Name = "buttonLoadMergePDF";
            this.buttonLoadMergePDF.Size = new System.Drawing.Size(129, 23);
            this.buttonLoadMergePDF.TabIndex = 0;
            this.buttonLoadMergePDF.Text = "Load PDF to Merge...";
            this.buttonLoadMergePDF.UseVisualStyleBackColor = true;
            this.buttonLoadMergePDF.Click += new System.EventHandler(this.buttonLoadMergePDF_Click);
            // 
            // panelRotate
            // 
            this.panelRotate.Controls.Add(this.labelDegrees);
            this.panelRotate.Controls.Add(this.radioButtonRotateAll);
            this.panelRotate.Controls.Add(this.panelRotationAngles);
            this.panelRotate.Controls.Add(this.textBoxRotateSpecific);
            this.panelRotate.Controls.Add(this.numericUpDownAngle);
            this.panelRotate.Controls.Add(this.radioButtonRotateSpecific);
            this.panelRotate.Controls.Add(this.radioButtonRotateOdd);
            this.panelRotate.Controls.Add(this.radioButtonRotateEven);
            this.panelRotate.Controls.Add(this.buttonAppyRotation);
            this.panelRotate.Location = new System.Drawing.Point(466, 13);
            this.panelRotate.Name = "panelRotate";
            this.panelRotate.Size = new System.Drawing.Size(272, 174);
            this.panelRotate.TabIndex = 8;
            // 
            // labelDegrees
            // 
            this.labelDegrees.AutoSize = true;
            this.labelDegrees.Location = new System.Drawing.Point(3, 10);
            this.labelDegrees.Name = "labelDegrees";
            this.labelDegrees.Size = new System.Drawing.Size(50, 13);
            this.labelDegrees.TabIndex = 15;
            this.labelDegrees.Text = "Degrees:";
            // 
            // radioButtonRotateAll
            // 
            this.radioButtonRotateAll.AutoSize = true;
            this.radioButtonRotateAll.Location = new System.Drawing.Point(3, 56);
            this.radioButtonRotateAll.Name = "radioButtonRotateAll";
            this.radioButtonRotateAll.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRotateAll.TabIndex = 8;
            this.radioButtonRotateAll.TabStop = true;
            this.radioButtonRotateAll.Text = "All pages";
            this.radioButtonRotateAll.UseVisualStyleBackColor = true;
            // 
            // textBoxRotateSpecific
            // 
            this.textBoxRotateSpecific.Enabled = false;
            this.textBoxRotateSpecific.Location = new System.Drawing.Point(81, 122);
            this.textBoxRotateSpecific.Name = "textBoxRotateSpecific";
            this.textBoxRotateSpecific.Size = new System.Drawing.Size(188, 20);
            this.textBoxRotateSpecific.TabIndex = 4;
            // 
            // radioButtonRotateSpecific
            // 
            this.radioButtonRotateSpecific.AutoSize = true;
            this.radioButtonRotateSpecific.Location = new System.Drawing.Point(3, 125);
            this.radioButtonRotateSpecific.Name = "radioButtonRotateSpecific";
            this.radioButtonRotateSpecific.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRotateSpecific.TabIndex = 3;
            this.radioButtonRotateSpecific.TabStop = true;
            this.radioButtonRotateSpecific.Text = "Specific...";
            this.radioButtonRotateSpecific.UseVisualStyleBackColor = true;
            this.radioButtonRotateSpecific.CheckedChanged += new System.EventHandler(this.radioButtonRotateSpecific_CheckedChanged);
            // 
            // radioButtonRotateOdd
            // 
            this.radioButtonRotateOdd.AutoSize = true;
            this.radioButtonRotateOdd.Location = new System.Drawing.Point(3, 102);
            this.radioButtonRotateOdd.Name = "radioButtonRotateOdd";
            this.radioButtonRotateOdd.Size = new System.Drawing.Size(77, 17);
            this.radioButtonRotateOdd.TabIndex = 2;
            this.radioButtonRotateOdd.TabStop = true;
            this.radioButtonRotateOdd.Text = "Odd pages";
            this.radioButtonRotateOdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonRotateEven
            // 
            this.radioButtonRotateEven.AutoSize = true;
            this.radioButtonRotateEven.Location = new System.Drawing.Point(3, 79);
            this.radioButtonRotateEven.Name = "radioButtonRotateEven";
            this.radioButtonRotateEven.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRotateEven.TabIndex = 1;
            this.radioButtonRotateEven.TabStop = true;
            this.radioButtonRotateEven.Text = "Even pages";
            this.radioButtonRotateEven.UseVisualStyleBackColor = true;
            // 
            // buttonAppyRotation
            // 
            this.buttonAppyRotation.Location = new System.Drawing.Point(226, 148);
            this.buttonAppyRotation.Name = "buttonAppyRotation";
            this.buttonAppyRotation.Size = new System.Drawing.Size(43, 23);
            this.buttonAppyRotation.TabIndex = 7;
            this.buttonAppyRotation.Text = "Apply";
            this.buttonAppyRotation.UseVisualStyleBackColor = true;
            this.buttonAppyRotation.Click += new System.EventHandler(this.buttonAppyRotation_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(15, 220);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(50, 23);
            this.buttonView.TabIndex = 15;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 715);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.panelRotate);
            this.Controls.Add(this.panelMergePDF);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.panelRemove);
            this.Controls.Add(this.labelFileLocation);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Ballerina PDF";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.panelRemove.ResumeLayout(false);
            this.panelRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelRotationAngles.ResumeLayout(false);
            this.panelRotationAngles.PerformLayout();
            this.panelMergePDF.ResumeLayout(false);
            this.panelMergePDF.PerformLayout();
            this.panelRotate.ResumeLayout(false);
            this.panelRotate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFileLocation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelRemove;
        private System.Windows.Forms.TextBox textBoxRemoveSpecific;
        private System.Windows.Forms.RadioButton radioButtonRemoveSpecific;
        private System.Windows.Forms.RadioButton radioButtonRemoveOdd;
        private System.Windows.Forms.RadioButton radioButtonRemoveEven;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button buttonApplyRemove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton radioButtonNegative90;
        private System.Windows.Forms.RadioButton radioButton90;
        private System.Windows.Forms.RadioButton radioButton180;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Panel panelRotationAngles;
        private System.Windows.Forms.Panel panelMergePDF;
        private System.Windows.Forms.Label labelPDFtoMerge;
        private System.Windows.Forms.Button buttonLoadMergePDF;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.RadioButton radioButtonMergeEnd;
        private System.Windows.Forms.RadioButton radioButtonMergeBeginning;
        private System.Windows.Forms.Panel panelRotate;
        private System.Windows.Forms.RadioButton radioButtonRotateAll;
        private System.Windows.Forms.TextBox textBoxRotateSpecific;
        private System.Windows.Forms.RadioButton radioButtonRotateSpecific;
        private System.Windows.Forms.RadioButton radioButtonRotateOdd;
        private System.Windows.Forms.RadioButton radioButtonRotateEven;
        private System.Windows.Forms.Button buttonAppyRotation;
        private System.Windows.Forms.Label labelDegrees;
        private System.Windows.Forms.Button buttonView;
    }
}

