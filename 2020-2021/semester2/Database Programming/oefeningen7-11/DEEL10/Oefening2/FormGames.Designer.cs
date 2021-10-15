
namespace Oefening2
{
    partial class FormGames
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGameNumber = new System.Windows.Forms.TextBox();
            this.textBoxScoreHomeTeam = new System.Windows.Forms.TextBox();
            this.textBoxScoreVisitingTeam = new System.Windows.Forms.TextBox();
            this.dateTimePickerGameDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxHomeTeam = new System.Windows.Forms.GroupBox();
            this.comboBoxHomeTeam = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVisitingTeam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VisitingTeam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HomeTeamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitingTeamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonCountNewGames = new System.Windows.Forms.Button();
            this.groupBoxHomeTeam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gamedate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Score";
            // 
            // textBoxGameNumber
            // 
            this.textBoxGameNumber.Location = new System.Drawing.Point(106, 3);
            this.textBoxGameNumber.Name = "textBoxGameNumber";
            this.textBoxGameNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameNumber.TabIndex = 1;
            // 
            // textBoxScoreHomeTeam
            // 
            this.textBoxScoreHomeTeam.Location = new System.Drawing.Point(184, 51);
            this.textBoxScoreHomeTeam.MaxLength = 2;
            this.textBoxScoreHomeTeam.Name = "textBoxScoreHomeTeam";
            this.textBoxScoreHomeTeam.Size = new System.Drawing.Size(65, 20);
            this.textBoxScoreHomeTeam.TabIndex = 2;
            // 
            // textBoxScoreVisitingTeam
            // 
            this.textBoxScoreVisitingTeam.Location = new System.Drawing.Point(47, 51);
            this.textBoxScoreVisitingTeam.MaxLength = 2;
            this.textBoxScoreVisitingTeam.Name = "textBoxScoreVisitingTeam";
            this.textBoxScoreVisitingTeam.Size = new System.Drawing.Size(65, 20);
            this.textBoxScoreVisitingTeam.TabIndex = 2;
            // 
            // dateTimePickerGameDate
            // 
            this.dateTimePickerGameDate.Location = new System.Drawing.Point(106, 36);
            this.dateTimePickerGameDate.Name = "dateTimePickerGameDate";
            this.dateTimePickerGameDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGameDate.TabIndex = 3;
            // 
            // groupBoxHomeTeam
            // 
            this.groupBoxHomeTeam.Controls.Add(this.comboBoxHomeTeam);
            this.groupBoxHomeTeam.Controls.Add(this.textBoxScoreHomeTeam);
            this.groupBoxHomeTeam.Controls.Add(this.label5);
            this.groupBoxHomeTeam.Location = new System.Drawing.Point(7, 89);
            this.groupBoxHomeTeam.Name = "groupBoxHomeTeam";
            this.groupBoxHomeTeam.Size = new System.Drawing.Size(255, 86);
            this.groupBoxHomeTeam.TabIndex = 4;
            this.groupBoxHomeTeam.TabStop = false;
            this.groupBoxHomeTeam.Text = "Home team";
            // 
            // comboBoxHomeTeam
            // 
            this.comboBoxHomeTeam.FormattingEnabled = true;
            this.comboBoxHomeTeam.Location = new System.Drawing.Point(6, 19);
            this.comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            this.comboBoxHomeTeam.Size = new System.Drawing.Size(243, 21);
            this.comboBoxHomeTeam.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVisitingTeam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxScoreVisitingTeam);
            this.groupBox1.Location = new System.Drawing.Point(268, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visiting team";
            // 
            // comboBoxVisitingTeam
            // 
            this.comboBoxVisitingTeam.FormattingEnabled = true;
            this.comboBoxVisitingTeam.Location = new System.Drawing.Point(6, 19);
            this.comboBoxVisitingTeam.Name = "comboBoxVisitingTeam";
            this.comboBoxVisitingTeam.Size = new System.Drawing.Size(243, 21);
            this.comboBoxVisitingTeam.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Schedule";
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GameDate,
            this.HomeTeam,
            this.VisitingTeam,
            this.HomeTeamScore,
            this.VisitingTeamScore});
            this.dataGridViewSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(633, 244);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // GameDate
            // 
            this.GameDate.DataPropertyName = "GameDate";
            this.GameDate.HeaderText = "Game date";
            this.GameDate.Name = "GameDate";
            this.GameDate.ReadOnly = true;
            // 
            // HomeTeam
            // 
            this.HomeTeam.DataPropertyName = "HomeTeam";
            this.HomeTeam.HeaderText = "Home team";
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.ReadOnly = true;
            // 
            // VisitingTeam
            // 
            this.VisitingTeam.DataPropertyName = "VisitingTeam";
            this.VisitingTeam.HeaderText = "Visiting team";
            this.VisitingTeam.Name = "VisitingTeam";
            this.VisitingTeam.ReadOnly = true;
            // 
            // HomeTeamScore
            // 
            this.HomeTeamScore.DataPropertyName = "HomeTeamScore";
            this.HomeTeamScore.HeaderText = "Home team score";
            this.HomeTeamScore.Name = "HomeTeamScore";
            this.HomeTeamScore.ReadOnly = true;
            // 
            // VisitingTeamScore
            // 
            this.VisitingTeamScore.DataPropertyName = "VisitingTeamScore";
            this.VisitingTeamScore.HeaderText = "Visiting team score";
            this.VisitingTeamScore.Name = "VisitingTeamScore";
            this.VisitingTeamScore.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonCountNewGames);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDeleteGame);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddGame);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxGameNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxHomeTeam);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerGameDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSchedule);
            this.splitContainer1.Size = new System.Drawing.Size(633, 496);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 16;
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Location = new System.Drawing.Point(117, 191);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteGame.TabIndex = 7;
            this.buttonDeleteGame.Text = "Delete game";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            this.buttonDeleteGame.Click += new System.EventHandler(this.buttonDeleteGame_Click);
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Location = new System.Drawing.Point(7, 191);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(104, 23);
            this.buttonAddGame.TabIndex = 6;
            this.buttonAddGame.Text = "Add game";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // buttonCountNewGames
            // 
            this.buttonCountNewGames.Location = new System.Drawing.Point(227, 191);
            this.buttonCountNewGames.Name = "buttonCountNewGames";
            this.buttonCountNewGames.Size = new System.Drawing.Size(104, 23);
            this.buttonCountNewGames.TabIndex = 8;
            this.buttonCountNewGames.Text = "Count new games";
            this.buttonCountNewGames.UseVisualStyleBackColor = true;
            this.buttonCountNewGames.Click += new System.EventHandler(this.buttonCountNewGames_Click);
            // 
            // FormGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 496);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGames";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.FormGames_Load);
            this.groupBoxHomeTeam.ResumeLayout(false);
            this.groupBoxHomeTeam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGameNumber;
        private System.Windows.Forms.TextBox textBoxScoreHomeTeam;
        private System.Windows.Forms.TextBox textBoxScoreVisitingTeam;
        private System.Windows.Forms.DateTimePicker dateTimePickerGameDate;
        private System.Windows.Forms.GroupBox groupBoxHomeTeam;
        private System.Windows.Forms.ComboBox comboBoxHomeTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxVisitingTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonDeleteGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn HomeTeam;
        private System.Windows.Forms.DataGridViewComboBoxColumn VisitingTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitingTeamScore;
        private System.Windows.Forms.Button buttonCountNewGames;
    }
}

