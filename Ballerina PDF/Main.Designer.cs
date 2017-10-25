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
            this.buttonSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSpecificPages = new System.Windows.Forms.TextBox();
            this.radioButtonSpecific = new System.Windows.Forms.RadioButton();
            this.radioButtonOdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEven = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.labelAction = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxReplace = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(225, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSpecificPages);
            this.panel1.Controls.Add(this.radioButtonSpecific);
            this.panel1.Controls.Add(this.radioButtonOdd);
            this.panel1.Controls.Add(this.radioButtonEven);
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Location = new System.Drawing.Point(28, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 94);
            this.panel1.TabIndex = 3;
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
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(12, 60);
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
            "Remove",
            "Rotate"});
            this.comboBoxAction.Location = new System.Drawing.Point(58, 57);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(78, 21);
            this.comboBoxAction.TabIndex = 5;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(142, 57);
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
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(257, 179);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(43, 23);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(312, 22);
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
            // checkBoxReplace
            // 
            this.checkBoxReplace.AutoSize = true;
            this.checkBoxReplace.Checked = true;
            this.checkBoxReplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReplace.Location = new System.Drawing.Point(12, 238);
            this.checkBoxReplace.Name = "checkBoxReplace";
            this.checkBoxReplace.Size = new System.Drawing.Size(113, 17);
            this.checkBoxReplace.TabIndex = 9;
            this.checkBoxReplace.Text = "Overwrite original?";
            this.checkBoxReplace.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 280);
            this.Controls.Add(this.checkBoxReplace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFileLocation);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Ballerina PDF";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFileLocation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.CheckBox checkBoxReplace;
    }
}

