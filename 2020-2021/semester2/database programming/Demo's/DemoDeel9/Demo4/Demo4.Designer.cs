namespace Demo4
{
    partial class Demo4
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonOpenUsing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSqlConnection2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSqlConnection1 = new System.Windows.Forms.CheckBox();
            this.buttonRestrictedMaxPoolSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Open!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonOpenUsing
            // 
            this.buttonOpenUsing.Location = new System.Drawing.Point(6, 20);
            this.buttonOpenUsing.Name = "buttonOpenUsing";
            this.buttonOpenUsing.Size = new System.Drawing.Size(104, 23);
            this.buttonOpenUsing.TabIndex = 1;
            this.buttonOpenUsing.Text = "Open with Using!";
            this.buttonOpenUsing.UseVisualStyleBackColor = true;
            this.buttonOpenUsing.Click += new System.EventHandler(this.buttonOpenUsing_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSqlConnection2);
            this.groupBox1.Controls.Add(this.checkBoxSqlConnection1);
            this.groupBox1.Controls.Add(this.buttonRestrictedMaxPoolSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test 3";
            // 
            // checkBoxSqlConnection2
            // 
            this.checkBoxSqlConnection2.AutoSize = true;
            this.checkBoxSqlConnection2.Location = new System.Drawing.Point(85, 88);
            this.checkBoxSqlConnection2.Name = "checkBoxSqlConnection2";
            this.checkBoxSqlConnection2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSqlConnection2.TabIndex = 4;
            this.checkBoxSqlConnection2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSqlConnection1
            // 
            this.checkBoxSqlConnection1.AutoSize = true;
            this.checkBoxSqlConnection1.Location = new System.Drawing.Point(85, 57);
            this.checkBoxSqlConnection1.Name = "checkBoxSqlConnection1";
            this.checkBoxSqlConnection1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSqlConnection1.TabIndex = 3;
            this.checkBoxSqlConnection1.UseVisualStyleBackColor = true;
            // 
            // buttonRestrictedMaxPoolSize
            // 
            this.buttonRestrictedMaxPoolSize.Location = new System.Drawing.Point(9, 20);
            this.buttonRestrictedMaxPoolSize.Name = "buttonRestrictedMaxPoolSize";
            this.buttonRestrictedMaxPoolSize.Size = new System.Drawing.Size(105, 23);
            this.buttonRestrictedMaxPoolSize.TabIndex = 2;
            this.buttonRestrictedMaxPoolSize.Text = "Open connections";
            this.buttonRestrictedMaxPoolSize.UseVisualStyleBackColor = true;
            this.buttonRestrictedMaxPoolSize.Click += new System.EventHandler(this.buttonRestrictedMaxPoolSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonOpenUsing);
            this.groupBox3.Location = new System.Drawing.Point(126, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test 2";
            // 
            // Demo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 193);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Demo4";
            this.Text = "Demo 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOpenUsing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRestrictedMaxPoolSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSqlConnection2;
        private System.Windows.Forms.CheckBox checkBoxSqlConnection1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

