
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
            this.buttonCreateDataSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateDataSet
            // 
            this.buttonCreateDataSet.Location = new System.Drawing.Point(368, 205);
            this.buttonCreateDataSet.Name = "buttonCreateDataSet";
            this.buttonCreateDataSet.Size = new System.Drawing.Size(113, 39);
            this.buttonCreateDataSet.TabIndex = 0;
            this.buttonCreateDataSet.Text = "Create dataset";
            this.buttonCreateDataSet.UseVisualStyleBackColor = true;
            this.buttonCreateDataSet.Click += new System.EventHandler(this.buttonCreateDataSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateDataSet);
            this.Name = "Form1";
            this.Text = "Oefening1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateDataSet;
    }
}

