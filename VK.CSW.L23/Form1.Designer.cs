
namespace VK.CSW.L23
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRegistrationData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.groupBoxRegistrationData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistrationData
            // 
            this.groupBoxRegistrationData.Controls.Add(this.textBox2);
            this.groupBoxRegistrationData.Controls.Add(this.label2);
            this.groupBoxRegistrationData.Controls.Add(this.label1);
            this.groupBoxRegistrationData.Controls.Add(this.textBox1);
            this.groupBoxRegistrationData.Location = new System.Drawing.Point(36, 51);
            this.groupBoxRegistrationData.Name = "groupBoxRegistrationData";
            this.groupBoxRegistrationData.Size = new System.Drawing.Size(528, 195);
            this.groupBoxRegistrationData.TabIndex = 0;
            this.groupBoxRegistrationData.TabStop = false;
            this.groupBoxRegistrationData.Text = "Enter registration data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdvanced
            // 
            this.checkBoxAdvanced.AutoSize = true;
            this.checkBoxAdvanced.Location = new System.Drawing.Point(36, 272);
            this.checkBoxAdvanced.Name = "checkBoxAdvanced";
            this.checkBoxAdvanced.Size = new System.Drawing.Size(132, 21);
            this.checkBoxAdvanced.TabIndex = 2;
            this.checkBoxAdvanced.Text = "Advanced mode";
            this.checkBoxAdvanced.UseVisualStyleBackColor = true;
            this.checkBoxAdvanced.CheckedChanged += new System.EventHandler(this.checkBoxAdvanced_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAdvanced);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxRegistrationData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRegistrationData.ResumeLayout(false);
            this.groupBoxRegistrationData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistrationData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAdvanced;
    }
}

