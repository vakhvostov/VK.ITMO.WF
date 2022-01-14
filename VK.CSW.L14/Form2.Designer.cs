
namespace VK.CSW.L14
{
    partial class Form2
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
            this.GoGreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoGreenButton
            // 
            this.GoGreenButton.Location = new System.Drawing.Point(234, 106);
            this.GoGreenButton.Name = "GoGreenButton";
            this.GoGreenButton.Size = new System.Drawing.Size(296, 192);
            this.GoGreenButton.TabIndex = 0;
            this.GoGreenButton.Text = "GoGreen";
            this.GoGreenButton.UseVisualStyleBackColor = true;
            this.GoGreenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoGreenButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoGreenButton;
    }
}