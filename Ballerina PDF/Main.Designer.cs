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
            this.panelPageChoosers = new System.Windows.Forms.Panel();
            this.textBoxSpecificPages = new System.Windows.Forms.TextBox();
            this.radioButtonSpecific = new System.Windows.Forms.RadioButton();
            this.radioButtonOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEven = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
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
            this.buttonMerge = new System.Windows.Forms.Button();
            this.labelPDFtoMerge = new System.Windows.Forms.Label();
            this.buttonLoadMergePDF = new System.Windows.Forms.Button();
            this.radioButtonMergeBeginning = new System.Windows.Forms.RadioButton();
            this.radioButtonMergeEnd = new System.Windows.Forms.RadioButton();
            this.panelPageChoosers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panelRotationAngles.SuspendLayout();
            this.panelMergePDF.SuspendLayout();
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
            // panelPageChoosers
            // 
            this.panelPageChoosers.Controls.Add(this.textBoxSpecificPages);
            this.panelPageChoosers.Controls.Add(this.radioButtonSpecific);
            this.panelPageChoosers.Controls.Add(this.radioButtonOdd);
            this.panelPageChoosers.Controls.Add(this.radioButtonEven);
            this.panelPageChoosers.Controls.Add(this.radioButtonAll);
            this.panelPageChoosers.Controls.Add(this.buttonApply);
            this.panelPageChoosers.Location = new System.Drawing.Point(463, 388);
            this.panelPageChoosers.Name = "panelPageChoosers";
            this.panelPageChoosers.Size = new System.Drawing.Size(272, 123);
            this.panelPageChoosers.TabIndex = 3;
            // 
            // textBoxSpecificPages
            // 
            this.textBoxSpecificPages.Enabled = false;
            this.textBoxSpecificPages.Location = new System.Drawing.Point(81, 69);
            this.textBoxSpecificPages.Name = "textBoxSpecificPages";
            this.textBoxSpecificPages.Size = new System.Drawing.Size(188, 20);
            this.textBoxSpecificPages.TabIndex = 4;
            // 
            // radioButtonSpecific
            // 
            this.radioButtonSpecific.AutoSize = true;
            this.radioButtonSpecific.Location = new System.Drawing.Point(3, 72);
            this.radioButtonSpecific.Name = "radioButtonSpecific";
            this.radioButtonSpecific.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSpecific.TabIndex = 3;
            this.radioButtonSpecific.TabStop = true;
            this.radioButtonSpecific.Text = "Specific...";
            this.radioButtonSpecific.UseVisualStyleBackColor = true;
            this.radioButtonSpecific.CheckedChanged += new System.EventHandler(this.radioButtonSpecific_CheckedChanged);
            // 
            // radioButtonOdd
            // 
            this.radioButtonOdd.AutoSize = true;
            this.radioButtonOdd.Location = new System.Drawing.Point(3, 49);
            this.radioButtonOdd.Name = "radioButtonOdd";
            this.radioButtonOdd.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOdd.TabIndex = 2;
            this.radioButtonOdd.TabStop = true;
            this.radioButtonOdd.Text = "Odd pages";
            this.radioButtonOdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEven
            // 
            this.radioButtonEven.AutoSize = true;
            this.radioButtonEven.Location = new System.Drawing.Point(3, 26);
            this.radioButtonEven.Name = "radioButtonEven";
            this.radioButtonEven.Size = new System.Drawing.Size(82, 17);
            this.radioButtonEven.TabIndex = 1;
            this.radioButtonEven.TabStop = true;
            this.radioButtonEven.Text = "Even pages";
            this.radioButtonEven.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(68, 17);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All pages";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(226, 95);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(43, 23);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
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
            this.numericUpDownAngle.Location = new System.Drawing.Point(4, 28);
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
            this.radioButtonNegative90.Location = new System.Drawing.Point(59, 31);
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
            this.radioButton90.Location = new System.Drawing.Point(109, 32);
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
            this.radioButton180.Location = new System.Drawing.Point(109, 5);
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
            this.radioButton0.Location = new System.Drawing.Point(59, 4);
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
            this.panelRotationAngles.Controls.Add(this.numericUpDownAngle);
            this.panelRotationAngles.Controls.Add(this.radioButton0);
            this.panelRotationAngles.Controls.Add(this.radioButtonNegative90);
            this.panelRotationAngles.Location = new System.Drawing.Point(573, 41);
            this.panelRotationAngles.Name = "panelRotationAngles";
            this.panelRotationAngles.Size = new System.Drawing.Size(159, 54);
            this.panelRotationAngles.TabIndex = 13;
            // 
            // panelMergePDF
            // 
            this.panelMergePDF.Controls.Add(this.radioButtonMergeEnd);
            this.panelMergePDF.Controls.Add(this.radioButtonMergeBeginning);
            this.panelMergePDF.Controls.Add(this.buttonMerge);
            this.panelMergePDF.Controls.Add(this.labelPDFtoMerge);
            this.panelMergePDF.Controls.Add(this.buttonLoadMergePDF);
            this.panelMergePDF.Location = new System.Drawing.Point(463, 530);
            this.panelMergePDF.Name = "panelMergePDF";
            this.panelMergePDF.Size = new System.Drawing.Size(272, 123);
            this.panelMergePDF.TabIndex = 14;
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(214, 97);
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
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 715);
            this.Controls.Add(this.panelMergePDF);
            this.Controls.Add(this.panelRotationAngles);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.panelPageChoosers);
            this.Controls.Add(this.labelFileLocation);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Ballerina PDF";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.panelPageChoosers.ResumeLayout(false);
            this.panelPageChoosers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelRotationAngles.ResumeLayout(false);
            this.panelRotationAngles.PerformLayout();
            this.panelMergePDF.ResumeLayout(false);
            this.panelMergePDF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFileLocation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelPageChoosers;
        private System.Windows.Forms.TextBox textBoxSpecificPages;
        private System.Windows.Forms.RadioButton radioButtonSpecific;
        private System.Windows.Forms.RadioButton radioButtonOdd;
        private System.Windows.Forms.RadioButton radioButtonEven;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button buttonApply;
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
    }
}

