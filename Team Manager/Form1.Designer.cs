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
            this.labelPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTopLabels = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            this.groupBoxTopLabels.SuspendLayout();
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
            this.pictureFlag.Location = new System.Drawing.Point(371, 4);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(72, 28);
            this.pictureFlag.TabIndex = 2;
            this.pictureFlag.TabStop = false;
            this.pictureFlag.Click += new System.EventHandler(this.pictureFlag_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(6, 16);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(100, 23);
            this.labelPosition.TabIndex = 3;
            this.labelPosition.Text = "Position";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // groupBoxTopLabels
            // 
            this.groupBoxTopLabels.Controls.Add(this.labelPosition);
            this.groupBoxTopLabels.Controls.Add(this.label2);
            this.groupBoxTopLabels.Controls.Add(this.label1);
            this.groupBoxTopLabels.Location = new System.Drawing.Point(12, 38);
            this.groupBoxTopLabels.Name = "groupBoxTopLabels";
            this.groupBoxTopLabels.Size = new System.Drawing.Size(441, 49);
            this.groupBoxTopLabels.TabIndex = 4;
            this.groupBoxTopLabels.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 619);
            this.Controls.Add(this.groupBoxTopLabels);
            this.Controls.Add(this.pictureFlag);
            this.Controls.Add(this.metroCmCountry);
            this.Controls.Add(this.labelCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            this.groupBoxTopLabels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private MetroFramework.Controls.MetroComboBox metroCmCountry;
        private System.Windows.Forms.PictureBox pictureFlag;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTopLabels;
    }
}

