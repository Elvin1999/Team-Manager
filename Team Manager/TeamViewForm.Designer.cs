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
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.labelCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(132, 69);
            this.pictureBoxFlag.TabIndex = 0;
            this.pictureBoxFlag.TabStop = false;
            // 
            // labelCountry
            // 
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(195, 13);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(116, 45);
            this.labelCountry.TabIndex = 1;
            // 
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 524);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.pictureBoxFlag);
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label labelCountry;
    }
}