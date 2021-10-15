
namespace Oefening3
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
            this.LB_Records = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Record_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Records
            // 
            this.LB_Records.FormattingEnabled = true;
            this.LB_Records.ItemHeight = 20;
            this.LB_Records.Location = new System.Drawing.Point(111, 60);
            this.LB_Records.Name = "LB_Records";
            this.LB_Records.Size = new System.Drawing.Size(599, 244);
            this.LB_Records.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "records";
            // 
            // Record_btn
            // 
            this.Record_btn.Location = new System.Drawing.Point(598, 322);
            this.Record_btn.Name = "Record_btn";
            this.Record_btn.Size = new System.Drawing.Size(112, 35);
            this.Record_btn.TabIndex = 2;
            this.Record_btn.Text = "getRecords";
            this.Record_btn.UseVisualStyleBackColor = true;
            this.Record_btn.Click += new System.EventHandler(this.Record_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Record_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Records);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Record_btn;
    }
}

