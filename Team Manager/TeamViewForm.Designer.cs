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
            this.labelCountry = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.BackColor = System.Drawing.Color.LimeGreen;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(386, 2);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(133, 25);
            this.labelCountry.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(482, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxFlag.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(132, 60);
            this.pictureBoxFlag.TabIndex = 3;
            this.pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxTeam.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(519, 738);
            this.pictureBoxTeam.TabIndex = 2;
            this.pictureBoxTeam.TabStop = false;
            // 
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(519, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.pictureBoxTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Button button1;
    }
}