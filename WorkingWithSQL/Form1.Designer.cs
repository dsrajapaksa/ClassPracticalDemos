namespace WorkingWithSQL
{
    partial class Form1
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
            this.iDLabel = new System.Windows.Forms.Label();
            this.fNAMELabel = new System.Windows.Forms.Label();
            this.lNAMELabel = new System.Windows.Forms.Label();
            this.aDDRESSLabel = new System.Windows.Forms.Label();
            this.cITYLabel = new System.Windows.Forms.Label();
            this.tELLabel = new System.Windows.Forms.Label();
            this.gENDERLabel = new System.Windows.Forms.Label();
            this.dATEJOINEDLabel = new System.Windows.Forms.Label();
            this.aGELabel = new System.Windows.Forms.Label();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.tELTextBox = new System.Windows.Forms.TextBox();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.dATEJOINEDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Location = new System.Drawing.Point(41, 346);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(21, 13);
            this.iDLabel.TabIndex = 2;
            this.iDLabel.Text = "ID:";
            // 
            // fNAMELabel
            // 
            this.fNAMELabel.AutoSize = true;
            this.fNAMELabel.Location = new System.Drawing.Point(15, 381);
            this.fNAMELabel.Name = "fNAMELabel";
            this.fNAMELabel.Size = new System.Drawing.Size(47, 13);
            this.fNAMELabel.TabIndex = 4;
            this.fNAMELabel.Text = "FNAME:";
            // 
            // lNAMELabel
            // 
            this.lNAMELabel.AutoSize = true;
            this.lNAMELabel.Location = new System.Drawing.Point(15, 417);
            this.lNAMELabel.Name = "lNAMELabel";
            this.lNAMELabel.Size = new System.Drawing.Size(47, 13);
            this.lNAMELabel.TabIndex = 6;
            this.lNAMELabel.Text = "LNAME:";
            // 
            // aDDRESSLabel
            // 
            this.aDDRESSLabel.AutoSize = true;
            this.aDDRESSLabel.Location = new System.Drawing.Point(210, 346);
            this.aDDRESSLabel.Name = "aDDRESSLabel";
            this.aDDRESSLabel.Size = new System.Drawing.Size(62, 13);
            this.aDDRESSLabel.TabIndex = 8;
            this.aDDRESSLabel.Text = "ADDRESS:";
            // 
            // cITYLabel
            // 
            this.cITYLabel.AutoSize = true;
            this.cITYLabel.Location = new System.Drawing.Point(238, 381);
            this.cITYLabel.Name = "cITYLabel";
            this.cITYLabel.Size = new System.Drawing.Size(34, 13);
            this.cITYLabel.TabIndex = 10;
            this.cITYLabel.Text = "CITY:";
            // 
            // tELLabel
            // 
            this.tELLabel.AutoSize = true;
            this.tELLabel.Location = new System.Drawing.Point(242, 413);
            this.tELLabel.Name = "tELLabel";
            this.tELLabel.Size = new System.Drawing.Size(30, 13);
            this.tELLabel.TabIndex = 12;
            this.tELLabel.Text = "TEL:";
            // 
            // gENDERLabel
            // 
            this.gENDERLabel.AutoSize = true;
            this.gENDERLabel.Location = new System.Drawing.Point(416, 346);
            this.gENDERLabel.Name = "gENDERLabel";
            this.gENDERLabel.Size = new System.Drawing.Size(56, 13);
            this.gENDERLabel.TabIndex = 14;
            this.gENDERLabel.Text = "GENDER:";
            // 
            // dATEJOINEDLabel
            // 
            this.dATEJOINEDLabel.AutoSize = true;
            this.dATEJOINEDLabel.Location = new System.Drawing.Point(394, 379);
            this.dATEJOINEDLabel.Name = "dATEJOINEDLabel";
            this.dATEJOINEDLabel.Size = new System.Drawing.Size(78, 13);
            this.dATEJOINEDLabel.TabIndex = 16;
            this.dATEJOINEDLabel.Text = "DATEJOINED:";
            // 
            // aGELabel
            // 
            this.aGELabel.AutoSize = true;
            this.aGELabel.Location = new System.Drawing.Point(440, 413);
            this.aGELabel.Name = "aGELabel";
            this.aGELabel.Size = new System.Drawing.Size(32, 13);
            this.aGELabel.TabIndex = 18;
            this.aGELabel.Text = "AGE:";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(0, 28);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(843, 289);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(68, 343);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.Location = new System.Drawing.Point(68, 378);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.fNAMETextBox.TabIndex = 5;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.Location = new System.Drawing.Point(68, 414);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.lNAMETextBox.TabIndex = 7;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.Location = new System.Drawing.Point(278, 343);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(100, 20);
            this.aDDRESSTextBox.TabIndex = 9;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.Location = new System.Drawing.Point(278, 378);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(100, 20);
            this.cITYTextBox.TabIndex = 11;
            // 
            // tELTextBox
            // 
            this.tELTextBox.Location = new System.Drawing.Point(278, 410);
            this.tELTextBox.Name = "tELTextBox";
            this.tELTextBox.Size = new System.Drawing.Size(100, 20);
            this.tELTextBox.TabIndex = 13;
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.Location = new System.Drawing.Point(478, 343);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(100, 20);
            this.gENDERTextBox.TabIndex = 15;
            // 
            // dATEJOINEDDateTimePicker
            // 
            this.dATEJOINEDDateTimePicker.Location = new System.Drawing.Point(478, 375);
            this.dATEJOINEDDateTimePicker.Name = "dATEJOINEDDateTimePicker";
            this.dATEJOINEDDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dATEJOINEDDateTimePicker.TabIndex = 17;
            // 
            // aGETextBox
            // 
            this.aGETextBox.Location = new System.Drawing.Point(478, 410);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(100, 20);
            this.aGETextBox.TabIndex = 19;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(732, 341);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(732, 374);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(732, 408);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Controls.Add(this.dATEJOINEDLabel);
            this.Controls.Add(this.dATEJOINEDDateTimePicker);
            this.Controls.Add(this.gENDERLabel);
            this.Controls.Add(this.gENDERTextBox);
            this.Controls.Add(this.tELLabel);
            this.Controls.Add(this.tELTextBox);
            this.Controls.Add(this.cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(this.aDDRESSLabel);
            this.Controls.Add(this.aDDRESSTextBox);
            this.Controls.Add(this.lNAMELabel);
            this.Controls.Add(this.lNAMETextBox);
            this.Controls.Add(this.fNAMELabel);
            this.Controls.Add(this.fNAMETextBox);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.TextBox tELTextBox;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.DateTimePicker dATEJOINEDDateTimePicker;
        private System.Windows.Forms.TextBox aGETextBox;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label fNAMELabel;
        private System.Windows.Forms.Label lNAMELabel;
        private System.Windows.Forms.Label aDDRESSLabel;
        private System.Windows.Forms.Label cITYLabel;
        private System.Windows.Forms.Label tELLabel;
        private System.Windows.Forms.Label gENDERLabel;
        private System.Windows.Forms.Label dATEJOINEDLabel;
        private System.Windows.Forms.Label aGELabel;
        private System.Windows.Forms.Button button1;
    }
}

