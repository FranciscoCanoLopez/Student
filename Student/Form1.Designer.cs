namespace Student
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LName = new Label();
            LFatherLastName = new Label();
            LMotherLastName = new Label();
            TBName = new TextBox();
            TBFatherLastName = new TextBox();
            TBMotherLastName = new TextBox();
            DTPBirthDate = new DateTimePicker();
            LBIrthDate = new Label();
            LEnrollment = new Label();
            LBEngineering = new Label();
            LBAverage = new Label();
            TBEnrollment = new TextBox();
            CBEngineering = new ComboBox();
            NUDAverage = new NumericUpDown();
            BTNSave = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDAverage).BeginInit();
            SuspendLayout();
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Location = new Point(44, 24);
            LName.Name = "LName";
            LName.Size = new Size(49, 20);
            LName.TabIndex = 0;
            LName.Text = "Name";
            // 
            // LFatherLastName
            // 
            LFatherLastName.AutoSize = true;
            LFatherLastName.Location = new Point(190, 24);
            LFatherLastName.Name = "LFatherLastName";
            LFatherLastName.Size = new Size(123, 20);
            LFatherLastName.TabIndex = 1;
            LFatherLastName.Text = "Father Last Name";
            // 
            // LMotherLastName
            // 
            LMotherLastName.AutoSize = true;
            LMotherLastName.Location = new Point(342, 24);
            LMotherLastName.Name = "LMotherLastName";
            LMotherLastName.Size = new Size(131, 20);
            LMotherLastName.TabIndex = 2;
            LMotherLastName.Text = "Mother Last Name";
            // 
            // TBName
            // 
            TBName.Location = new Point(44, 47);
            TBName.Name = "TBName";
            TBName.Size = new Size(125, 27);
            TBName.TabIndex = 3;
            // 
            // TBFatherLastName
            // 
            TBFatherLastName.Location = new Point(190, 47);
            TBFatherLastName.Name = "TBFatherLastName";
            TBFatherLastName.Size = new Size(125, 27);
            TBFatherLastName.TabIndex = 4;
            // 
            // TBMotherLastName
            // 
            TBMotherLastName.Location = new Point(342, 47);
            TBMotherLastName.Name = "TBMotherLastName";
            TBMotherLastName.Size = new Size(125, 27);
            TBMotherLastName.TabIndex = 5;
            // 
            // DTPBirthDate
            // 
            DTPBirthDate.Format = DateTimePickerFormat.Short;
            DTPBirthDate.Location = new Point(126, 106);
            DTPBirthDate.Name = "DTPBirthDate";
            DTPBirthDate.Size = new Size(124, 27);
            DTPBirthDate.TabIndex = 6;
            // 
            // LBIrthDate
            // 
            LBIrthDate.AutoSize = true;
            LBIrthDate.Location = new Point(44, 106);
            LBIrthDate.Name = "LBIrthDate";
            LBIrthDate.Size = new Size(76, 20);
            LBIrthDate.TabIndex = 7;
            LBIrthDate.Text = "Birth Date";
            // 
            // LEnrollment
            // 
            LEnrollment.AutoSize = true;
            LEnrollment.Location = new Point(44, 160);
            LEnrollment.Name = "LEnrollment";
            LEnrollment.Size = new Size(81, 20);
            LEnrollment.TabIndex = 8;
            LEnrollment.Text = "Enrollment";
            // 
            // LBEngineering
            // 
            LBEngineering.AutoSize = true;
            LBEngineering.Location = new Point(190, 160);
            LBEngineering.Name = "LBEngineering";
            LBEngineering.Size = new Size(88, 20);
            LBEngineering.TabIndex = 9;
            LBEngineering.Text = "Engineering";
            // 
            // LBAverage
            // 
            LBAverage.AutoSize = true;
            LBAverage.Location = new Point(355, 160);
            LBAverage.Name = "LBAverage";
            LBAverage.Size = new Size(64, 20);
            LBAverage.TabIndex = 10;
            LBAverage.Text = "Average";
            // 
            // TBEnrollment
            // 
            TBEnrollment.Location = new Point(44, 198);
            TBEnrollment.Name = "TBEnrollment";
            TBEnrollment.Size = new Size(125, 27);
            TBEnrollment.TabIndex = 11;
            // 
            // CBEngineering
            // 
            CBEngineering.FormattingEnabled = true;
            CBEngineering.Items.AddRange(new object[] { "Computing", "Business management", "Industrial", "Electronics", "Renewable energy", "Mechanics" });
            CBEngineering.Location = new Point(190, 197);
            CBEngineering.Name = "CBEngineering";
            CBEngineering.Size = new Size(151, 28);
            CBEngineering.TabIndex = 12;
            // 
            // NUDAverage
            // 
            NUDAverage.Location = new Point(355, 197);
            NUDAverage.Name = "NUDAverage";
            NUDAverage.Size = new Size(150, 27);
            NUDAverage.TabIndex = 13;
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(221, 261);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(94, 29);
            BTNSave.TabIndex = 14;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 318);
            Controls.Add(BTNSave);
            Controls.Add(NUDAverage);
            Controls.Add(CBEngineering);
            Controls.Add(TBEnrollment);
            Controls.Add(LBAverage);
            Controls.Add(LBEngineering);
            Controls.Add(LEnrollment);
            Controls.Add(LBIrthDate);
            Controls.Add(DTPBirthDate);
            Controls.Add(TBMotherLastName);
            Controls.Add(TBFatherLastName);
            Controls.Add(TBName);
            Controls.Add(LMotherLastName);
            Controls.Add(LFatherLastName);
            Controls.Add(LName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUDAverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LName;
        private Label LFatherLastName;
        private Label LMotherLastName;
        private TextBox TBName;
        private TextBox TBFatherLastName;
        private TextBox TBMotherLastName;
        private DateTimePicker DTPBirthDate;
        private Label LBIrthDate;
        private Label LEnrollment;
        private Label LBEngineering;
        private Label LBAverage;
        private TextBox TBEnrollment;
        private ComboBox CBEngineering;
        private NumericUpDown NUDAverage;
        private Button BTNSave;
    }
}
