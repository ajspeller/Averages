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
            this.exercise6Btn = new System.Windows.Forms.Button();
            this.excercise7Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAverages
            // 
            this.BtnAverages.Location = new System.Drawing.Point(32, 12);
            this.BtnAverages.Name = "BtnAverages";
            this.BtnAverages.Size = new System.Drawing.Size(161, 23);
            this.BtnAverages.TabIndex = 0;
            this.BtnAverages.Text = "Determine Averages";
            this.BtnAverages.UseVisualStyleBackColor = true;
            this.BtnAverages.Click += new System.EventHandler(this.button1_Click);
            // 
            // exercise6Btn
            // 
            this.exercise6Btn.Location = new System.Drawing.Point(79, 62);
            this.exercise6Btn.Name = "exercise6Btn";
            this.exercise6Btn.Size = new System.Drawing.Size(75, 23);
            this.exercise6Btn.TabIndex = 1;
            this.exercise6Btn.Text = "Problem 6";
            this.exercise6Btn.UseVisualStyleBackColor = true;
            this.exercise6Btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // excercise7Btn
            // 
            this.excercise7Btn.Location = new System.Drawing.Point(79, 105);
            this.excercise7Btn.Name = "excercise7Btn";
            this.excercise7Btn.Size = new System.Drawing.Size(75, 23);
            this.excercise7Btn.TabIndex = 2;
            this.excercise7Btn.Text = "Problem 7";
            this.excercise7Btn.UseVisualStyleBackColor = true;
            this.excercise7Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.excercise7Btn);
            this.Controls.Add(this.exercise6Btn);
            this.Controls.Add(this.BtnAverages);
            this.Name = "FrmAverages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Averages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAverages;
        private System.Windows.Forms.Button exercise6Btn;
        private System.Windows.Forms.Button excercise7Btn;
    }
}

