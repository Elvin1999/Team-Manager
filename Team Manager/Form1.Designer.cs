﻿namespace Team_Manager
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
            this.labelPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTopLabels = new System.Windows.Forms.GroupBox();
            this.metroCbPosition = new MetroFramework.Controls.MetroComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTopLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(12, 9);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(75, 24);
            this.labelCountry.TabIndex = 0;
            this.labelCountry.Text = "Country";
            // 
            // metroCmCountry
            // 
            this.metroCmCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.metroCmCountry.FormattingEnabled = true;
            this.metroCmCountry.ItemHeight = 23;
            this.metroCmCountry.Location = new System.Drawing.Point(109, 4);
            this.metroCmCountry.Name = "metroCmCountry";
            this.metroCmCountry.Size = new System.Drawing.Size(192, 29);
            this.metroCmCountry.TabIndex = 1;
            this.metroCmCountry.UseCustomBackColor = true;
            this.metroCmCountry.UseCustomForeColor = true;
            this.metroCmCountry.UseSelectable = true;
            this.metroCmCountry.UseStyleColors = true;
            this.metroCmCountry.SelectedIndexChanged += new System.EventHandler(this.metroCmCountry_SelectedIndexChanged);
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
            // metroCbPosition
            // 
            this.metroCbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.metroCbPosition.FormattingEnabled = true;
            this.metroCbPosition.ItemHeight = 23;
            this.metroCbPosition.Location = new System.Drawing.Point(328, 3);
            this.metroCbPosition.Name = "metroCbPosition";
            this.metroCbPosition.Size = new System.Drawing.Size(125, 29);
            this.metroCbPosition.TabIndex = 5;
            this.metroCbPosition.UseCustomBackColor = true;
            this.metroCbPosition.UseCustomForeColor = true;
            this.metroCbPosition.UseSelectable = true;
            this.metroCbPosition.UseStyleColors = true;
            this.metroCbPosition.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(381, 557);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(121, 54);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(509, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(539, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.metroCbPosition);
            this.Controls.Add(this.groupBoxTopLabels);
            this.Controls.Add(this.metroCmCountry);
            this.Controls.Add(this.labelCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTopLabels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private MetroFramework.Controls.MetroComboBox metroCmCountry;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTopLabels;
        private MetroFramework.Controls.MetroComboBox metroCbPosition;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button button1;
    }
}

