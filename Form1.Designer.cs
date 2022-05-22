
namespace async_await
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.pobierzButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(226, 22);
            this.textBox.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(13, 42);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(226, 132);
            this.listBox.TabIndex = 1;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(342, 13);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // pobierzButton
            // 
            this.pobierzButton.Location = new System.Drawing.Point(342, 150);
            this.pobierzButton.Name = "pobierzButton";
            this.pobierzButton.Size = new System.Drawing.Size(75, 23);
            this.pobierzButton.TabIndex = 3;
            this.pobierzButton.Text = "Pobierz";
            this.pobierzButton.UseVisualStyleBackColor = true;
            this.pobierzButton.Click += new System.EventHandler(this.pobierzButton_Click);
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(342, 42);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 4;
            this.usunButton.Text = "Usun";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.pobierzButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Asyn await";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button pobierzButton;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Label label1;
    }
}

