namespace температура_воздуха
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.удалениеОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теплыеДниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.периодОтрицательнойТемпературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалениеОбъектовToolStripMenuItem,
            this.добавлениеОбъектовToolStripMenuItem,
            this.редактированиеОбъектовToolStripMenuItem,
            this.теплыеДниToolStripMenuItem,
            this.периодОтрицательнойТемпературыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // удалениеОбъектовToolStripMenuItem
            // 
            this.удалениеОбъектовToolStripMenuItem.Name = "удалениеОбъектовToolStripMenuItem";
            this.удалениеОбъектовToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.удалениеОбъектовToolStripMenuItem.Text = "удаление объектов";
            this.удалениеОбъектовToolStripMenuItem.Click += new System.EventHandler(this.удалениеОбъектовToolStripMenuItem_Click);
            // 
            // добавлениеОбъектовToolStripMenuItem
            // 
            this.добавлениеОбъектовToolStripMenuItem.Name = "добавлениеОбъектовToolStripMenuItem";
            this.добавлениеОбъектовToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.добавлениеОбъектовToolStripMenuItem.Text = "добавление объектов";
            this.добавлениеОбъектовToolStripMenuItem.Click += new System.EventHandler(this.добавлениеОбъектовToolStripMenuItem_Click);
            // 
            // редактированиеОбъектовToolStripMenuItem
            // 
            this.редактированиеОбъектовToolStripMenuItem.Name = "редактированиеОбъектовToolStripMenuItem";
            this.редактированиеОбъектовToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.редактированиеОбъектовToolStripMenuItem.Text = "редактирование объектов";
            this.редактированиеОбъектовToolStripMenuItem.Click += new System.EventHandler(this.редактированиеОбъектовToolStripMenuItem_Click);
            // 
            // теплыеДниToolStripMenuItem
            // 
            this.теплыеДниToolStripMenuItem.Name = "теплыеДниToolStripMenuItem";
            this.теплыеДниToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.теплыеДниToolStripMenuItem.Text = "теплые дни";
            this.теплыеДниToolStripMenuItem.Click += new System.EventHandler(this.теплыеДниToolStripMenuItem_Click);
            // 
            // периодОтрицательнойТемпературыToolStripMenuItem
            // 
            this.периодОтрицательнойТемпературыToolStripMenuItem.Name = "периодОтрицательнойТемпературыToolStripMenuItem";
            this.периодОтрицательнойТемпературыToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.периодОтрицательнойТемпературыToolStripMenuItem.Text = "период отрицательной температуры";
            this.периодОтрицательнойТемпературыToolStripMenuItem.Click += new System.EventHandler(this.периодОтрицательнойТемпературыToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(292, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "выбрать файл ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(293, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(335, 158);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалениеОбъектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеОбъектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеОбъектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теплыеДниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem периодОтрицательнойТемпературыToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public  System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}

