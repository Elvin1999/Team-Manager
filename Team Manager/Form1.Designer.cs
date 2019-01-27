namespace Team_Manager
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.metroCmCountry = new MetroFramework.Controls.MetroComboBox();
            this.pictureFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(12, 9);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(64, 20);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Country";
            // 
            // metroCmCountry
            // 
            this.metroCmCountry.FormattingEnabled = true;
            this.metroCmCountry.ItemHeight = 23;
            this.metroCmCountry.Location = new System.Drawing.Point(154, 3);
            this.metroCmCountry.Name = "metroCmCountry";
            this.metroCmCountry.Size = new System.Drawing.Size(192, 29);
            this.metroCmCountry.TabIndex = 1;
            this.metroCmCountry.SelectedIndexChanged += new System.EventHandler(this.metroCmCountry_SelectedIndexChanged);
            // 
            // pictureFlag
            // 
            this.pictureFlag.Location = new System.Drawing.Point(99, 87);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(124, 64);
            this.pictureFlag.TabIndex = 2;
            this.pictureFlag.TabStop = false;
            this.pictureFlag.Click += new System.EventHandler(this.pictureFlag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 473);
            this.Controls.Add(this.pictureFlag);
            this.Controls.Add(this.metroCmCountry);
            this.Controls.Add(this.labelCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private MetroFramework.Controls.MetroComboBox metroCmCountry;
        private System.Windows.Forms.PictureBox pictureFlag;
    }
}

