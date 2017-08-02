namespace Averages
{
    partial class FrmAverages
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
            this.BtnAverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAverages
            // 
            this.BtnAverages.Location = new System.Drawing.Point(68, 190);
            this.BtnAverages.Name = "BtnAverages";
            this.BtnAverages.Size = new System.Drawing.Size(161, 23);
            this.BtnAverages.TabIndex = 0;
            this.BtnAverages.Text = "Determine Averages";
            this.BtnAverages.UseVisualStyleBackColor = true;
            this.BtnAverages.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnAverages);
            this.Name = "FrmAverages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Averages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAverages;
    }
}

