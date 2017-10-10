namespace Homework_WF
{
    partial class Basket
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
            this.productsListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Characteristic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buy = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Characteristic,
            this.Description,
            this.Price});
            this.productsListView.GridLines = true;
            this.productsListView.Location = new System.Drawing.Point(13, 13);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(815, 368);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Имя";
            this.Name.Width = 171;
            // 
            // Characteristic
            // 
            this.Characteristic.Text = "Характеристика";
            this.Characteristic.Width = 239;
            // 
            // Description
            // 
            this.Description.Text = "Описание";
            this.Description.Width = 251;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(752, 390);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 1;
            this.buy.Text = "Купить";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(13, 389);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 425);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.productsListView);
            this.Text = "Корзина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Characteristic;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ColumnHeader Price;
    }
}