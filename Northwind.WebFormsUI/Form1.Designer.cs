namespace Northwind.WebFormsUI
{
    partial class Form1
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
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.tbxProduct = new System.Windows.Forms.TextBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.cbxCategoryId = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.tbxStock = new System.Windows.Forms.TextBox();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.lblStok = new System.Windows.Forms.Label();
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.lblQuantityForLimit = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
			this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.TbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitsinStockUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDelet = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxProductName.SuspendLayout();
			this.gbxProductAdd.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(12, 170);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.Size = new System.Drawing.Size(776, 278);
			this.dgwProduct.TabIndex = 0;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(12, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(776, 68);
			this.gbxCategory.TabIndex = 1;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Katagoriye göre ara";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(104, 25);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(179, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(52, 33);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(46, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Katagori";
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProduct);
			this.gbxProductName.Controls.Add(this.lblProduct);
			this.gbxProductName.Location = new System.Drawing.Point(12, 86);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Size = new System.Drawing.Size(776, 78);
			this.gbxProductName.TabIndex = 2;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Ürün adına göre ara";
			// 
			// tbxProduct
			// 
			this.tbxProduct.Location = new System.Drawing.Point(104, 28);
			this.tbxProduct.Name = "tbxProduct";
			this.tbxProduct.Size = new System.Drawing.Size(179, 20);
			this.tbxProduct.TabIndex = 2;
			this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(68, 35);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(30, 13);
			this.lblProduct.TabIndex = 1;
			this.lblProduct.Text = "Ürün";
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.tbxStock);
			this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
			this.gbxProductAdd.Controls.Add(this.lblStok);
			this.gbxProductAdd.Controls.Add(this.tbxProductName);
			this.gbxProductAdd.Controls.Add(this.lblQuantityForLimit);
			this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
			this.gbxProductAdd.Controls.Add(this.label2);
			this.gbxProductAdd.Controls.Add(this.lblProductName);
			this.gbxProductAdd.Location = new System.Drawing.Point(12, 465);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(273, 254);
			this.gbxProductAdd.TabIndex = 3;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Yeni ürün ekle";
			// 
			// cbxCategoryId
			// 
			this.cbxCategoryId.FormattingEnabled = true;
			this.cbxCategoryId.Location = new System.Drawing.Point(73, 46);
			this.cbxCategoryId.Name = "cbxCategoryId";
			this.cbxCategoryId.Size = new System.Drawing.Size(135, 21);
			this.cbxCategoryId.TabIndex = 13;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(72, 162);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(137, 52);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbxQuantityPerUnit
			// 
			this.tbxQuantityPerUnit.Location = new System.Drawing.Point(72, 129);
			this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
			this.tbxQuantityPerUnit.Size = new System.Drawing.Size(136, 20);
			this.tbxQuantityPerUnit.TabIndex = 9;
			// 
			// tbxStock
			// 
			this.tbxStock.Location = new System.Drawing.Point(72, 99);
			this.tbxStock.Name = "tbxStock";
			this.tbxStock.Size = new System.Drawing.Size(136, 20);
			this.tbxStock.TabIndex = 8;
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(72, 73);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(136, 20);
			this.tbxUnitPrice.TabIndex = 7;
			// 
			// lblStok
			// 
			this.lblStok.AutoSize = true;
			this.lblStok.Location = new System.Drawing.Point(8, 106);
			this.lblStok.Name = "lblStok";
			this.lblStok.Size = new System.Drawing.Size(59, 13);
			this.lblStok.TabIndex = 5;
			this.lblStok.Text = "Stok Adedi";
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(72, 21);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(136, 20);
			this.tbxProductName.TabIndex = 4;
			this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
			// 
			// lblQuantityForLimit
			// 
			this.lblQuantityForLimit.AutoSize = true;
			this.lblQuantityForLimit.Location = new System.Drawing.Point(8, 136);
			this.lblQuantityForLimit.Name = "lblQuantityForLimit";
			this.lblQuantityForLimit.Size = new System.Drawing.Size(58, 13);
			this.lblQuantityForLimit.TabIndex = 3;
			this.lblQuantityForLimit.Text = "Birim adedi";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(37, 80);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "Fiyat";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "kategori";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(18, 28);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(48, 13);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Ürün Adı";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbxProductNameUpdate);
			this.groupBox1.Controls.Add(this.cbxCategoryIdUpdate);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.TbxQuantityPerUnitUpdate);
			this.groupBox1.Controls.Add(this.tbxUnitsinStockUpdate);
			this.groupBox1.Controls.Add(this.tbxUnitPriceUpdate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(291, 465);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 254);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün güncelle";
			// 
			// tbxProductNameUpdate
			// 
			this.tbxProductNameUpdate.Location = new System.Drawing.Point(67, 23);
			this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
			this.tbxProductNameUpdate.Size = new System.Drawing.Size(136, 20);
			this.tbxProductNameUpdate.TabIndex = 15;
			// 
			// cbxCategoryIdUpdate
			// 
			this.cbxCategoryIdUpdate.FormattingEnabled = true;
			this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(68, 49);
			this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
			this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(135, 21);
			this.cbxCategoryIdUpdate.TabIndex = 13;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(67, 162);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(136, 56);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// TbxQuantityPerUnitUpdate
			// 
			this.TbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(67, 132);
			this.TbxQuantityPerUnitUpdate.Name = "TbxQuantityPerUnitUpdate";
			this.TbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(136, 20);
			this.TbxQuantityPerUnitUpdate.TabIndex = 9;
			// 
			// tbxUnitsinStockUpdate
			// 
			this.tbxUnitsinStockUpdate.Location = new System.Drawing.Point(67, 102);
			this.tbxUnitsinStockUpdate.Name = "tbxUnitsinStockUpdate";
			this.tbxUnitsinStockUpdate.Size = new System.Drawing.Size(136, 20);
			this.tbxUnitsinStockUpdate.TabIndex = 8;
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(67, 76);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(136, 20);
			this.tbxUnitPriceUpdate.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Stok Adedi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Birim adedi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Fiyat";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "kategori";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ürün Adı";
			// 
			// btnDelet
			// 
			this.btnDelet.Location = new System.Drawing.Point(49, 23);
			this.btnDelet.Name = "btnDelet";
			this.btnDelet.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDelet.Size = new System.Drawing.Size(136, 56);
			this.btnDelet.TabIndex = 5;
			this.btnDelet.Text = "Sil";
			this.btnDelet.UseVisualStyleBackColor = true;
			this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDelet);
			this.groupBox2.Location = new System.Drawing.Point(575, 465);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(213, 96);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ürün Sil";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 748);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Ürünler";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblQuantityForLimit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox TbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsinStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelet;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

