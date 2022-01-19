
namespace VK.CSW.Bibl
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
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMagazines = new System.Windows.Forms.TabPage();
            this.checkBoxMagInStock = new System.Windows.Forms.CheckBox();
            this.checkBoxMagSubscribe = new System.Windows.Forms.CheckBox();
            this.buttonMagAdd = new System.Windows.Forms.Button();
            this.numericUpDownMagUnitNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownMagYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMagNumber = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMagVolume = new System.Windows.Forms.TextBox();
            this.textBoxMagTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.checkBoxInStock = new System.Windows.Forms.CheckBox();
            this.checkBoxOnTime = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownUnitNumber = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownUsePeriod = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMagazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagUnitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagNumber)).BeginInit();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUsePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Location = new System.Drawing.Point(327, 37);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.Size = new System.Drawing.Size(429, 311);
            this.richTextBoxReport.TabIndex = 1;
            this.richTextBoxReport.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMagazines);
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 426);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPageMagazines
            // 
            this.tabPageMagazines.Controls.Add(this.checkBoxMagInStock);
            this.tabPageMagazines.Controls.Add(this.checkBoxMagSubscribe);
            this.tabPageMagazines.Controls.Add(this.buttonMagAdd);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagUnitNumber);
            this.tabPageMagazines.Controls.Add(this.label9);
            this.tabPageMagazines.Controls.Add(this.label10);
            this.tabPageMagazines.Controls.Add(this.label11);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagYear);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagNumber);
            this.tabPageMagazines.Controls.Add(this.label13);
            this.tabPageMagazines.Controls.Add(this.textBoxMagVolume);
            this.tabPageMagazines.Controls.Add(this.textBoxMagTitle);
            this.tabPageMagazines.Controls.Add(this.label14);
            this.tabPageMagazines.Location = new System.Drawing.Point(4, 25);
            this.tabPageMagazines.Name = "tabPageMagazines";
            this.tabPageMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMagazines.Size = new System.Drawing.Size(286, 397);
            this.tabPageMagazines.TabIndex = 0;
            this.tabPageMagazines.Text = "Magazines";
            this.tabPageMagazines.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagInStock
            // 
            this.checkBoxMagInStock.AutoSize = true;
            this.checkBoxMagInStock.Location = new System.Drawing.Point(35, 290);
            this.checkBoxMagInStock.Name = "checkBoxMagInStock";
            this.checkBoxMagInStock.Size = new System.Drawing.Size(80, 21);
            this.checkBoxMagInStock.TabIndex = 33;
            this.checkBoxMagInStock.Text = "in Stock";
            this.checkBoxMagInStock.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagSubscribe
            // 
            this.checkBoxMagSubscribe.AutoSize = true;
            this.checkBoxMagSubscribe.Location = new System.Drawing.Point(167, 290);
            this.checkBoxMagSubscribe.Name = "checkBoxMagSubscribe";
            this.checkBoxMagSubscribe.Size = new System.Drawing.Size(116, 26);
            this.checkBoxMagSubscribe.TabIndex = 32;
            this.checkBoxMagSubscribe.Text = "Subscribe";
            this.checkBoxMagSubscribe.UseVisualStyleBackColor = true;
            // 
            // buttonMagAdd
            // 
            this.buttonMagAdd.Location = new System.Drawing.Point(24, 336);
            this.buttonMagAdd.Name = "buttonMagAdd";
            this.buttonMagAdd.Size = new System.Drawing.Size(161, 49);
            this.buttonMagAdd.TabIndex = 31;
            this.buttonMagAdd.Text = "Add";
            this.buttonMagAdd.UseVisualStyleBackColor = true;
            this.buttonMagAdd.Click += new System.EventHandler(this.buttonMagAdd_Click);
            // 
            // numericUpDownMagUnitNumber
            // 
            this.numericUpDownMagUnitNumber.Location = new System.Drawing.Point(112, 212);
            this.numericUpDownMagUnitNumber.Name = "numericUpDownMagUnitNumber";
            this.numericUpDownMagUnitNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMagUnitNumber.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Unit number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Number";
            // 
            // numericUpDownMagYear
            // 
            this.numericUpDownMagYear.Location = new System.Drawing.Point(112, 174);
            this.numericUpDownMagYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownMagYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownMagYear.Name = "numericUpDownMagYear";
            this.numericUpDownMagYear.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMagYear.TabIndex = 24;
            this.numericUpDownMagYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDownMagNumber
            // 
            this.numericUpDownMagNumber.Location = new System.Drawing.Point(112, 134);
            this.numericUpDownMagNumber.Name = "numericUpDownMagNumber";
            this.numericUpDownMagNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMagNumber.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Volume";
            // 
            // textBoxMagVolume
            // 
            this.textBoxMagVolume.Location = new System.Drawing.Point(94, 50);
            this.textBoxMagVolume.Name = "textBoxMagVolume";
            this.textBoxMagVolume.Size = new System.Drawing.Size(171, 22);
            this.textBoxMagVolume.TabIndex = 20;
            // 
            // textBoxMagTitle
            // 
            this.textBoxMagTitle.Location = new System.Drawing.Point(94, 11);
            this.textBoxMagTitle.Name = "textBoxMagTitle";
            this.textBoxMagTitle.Size = new System.Drawing.Size(171, 22);
            this.textBoxMagTitle.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Title";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.checkBoxInStock);
            this.tabPageBooks.Controls.Add(this.checkBoxOnTime);
            this.tabPageBooks.Controls.Add(this.buttonAdd);
            this.tabPageBooks.Controls.Add(this.numericUpDownUnitNumber);
            this.tabPageBooks.Controls.Add(this.label15);
            this.tabPageBooks.Controls.Add(this.numericUpDownUsePeriod);
            this.tabPageBooks.Controls.Add(this.label16);
            this.tabPageBooks.Controls.Add(this.label17);
            this.tabPageBooks.Controls.Add(this.label18);
            this.tabPageBooks.Controls.Add(this.numericUpDownYear);
            this.tabPageBooks.Controls.Add(this.numericUpDownPages);
            this.tabPageBooks.Controls.Add(this.textBoxPublisher);
            this.tabPageBooks.Controls.Add(this.label19);
            this.tabPageBooks.Controls.Add(this.label20);
            this.tabPageBooks.Controls.Add(this.textBoxTitle);
            this.tabPageBooks.Controls.Add(this.textBoxAuthor);
            this.tabPageBooks.Controls.Add(this.label21);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(286, 397);
            this.tabPageBooks.TabIndex = 1;
            this.tabPageBooks.Text = "Books";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // checkBoxInStock
            // 
            this.checkBoxInStock.AutoSize = true;
            this.checkBoxInStock.Location = new System.Drawing.Point(35, 290);
            this.checkBoxInStock.Name = "checkBoxInStock";
            this.checkBoxInStock.Size = new System.Drawing.Size(80, 21);
            this.checkBoxInStock.TabIndex = 33;
            this.checkBoxInStock.Text = "in Stock";
            this.checkBoxInStock.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnTime
            // 
            this.checkBoxOnTime.AutoSize = true;
            this.checkBoxOnTime.Location = new System.Drawing.Point(167, 290);
            this.checkBoxOnTime.Name = "checkBoxOnTime";
            this.checkBoxOnTime.Size = new System.Drawing.Size(81, 21);
            this.checkBoxOnTime.TabIndex = 32;
            this.checkBoxOnTime.Text = "on Time";
            this.checkBoxOnTime.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 49);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownUnitNumber
            // 
            this.numericUpDownUnitNumber.Location = new System.Drawing.Point(112, 212);
            this.numericUpDownUnitNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownUnitNumber.Name = "numericUpDownUnitNumber";
            this.numericUpDownUnitNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownUnitNumber.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Use Period";
            // 
            // numericUpDownUsePeriod
            // 
            this.numericUpDownUsePeriod.Location = new System.Drawing.Point(112, 252);
            this.numericUpDownUsePeriod.Name = "numericUpDownUsePeriod";
            this.numericUpDownUsePeriod.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownUsePeriod.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Unit number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "Year";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Pages";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(112, 174);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownYear.TabIndex = 24;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(112, 134);
            this.numericUpDownPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPages.TabIndex = 23;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(94, 88);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(171, 22);
            this.textBoxPublisher.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Publisher";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 17);
            this.label20.TabIndex = 19;
            this.label20.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(94, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(171, 22);
            this.textBoxTitle.TabIndex = 20;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(94, 11);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(171, 22);
            this.textBoxAuthor.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 17;
            this.label21.Text = "Author";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(327, 373);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(191, 49);
            this.buttonView.TabIndex = 35;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(546, 385);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(158, 21);
            this.checkBoxSort.TabIndex = 36;
            this.checkBoxSort.Text = "Sort by Unit Number";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.checkBoxSort);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBoxReport);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMagazines.ResumeLayout(false);
            this.tabPageMagazines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagUnitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagNumber)).EndInit();
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUsePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMagazines;
        private System.Windows.Forms.CheckBox checkBoxMagInStock;
        private System.Windows.Forms.CheckBox checkBoxMagSubscribe;
        private System.Windows.Forms.Button buttonMagAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownMagUnitNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownMagYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMagNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMagVolume;
        private System.Windows.Forms.TextBox textBoxMagTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.CheckBox checkBoxInStock;
        private System.Windows.Forms.CheckBox checkBoxOnTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownUnitNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownUsePeriod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.CheckBox checkBoxSort;
    }
}

