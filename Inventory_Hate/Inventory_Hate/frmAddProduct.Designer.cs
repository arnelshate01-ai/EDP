namespace Inventory
{
    partial class frmAddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRODUCT*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CATEGORY*";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(107, 68);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(201, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "MFG. DATE*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "EXP. DATE*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(17, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "QTY.*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(17, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "SELL PRICE*";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(107, 103);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(201, 21);
            this.cbCategory.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(107, 176);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(201, 20);
            this.dtPickerExpDate.TabIndex = 11;
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Location = new System.Drawing.Point(107, 140);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(201, 20);
            this.dtPickerMfgDate.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(107, 212);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(201, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(107, 248);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(201, 20);
            this.txtSellPrice.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.label9.Location = new System.Drawing.Point(341, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "DESCRIPTION";
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.BackColor = System.Drawing.Color.White;
            this.richTxtDescription.Location = new System.Drawing.Point(344, 91);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(256, 177);
            this.richTxtDescription.TabIndex = 16;
            this.richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(149)))), ((int)(((byte)(88)))));
            this.btnAddProduct.Location = new System.Drawing.Point(16, 283);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(103, 33);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.AccessibleName = "";
            this.gridViewProductList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(15, 325);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.Size = new System.Drawing.Size(585, 150);
            this.gridViewProductList.TabIndex = 18;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 498);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}

