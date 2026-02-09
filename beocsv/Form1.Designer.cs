namespace beocsv
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
            this.buttonLoadCsv = new System.Windows.Forms.Button();
            this.buttonSaveToDb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadCsv
            // 
            this.buttonLoadCsv.Location = new System.Drawing.Point(86, 12);
            this.buttonLoadCsv.Name = "buttonLoadCsv";
            this.buttonLoadCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadCsv.TabIndex = 0;
            this.buttonLoadCsv.Text = "betolt";
            this.buttonLoadCsv.UseVisualStyleBackColor = true;
            this.buttonLoadCsv.Click += new System.EventHandler(this.buttonLoadCsv_Click);
            // 
            // buttonSaveToDb
            // 
            this.buttonSaveToDb.Location = new System.Drawing.Point(86, 41);
            this.buttonSaveToDb.Name = "buttonSaveToDb";
            this.buttonSaveToDb.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToDb.TabIndex = 1;
            this.buttonSaveToDb.Text = "db mentes";
            this.buttonSaveToDb.UseVisualStyleBackColor = true;
            this.buttonSaveToDb.Click += new System.EventHandler(this.buttonSaveToDb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 282);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(634, 268);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(634, 294);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(634, 320);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(86, 70);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStudent.TabIndex = 6;
            this.buttonAddStudent.Text = "hozzaad";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveToDb);
            this.Controls.Add(this.buttonLoadCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadCsv;
        private System.Windows.Forms.Button buttonSaveToDb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}

