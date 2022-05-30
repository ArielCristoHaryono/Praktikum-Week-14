namespace Praktikum_Week_14
{
    partial class FormTeam
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
            this.buttonPertama = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTerakhir = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelWorstDescipline = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.lblWorstDescipline = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPertama
            // 
            this.buttonPertama.Location = new System.Drawing.Point(35, 32);
            this.buttonPertama.Name = "buttonPertama";
            this.buttonPertama.Size = new System.Drawing.Size(54, 51);
            this.buttonPertama.TabIndex = 0;
            this.buttonPertama.Text = "<<";
            this.buttonPertama.UseVisualStyleBackColor = true;
            this.buttonPertama.Click += new System.EventHandler(this.buttonPertama_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(123, 32);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(54, 51);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(210, 32);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(54, 51);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTerakhir
            // 
            this.buttonTerakhir.Location = new System.Drawing.Point(296, 32);
            this.buttonTerakhir.Name = "buttonTerakhir";
            this.buttonTerakhir.Size = new System.Drawing.Size(54, 51);
            this.buttonTerakhir.TabIndex = 3;
            this.buttonTerakhir.Text = ">>";
            this.buttonTerakhir.UseVisualStyleBackColor = true;
            this.buttonTerakhir.Click += new System.EventHandler(this.buttonTerakhir_Click);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(55, 112);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(103, 20);
            this.labelTeamName.TabIndex = 4;
            this.labelTeamName.Text = "Team Name :";
            this.labelTeamName.Click += new System.EventHandler(this.labelTeamName_Click);
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(78, 144);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(80, 20);
            this.labelManager.TabIndex = 5;
            this.labelManager.Text = "Manager :";
            this.labelManager.Click += new System.EventHandler(this.labelManager_Click);
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(82, 178);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(76, 20);
            this.labelStadium.TabIndex = 6;
            this.labelStadium.Text = "Stadium :";
            this.labelStadium.Click += new System.EventHandler(this.labelStadium_Click);
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(63, 208);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(95, 20);
            this.labelTopScorer.TabIndex = 7;
            this.labelTopScorer.Text = "Top Scorer :";
            this.labelTopScorer.Click += new System.EventHandler(this.labelTopScorer_Click);
            // 
            // labelWorstDescipline
            // 
            this.labelWorstDescipline.AutoSize = true;
            this.labelWorstDescipline.Location = new System.Drawing.Point(22, 238);
            this.labelWorstDescipline.Name = "labelWorstDescipline";
            this.labelWorstDescipline.Size = new System.Drawing.Size(136, 20);
            this.labelWorstDescipline.TabIndex = 8;
            this.labelWorstDescipline.Text = "Worst Descipline :";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(179, 111);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(21, 20);
            this.lblTeamName.TabIndex = 9;
            this.lblTeamName.Text = "...";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(179, 144);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(21, 20);
            this.lblManager.TabIndex = 10;
            this.lblManager.Text = "...";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(179, 178);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(21, 20);
            this.lblStadium.TabIndex = 11;
            this.lblStadium.Text = "...";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Location = new System.Drawing.Point(179, 208);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(21, 20);
            this.lblTopScorer.TabIndex = 12;
            this.lblTopScorer.Text = "...";
            // 
            // lblWorstDescipline
            // 
            this.lblWorstDescipline.AutoSize = true;
            this.lblWorstDescipline.Location = new System.Drawing.Point(179, 238);
            this.lblWorstDescipline.Name = "lblWorstDescipline";
            this.lblWorstDescipline.Size = new System.Drawing.Size(21, 20);
            this.lblWorstDescipline.TabIndex = 13;
            this.lblWorstDescipline.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(342, 199);
            this.dataGridView1.TabIndex = 14;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWorstDescipline);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.labelWorstDescipline);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonTerakhir);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPertama);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPertama;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTerakhir;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelWorstDescipline;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblTopScorer;
        private System.Windows.Forms.Label lblWorstDescipline;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

