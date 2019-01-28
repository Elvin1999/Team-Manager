namespace Team_Manager
{
    partial class TeamViewForm
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
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.labelCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.Image = global::Team_Manager.Properties.Resources.soccer_field_148894_960_720;
            this.pictureBoxTeam.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(519, 726);
            this.pictureBoxTeam.TabIndex = 2;
            this.pictureBoxTeam.TabStop = false;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(132, 60);
            this.pictureBoxFlag.TabIndex = 3;
            this.pictureBoxFlag.TabStop = false;
            // 
            // labelCountry
            // 
            this.labelCountry.Location = new System.Drawing.Point(386, 2);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(111, 41);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "label1";
            // 
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 740);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.pictureBoxTeam);
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label labelCountry;
    }
}