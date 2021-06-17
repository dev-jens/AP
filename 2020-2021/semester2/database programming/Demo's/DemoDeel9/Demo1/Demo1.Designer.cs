namespace Demo1
{
    partial class Demo1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxConnectionStrings = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection string";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(144, 27);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(336, 20);
            this.textBoxConnectionString.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecteer connection string";
            // 
            // comboBoxConnectionStrings
            // 
            this.comboBoxConnectionStrings.FormattingEnabled = true;
            this.comboBoxConnectionStrings.Location = new System.Drawing.Point(144, 0);
            this.comboBoxConnectionStrings.Name = "comboBoxConnectionStrings";
            this.comboBoxConnectionStrings.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConnectionStrings.TabIndex = 4;
            this.comboBoxConnectionStrings.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnectionStrings_SelectedIndexChanged);
            // 
            // Demo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 99);
            this.Controls.Add(this.comboBoxConnectionStrings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConnectionString);
            this.Controls.Add(this.label1);
            this.Name = "Demo1";
            this.Text = "Demo 1";
            this.Load += new System.EventHandler(this.Demo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxConnectionStrings;
    }
}

