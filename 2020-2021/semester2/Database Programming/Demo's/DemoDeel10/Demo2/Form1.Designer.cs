﻿namespace Demo2
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewStructure = new System.Windows.Forms.TreeView();
            this.buttonShowStructure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(101, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Creëer dataset";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Structuur";
            // 
            // treeViewStructure
            // 
            this.treeViewStructure.Location = new System.Drawing.Point(15, 76);
            this.treeViewStructure.Name = "treeViewStructure";
            this.treeViewStructure.Size = new System.Drawing.Size(473, 269);
            this.treeViewStructure.TabIndex = 5;
            // 
            // buttonShowStructure
            // 
            this.buttonShowStructure.Location = new System.Drawing.Point(119, 12);
            this.buttonShowStructure.Name = "buttonShowStructure";
            this.buttonShowStructure.Size = new System.Drawing.Size(101, 23);
            this.buttonShowStructure.TabIndex = 10;
            this.buttonShowStructure.Text = "Toon structuur";
            this.buttonShowStructure.UseVisualStyleBackColor = true;
            this.buttonShowStructure.Click += new System.EventHandler(this.buttonShowStructure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 357);
            this.Controls.Add(this.buttonShowStructure);
            this.Controls.Add(this.treeViewStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Demo 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewStructure;
        private System.Windows.Forms.Button buttonShowStructure;
    }
}

