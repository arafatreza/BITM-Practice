namespace Coffee_Shop
{
    partial class CoffeeShop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.orderComboBox);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.contactNoTextBox);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.orderLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.contactNoLabel);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Location = new System.Drawing.Point(32, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 371);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(205, 325);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(159, 231);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox.TabIndex = 11;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(159, 270);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(159, 144);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(159, 99);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactNoTextBox.TabIndex = 9;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(159, 41);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerNameTextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(23, 272);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(23, 235);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(33, 13);
            this.orderLabel.TabIndex = 6;
            this.orderLabel.Text = "Order";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(23, 142);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address";
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Location = new System.Drawing.Point(23, 94);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(61, 13);
            this.contactNoLabel.TabIndex = 4;
            this.contactNoLabel.Text = "Contact No";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(23, 44);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(458, 67);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(299, 348);
            this.showRichTextBox.TabIndex = 1;
            this.showRichTextBox.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(26, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(308, 36);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Customer Information";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(26, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(107, 325);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 14;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "CoffeeShop";
            this.Text = "CoffeeShop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
    }
}

