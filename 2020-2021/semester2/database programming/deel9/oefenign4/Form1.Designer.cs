
namespace oefenign4
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
            this.btn_filter = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.ListBox();
            this.tb_Naam = new System.Windows.Forms.TextBox();
            this.tb_Voornaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(54, 384);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(99, 39);
            this.btn_filter.TabIndex = 0;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.ItemHeight = 20;
            this.lb_output.Location = new System.Drawing.Point(54, 174);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(470, 204);
            this.lb_output.TabIndex = 1;
            // 
            // tb_Naam
            // 
            this.tb_Naam.Location = new System.Drawing.Point(54, 88);
            this.tb_Naam.Name = "tb_Naam";
            this.tb_Naam.Size = new System.Drawing.Size(198, 26);
            this.tb_Naam.TabIndex = 2;
            // 
            // tb_Voornaam
            // 
            this.tb_Voornaam.Location = new System.Drawing.Point(54, 142);
            this.tb_Voornaam.Name = "tb_Voornaam";
            this.tb_Voornaam.Size = new System.Drawing.Size(198, 26);
            this.tb_Voornaam.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Voornaam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Voornaam);
            this.Controls.Add(this.tb_Naam);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_filter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ListBox lb_output;
        private System.Windows.Forms.TextBox tb_Naam;
        private System.Windows.Forms.TextBox tb_Voornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

