namespace Homework_WF
{
    partial class Store
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Items.AddRange(new object[] {
            ""});
            this.itemsListBox.Location = new System.Drawing.Point(12, 12);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(392, 108);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(458, 71);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(116, 40);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить в корзину";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Upload_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(479, 42);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(26, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "0 тг";
            // 
            // SalesAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 131);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.itemsListBox);
            this.Name = "SalesAccounting";
            this.Text = "Учет продаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label priceLabel;
    }
}

