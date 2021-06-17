
namespace Oefening1
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
            this.btn_CreateDataset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateDataset
            // 
            this.btn_CreateDataset.Location = new System.Drawing.Point(340, 206);
            this.btn_CreateDataset.Name = "btn_CreateDataset";
            this.btn_CreateDataset.Size = new System.Drawing.Size(103, 41);
            this.btn_CreateDataset.TabIndex = 0;
            this.btn_CreateDataset.Text = "CreateDataSet";
            this.btn_CreateDataset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateDataset);
            this.Name = "Form1";
            this.Text = "Oefening1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateDataset;
    }
}

