namespace Lab1Sept27th2022ver1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radioBtnTax = new System.Windows.Forms.RadioButton();
            this.radioBtnNoTax = new System.Windows.Forms.RadioButton();
            this.labelWithoutTaxes = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelWithTaxes = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPrdNameIDInput = new System.Windows.Forms.Label();
            this.labelPriceInput = new System.Windows.Forms.Label();
            this.labelQuantityInput = new System.Windows.Forms.Label();
            this.txtBoxNameID = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelCategoryInput = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.txSearchtBox = new System.Windows.Forms.TextBox();
            this.DGV_data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.textBoxxTotal = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.Label();
            this.textBoxxTaxRate = new System.Windows.Forms.TextBox();
            this.textBoxxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxxPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.textBoxxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(179, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Lime;
            this.btnEdit.Location = new System.Drawing.Point(260, 222);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(7, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(179, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radioBtnTax
            // 
            this.radioBtnTax.AutoSize = true;
            this.radioBtnTax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnTax.Location = new System.Drawing.Point(18, 375);
            this.radioBtnTax.Name = "radioBtnTax";
            this.radioBtnTax.Size = new System.Drawing.Size(14, 13);
            this.radioBtnTax.TabIndex = 4;
            this.radioBtnTax.TabStop = true;
            this.radioBtnTax.UseVisualStyleBackColor = false;
            // 
            // radioBtnNoTax
            // 
            this.radioBtnNoTax.AutoSize = true;
            this.radioBtnNoTax.Location = new System.Drawing.Point(18, 394);
            this.radioBtnNoTax.Name = "radioBtnNoTax";
            this.radioBtnNoTax.Size = new System.Drawing.Size(14, 13);
            this.radioBtnNoTax.TabIndex = 5;
            this.radioBtnNoTax.TabStop = true;
            this.radioBtnNoTax.UseVisualStyleBackColor = true;
            // 
            // labelWithoutTaxes
            // 
            this.labelWithoutTaxes.AutoSize = true;
            this.labelWithoutTaxes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelWithoutTaxes.Location = new System.Drawing.Point(38, 399);
            this.labelWithoutTaxes.Name = "labelWithoutTaxes";
            this.labelWithoutTaxes.Size = new System.Drawing.Size(76, 13);
            this.labelWithoutTaxes.TabIndex = 7;
            this.labelWithoutTaxes.Text = "Without Taxes";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.priceHeader,
            this.quantityHeader,
            this.categoryHeader});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(9, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(346, 151);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Product Name";
            this.nameHeader.Width = 84;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 43;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 57;
            // 
            // categoryHeader
            // 
            this.categoryHeader.Text = "Category";
            this.categoryHeader.Width = 75;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(368, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(409, 328);
            this.dataGridView.TabIndex = 16;
            // 
            // labelWithTaxes
            // 
            this.labelWithTaxes.AutoSize = true;
            this.labelWithTaxes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelWithTaxes.Location = new System.Drawing.Point(38, 375);
            this.labelWithTaxes.Name = "labelWithTaxes";
            this.labelWithTaxes.Size = new System.Drawing.Size(61, 13);
            this.labelWithTaxes.TabIndex = 17;
            this.labelWithTaxes.Text = "With Taxes";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Location = new System.Drawing.Point(260, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPrdNameIDInput
            // 
            this.labelPrdNameIDInput.AutoSize = true;
            this.labelPrdNameIDInput.Location = new System.Drawing.Point(17, 213);
            this.labelPrdNameIDInput.Name = "labelPrdNameIDInput";
            this.labelPrdNameIDInput.Size = new System.Drawing.Size(34, 13);
            this.labelPrdNameIDInput.TabIndex = 20;
            this.labelPrdNameIDInput.Text = "PrdID";
            // 
            // labelPriceInput
            // 
            this.labelPriceInput.AutoSize = true;
            this.labelPriceInput.Location = new System.Drawing.Point(17, 248);
            this.labelPriceInput.Name = "labelPriceInput";
            this.labelPriceInput.Size = new System.Drawing.Size(31, 13);
            this.labelPriceInput.TabIndex = 21;
            this.labelPriceInput.Text = "Price";
            // 
            // labelQuantityInput
            // 
            this.labelQuantityInput.AutoSize = true;
            this.labelQuantityInput.Location = new System.Drawing.Point(15, 271);
            this.labelQuantityInput.Name = "labelQuantityInput";
            this.labelQuantityInput.Size = new System.Drawing.Size(46, 13);
            this.labelQuantityInput.TabIndex = 22;
            this.labelQuantityInput.Text = "Quantity";
            // 
            // txtBoxNameID
            // 
            this.txtBoxNameID.Location = new System.Drawing.Point(73, 210);
            this.txtBoxNameID.Name = "txtBoxNameID";
            this.txtBoxNameID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNameID.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(73, 245);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(73, 271);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // labelCategoryInput
            // 
            this.labelCategoryInput.AutoSize = true;
            this.labelCategoryInput.Location = new System.Drawing.Point(12, 297);
            this.labelCategoryInput.Name = "labelCategoryInput";
            this.labelCategoryInput.Size = new System.Drawing.Size(49, 13);
            this.labelCategoryInput.TabIndex = 26;
            this.labelCategoryInput.Text = "Category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(73, 297);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 4;
            // 
            // txSearchtBox
            // 
            this.txSearchtBox.Location = new System.Drawing.Point(88, 169);
            this.txSearchtBox.Name = "txSearchtBox";
            this.txSearchtBox.Size = new System.Drawing.Size(251, 20);
            this.txSearchtBox.TabIndex = 28;
            this.txSearchtBox.TextChanged += new System.EventHandler(this.txSearchtBox_TextChanged);
            // 
            // DGV_data
            // 
            this.DGV_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Price,
            this.Quantity,
            this.TaxRate,
            this.Total});
            this.DGV_data.Location = new System.Drawing.Point(368, 350);
            this.DGV_data.Name = "DGV_data";
            this.DGV_data.Size = new System.Drawing.Size(409, 76);
            this.DGV_data.TabIndex = 29;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // TaxRate
            // 
            this.TaxRate.HeaderText = "TaxRate";
            this.TaxRate.Name = "TaxRate";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(9, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "GetAmount";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(12, 425);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(42, 13);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.Text = "TOTAL";
            // 
            // textBoxxTotal
            // 
            this.textBoxxTotal.Location = new System.Drawing.Point(60, 422);
            this.textBoxxTotal.Name = "textBoxxTotal";
            this.textBoxxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxxTotal.TabIndex = 9;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.AutoSize = true;
            this.txtTaxRate.Location = new System.Drawing.Point(170, 406);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(48, 13);
            this.txtTaxRate.TabIndex = 33;
            this.txtTaxRate.Text = "TaxRate";
            // 
            // textBoxxTaxRate
            // 
            this.textBoxxTaxRate.Location = new System.Drawing.Point(239, 399);
            this.textBoxxTaxRate.Name = "textBoxxTaxRate";
            this.textBoxxTaxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxxTaxRate.TabIndex = 8;
            // 
            // textBoxxQuantity
            // 
            this.textBoxxQuantity.Location = new System.Drawing.Point(239, 372);
            this.textBoxxQuantity.Name = "textBoxxQuantity";
            this.textBoxxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxxQuantity.TabIndex = 7;
            // 
            // textBoxxPrice
            // 
            this.textBoxxPrice.Location = new System.Drawing.Point(235, 346);
            this.textBoxxPrice.Name = "textBoxxPrice";
            this.textBoxxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxxPrice.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(181, 350);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(30, 13);
            this.txtPrice.TabIndex = 37;
            this.txtPrice.Text = "price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Location = new System.Drawing.Point(176, 375);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(44, 13);
            this.txtQuantity.TabIndex = 38;
            this.txtQuantity.Text = "quantity";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(193, 323);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 39;
            this.txtID.Text = "ID";
            // 
            // textBoxxID
            // 
            this.textBoxxID.Location = new System.Drawing.Point(235, 320);
            this.textBoxxID.Name = "textBoxxID";
            this.textBoxxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxxID.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxxID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.textBoxxPrice);
            this.Controls.Add(this.textBoxxQuantity);
            this.Controls.Add(this.textBoxxTaxRate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.textBoxxTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_data);
            this.Controls.Add(this.txSearchtBox);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelCategoryInput);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.txtBoxNameID);
            this.Controls.Add(this.labelQuantityInput);
            this.Controls.Add(this.labelPriceInput);
            this.Controls.Add(this.labelPrdNameIDInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelWithTaxes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelWithoutTaxes);
            this.Controls.Add(this.radioBtnNoTax);
            this.Controls.Add(this.radioBtnTax);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioBtnTax;
        private System.Windows.Forms.RadioButton radioBtnNoTax;
        private System.Windows.Forms.Label labelWithoutTaxes;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader quantityHeader;
        private System.Windows.Forms.ColumnHeader categoryHeader;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelWithTaxes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelPrdNameIDInput;
        private System.Windows.Forms.Label labelPriceInput;
        private System.Windows.Forms.Label labelQuantityInput;
        private System.Windows.Forms.TextBox txtBoxNameID;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelCategoryInput;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox txSearchtBox;
        private System.Windows.Forms.DataGridView DGV_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.TextBox textBoxxTotal;
        private System.Windows.Forms.Label txtTaxRate;
        private System.Windows.Forms.TextBox textBoxxTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxRate;
        private System.Windows.Forms.TextBox textBoxxQuantity;
        private System.Windows.Forms.TextBox textBoxxPrice;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox textBoxxID;
    }
}

