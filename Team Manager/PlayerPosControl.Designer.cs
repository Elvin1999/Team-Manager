namespace Team_Manager
{
    partial class PlayerPosControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.LimeGreen;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "n";
            // 
            // picturePlayer
            // 
            this.picturePlayer.BackColor = System.Drawing.Color.LimeGreen;
            this.picturePlayer.BackgroundImage = global::Team_Manager.Properties.Resources.t_shirt;
            this.picturePlayer.Image = global::Team_Manager.Properties.Resources.t_shirt;
            this.picturePlayer.Location = new System.Drawing.Point(3, 3);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(47, 56);
            this.picturePlayer.TabIndex = 0;
            this.picturePlayer.TabStop = false;
            this.picturePlayer.Click += new System.EventHandler(this.picturePlayer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerPosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.picturePlayer);
            this.Name = "PlayerPosControl";
            this.Size = new System.Drawing.Size(55, 78);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
    }
}
