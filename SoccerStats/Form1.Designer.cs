namespace SoccerStats
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertNameBox = new System.Windows.Forms.TextBox();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.updateNewValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertTeamBox = new System.Windows.Forms.TextBox();
            this.insertGoalBox = new System.Windows.Forms.TextBox();
            this.insertAssistBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboField = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(749, 376);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(709, 577);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertNameBox
            // 
            this.insertNameBox.Location = new System.Drawing.Point(581, 95);
            this.insertNameBox.Name = "insertNameBox";
            this.insertNameBox.Size = new System.Drawing.Size(100, 20);
            this.insertNameBox.TabIndex = 4;
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(581, 376);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 4;
            // 
            // updateNewValueBox
            // 
            this.updateNewValueBox.Location = new System.Drawing.Point(789, 536);
            this.updateNewValueBox.Name = "updateNewValueBox";
            this.updateNewValueBox.Size = new System.Drawing.Size(100, 20);
            this.updateNewValueBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "change to";
            // 
            // insertTeamBox
            // 
            this.insertTeamBox.Location = new System.Drawing.Point(581, 147);
            this.insertTeamBox.Name = "insertTeamBox";
            this.insertTeamBox.Size = new System.Drawing.Size(100, 20);
            this.insertTeamBox.TabIndex = 4;
            // 
            // insertGoalBox
            // 
            this.insertGoalBox.Location = new System.Drawing.Point(581, 203);
            this.insertGoalBox.Name = "insertGoalBox";
            this.insertGoalBox.Size = new System.Drawing.Size(100, 20);
            this.insertGoalBox.TabIndex = 4;
            // 
            // insertAssistBox
            // 
            this.insertAssistBox.Location = new System.Drawing.Point(581, 254);
            this.insertAssistBox.Name = "insertAssistBox";
            this.insertAssistBox.Size = new System.Drawing.Size(100, 20);
            this.insertAssistBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Field";
            // 
            // comboField
            // 
            this.comboField.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Team",
            "Goals",
            "Assists"});
            this.comboField.FormattingEnabled = true;
            this.comboField.Location = new System.Drawing.Point(581, 536);
            this.comboField.Name = "comboField";
            this.comboField.Size = new System.Drawing.Size(121, 21);
            this.comboField.TabIndex = 6;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(695, 499);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 625);
            this.Controls.Add(this.comboField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.updateNewValueBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.insertAssistBox);
            this.Controls.Add(this.insertGoalBox);
            this.Controls.Add(this.insertTeamBox);
            this.Controls.Add(this.insertNameBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox insertNameBox;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.TextBox updateNewValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertTeamBox;
        private System.Windows.Forms.TextBox insertGoalBox;
        private System.Windows.Forms.TextBox insertAssistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboField;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label3;
    }
}

