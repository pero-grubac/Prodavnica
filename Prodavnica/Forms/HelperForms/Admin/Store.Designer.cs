﻿namespace Prodavnica.Forms.HelperForms.Admin
{
    partial class StoreTable
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tcShop = new TabControl();
            tpProducts = new TabPage();
            tlpProducts = new TableLayoutPanel();
            dgvProducts = new DataGridView();
            BarCode = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Supplies = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            ManufacturerName = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            gbProducts = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            tbProcurement = new TabPage();
            tlpProcurement = new TableLayoutPanel();
            tlpBill = new TableLayoutPanel();
            gbBuy = new GroupBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnBuy = new Button();
            dgvBill = new DataGridView();
            productNameColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            IdProduct = new DataGridViewTextBoxColumn();
            procurementItemBindingSource = new BindingSource(components);
            btnDeleteItem = new Button();
            tlypSelect = new TableLayoutPanel();
            gbSearch = new GroupBox();
            txtSearchBarCode = new TextBox();
            lblSearchProduct = new Label();
            gbAdd = new GroupBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtPrice = new TextBox();
            btnAddToCart = new Button();
            lblPrice = new Label();
            dgvProductsBill = new DataGridView();
            barCodeColumn = new DataGridViewTextBoxColumn();
            nameColumnBill = new DataGridViewTextBoxColumn();
            gbSupplier = new GroupBox();
            cbSupplier = new ComboBox();
            lblSupplier = new Label();
            tbBills = new TabPage();
            tlpBills = new TableLayoutPanel();
            tlpDate = new TableLayoutPanel();
            gbDateTo = new GroupBox();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            gbDateFrom = new GroupBox();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            dgvBills = new DataGridView();
            procurementBindingSource1 = new BindingSource(components);
            procurementBindingSource = new BindingSource(components);
            billBindingSource = new BindingSource(components);
            IdBill = new DataGridViewTextBoxColumn();
            productBIllBindingSource = new BindingSource(components);
            billItemBindingSource = new BindingSource(components);
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            tcShop.SuspendLayout();
            tpProducts.SuspendLayout();
            tlpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            gbProducts.SuspendLayout();
            tbProcurement.SuspendLayout();
            tlpProcurement.SuspendLayout();
            tlpBill.SuspendLayout();
            gbBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procurementItemBindingSource).BeginInit();
            tlypSelect.SuspendLayout();
            gbSearch.SuspendLayout();
            gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductsBill).BeginInit();
            gbSupplier.SuspendLayout();
            tbBills.SuspendLayout();
            tlpBills.SuspendLayout();
            tlpDate.SuspendLayout();
            gbDateTo.SuspendLayout();
            gbDateFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procurementBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procurementBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBIllBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tcShop
            // 
            tcShop.Controls.Add(tpProducts);
            tcShop.Controls.Add(tbProcurement);
            tcShop.Controls.Add(tbBills);
            tcShop.Dock = DockStyle.Fill;
            tcShop.Location = new Point(0, 0);
            tcShop.Name = "tcShop";
            tcShop.SelectedIndex = 0;
            tcShop.Size = new Size(952, 509);
            tcShop.TabIndex = 0;
            tcShop.SelectedIndexChanged += tcShop_SelectedIndexChanged;
            // 
            // tpProducts
            // 
            tpProducts.Controls.Add(tlpProducts);
            tpProducts.Location = new Point(4, 29);
            tpProducts.Name = "tpProducts";
            tpProducts.Padding = new Padding(3);
            tpProducts.Size = new Size(944, 476);
            tpProducts.TabIndex = 2;
            tpProducts.Text = "Products";
            tpProducts.UseVisualStyleBackColor = true;
            // 
            // tlpProducts
            // 
            tlpProducts.ColumnCount = 1;
            tlpProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpProducts.Controls.Add(dgvProducts, 0, 1);
            tlpProducts.Controls.Add(gbProducts, 0, 0);
            tlpProducts.Dock = DockStyle.Fill;
            tlpProducts.Location = new Point(3, 3);
            tlpProducts.Name = "tlpProducts";
            tlpProducts.RowCount = 2;
            tlpProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpProducts.RowStyles.Add(new RowStyle());
            tlpProducts.Size = new Size(938, 470);
            tlpProducts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { BarCode, NameColumn, Price, Supplies, ExpirationDate, Description, CategoryName, ManufacturerName });
            dgvProducts.DataSource = productsBindingSource;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 78);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(932, 885);
            dgvProducts.TabIndex = 0;
            dgvProducts.RowHeaderMouseClick += dgvProducts_RowHeaderMouseClick;
            // 
            // BarCode
            // 
            BarCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BarCode.DataPropertyName = "BarCode";
            BarCode.HeaderText = "BarCode";
            BarCode.MinimumWidth = 6;
            BarCode.Name = "BarCode";
            BarCode.ReadOnly = true;
            BarCode.Width = 125;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 125;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 70;
            // 
            // Supplies
            // 
            Supplies.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Supplies.DataPropertyName = "Supplies";
            Supplies.HeaderText = "Supplies";
            Supplies.MinimumWidth = 6;
            Supplies.Name = "Supplies";
            Supplies.ReadOnly = true;
            Supplies.Resizable = DataGridViewTriState.True;
            Supplies.Width = 94;
            // 
            // ExpirationDate
            // 
            ExpirationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExpirationDate.DataPropertyName = "ExpirationDate";
            ExpirationDate.HeaderText = "ExpirationDate";
            ExpirationDate.MinimumWidth = 6;
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.ReadOnly = true;
            ExpirationDate.Width = 175;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 114;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 125;
            // 
            // ManufacturerName
            // 
            ManufacturerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ManufacturerName.DataPropertyName = "ManufacturerName";
            ManufacturerName.HeaderText = "Manufacturer";
            ManufacturerName.MinimumWidth = 6;
            ManufacturerName.Name = "ManufacturerName";
            ManufacturerName.ReadOnly = true;
            ManufacturerName.Width = 125;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Database.DTO.Product);
            // 
            // gbProducts
            // 
            gbProducts.AutoSize = true;
            gbProducts.BackColor = Color.White;
            gbProducts.Controls.Add(txtSearch);
            gbProducts.Controls.Add(lblSearch);
            gbProducts.Controls.Add(btnDelete);
            gbProducts.Controls.Add(btnUpdate);
            gbProducts.Controls.Add(btnAdd);
            gbProducts.Dock = DockStyle.Fill;
            gbProducts.ForeColor = Color.Black;
            gbProducts.Location = new Point(3, 3);
            gbProducts.Name = "gbProducts";
            gbProducts.Size = new Size(932, 69);
            gbProducts.TabIndex = 1;
            gbProducts.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = SystemColors.WindowText;
            txtSearch.Location = new Point(356, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 27);
            txtSearch.TabIndex = 4;
            txtSearch.KeyPress += txtSeatch_KeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(281, 31);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(206, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Location = new Point(106, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Location = new Point(6, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbProcurement
            // 
            tbProcurement.Controls.Add(tlpProcurement);
            tbProcurement.Location = new Point(4, 29);
            tbProcurement.Name = "tbProcurement";
            tbProcurement.Padding = new Padding(3);
            tbProcurement.Size = new Size(944, 476);
            tbProcurement.TabIndex = 1;
            tbProcurement.Text = "Procurement";
            tbProcurement.UseVisualStyleBackColor = true;
            // 
            // tlpProcurement
            // 
            tlpProcurement.ColumnCount = 2;
            tlpProcurement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProcurement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProcurement.Controls.Add(tlpBill, 1, 0);
            tlpProcurement.Controls.Add(tlypSelect, 0, 0);
            tlpProcurement.Dock = DockStyle.Fill;
            tlpProcurement.Location = new Point(3, 3);
            tlpProcurement.Name = "tlpProcurement";
            tlpProcurement.RowCount = 1;
            tlpProcurement.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpProcurement.Size = new Size(938, 470);
            tlpProcurement.TabIndex = 0;
            // 
            // tlpBill
            // 
            tlpBill.ColumnCount = 1;
            tlpBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBill.Controls.Add(gbBuy, 0, 2);
            tlpBill.Controls.Add(dgvBill, 0, 0);
            tlpBill.Controls.Add(btnDeleteItem, 0, 1);
            tlpBill.Dock = DockStyle.Fill;
            tlpBill.Location = new Point(472, 3);
            tlpBill.Name = "tlpBill";
            tlpBill.RowCount = 3;
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpBill.Size = new Size(463, 464);
            tlpBill.TabIndex = 0;
            // 
            // gbBuy
            // 
            gbBuy.BackColor = Color.White;
            gbBuy.Controls.Add(txtTotal);
            gbBuy.Controls.Add(lblTotal);
            gbBuy.Controls.Add(btnBuy);
            gbBuy.Dock = DockStyle.Fill;
            gbBuy.Location = new Point(3, 317);
            gbBuy.Name = "gbBuy";
            gbBuy.Size = new Size(457, 144);
            gbBuy.TabIndex = 0;
            gbBuy.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(102, 59);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(340, 27);
            txtTotal.TabIndex = 7;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 62);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnBuy
            // 
            btnBuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuy.Location = new Point(338, 106);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 32);
            btnBuy.TabIndex = 4;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToResizeRows = false;
            dgvBill.AutoGenerateColumns = false;
            dgvBill.BackgroundColor = Color.White;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { productNameColumn, amountColumn, priceColumn, IdProduct });
            dgvBill.DataSource = procurementItemBindingSource;
            dgvBill.Dock = DockStyle.Fill;
            dgvBill.Location = new Point(3, 3);
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(457, 233);
            dgvBill.TabIndex = 1;
            // 
            // productNameColumn
            // 
            productNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameColumn.DataPropertyName = "Name";
            productNameColumn.HeaderText = "Name";
            productNameColumn.MinimumWidth = 6;
            productNameColumn.Name = "productNameColumn";
            productNameColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.MinimumWidth = 6;
            amountColumn.Name = "amountColumn";
            amountColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceColumn.DataPropertyName = "Price";
            priceColumn.HeaderText = "Price";
            priceColumn.MinimumWidth = 6;
            priceColumn.Name = "priceColumn";
            priceColumn.ReadOnly = true;
            // 
            // IdProduct
            // 
            IdProduct.DataPropertyName = "IdProduct";
            IdProduct.HeaderText = "IdProduct";
            IdProduct.MinimumWidth = 6;
            IdProduct.Name = "IdProduct";
            IdProduct.ReadOnly = true;
            IdProduct.Visible = false;
            IdProduct.Width = 125;
            // 
            // procurementItemBindingSource
            // 
            procurementItemBindingSource.DataSource = typeof(Database.DTO.ProcurementItem);
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.White;
            btnDeleteItem.Dock = DockStyle.Fill;
            btnDeleteItem.Location = new Point(3, 242);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(457, 69);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "Delete item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // tlypSelect
            // 
            tlypSelect.ColumnCount = 1;
            tlypSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlypSelect.Controls.Add(gbSearch, 0, 1);
            tlypSelect.Controls.Add(gbAdd, 0, 3);
            tlypSelect.Controls.Add(dgvProductsBill, 0, 2);
            tlypSelect.Controls.Add(gbSupplier, 0, 0);
            tlypSelect.Dock = DockStyle.Fill;
            tlypSelect.Location = new Point(3, 3);
            tlypSelect.Name = "tlypSelect";
            tlypSelect.RowCount = 4;
            tlypSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlypSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlypSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlypSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tlypSelect.Size = new Size(463, 464);
            tlypSelect.TabIndex = 1;
            // 
            // gbSearch
            // 
            gbSearch.BackColor = Color.White;
            gbSearch.Controls.Add(txtSearchBarCode);
            gbSearch.Controls.Add(lblSearchProduct);
            gbSearch.Dock = DockStyle.Fill;
            gbSearch.Location = new Point(3, 78);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(457, 69);
            gbSearch.TabIndex = 0;
            gbSearch.TabStop = false;
            // 
            // txtSearchBarCode
            // 
            txtSearchBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBarCode.Location = new Point(102, 26);
            txtSearchBarCode.Name = "txtSearchBarCode";
            txtSearchBarCode.Size = new Size(340, 27);
            txtSearchBarCode.TabIndex = 1;
            txtSearchBarCode.KeyPress += txtSearchBarCode_KeyPress;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Location = new Point(6, 29);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(53, 20);
            lblSearchProduct.TabIndex = 0;
            lblSearchProduct.Text = "Search";
            // 
            // gbAdd
            // 
            gbAdd.BackColor = Color.White;
            gbAdd.Controls.Add(txtAmount);
            gbAdd.Controls.Add(lblAmount);
            gbAdd.Controls.Add(txtPrice);
            gbAdd.Controls.Add(btnAddToCart);
            gbAdd.Controls.Add(lblPrice);
            gbAdd.Dock = DockStyle.Fill;
            gbAdd.Location = new Point(3, 292);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(457, 169);
            gbAdd.TabIndex = 1;
            gbAdd.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(102, 90);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(340, 27);
            txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(6, 93);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(102, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(340, 27);
            txtPrice.TabIndex = 3;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddToCart.Location = new Point(339, 131);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 32);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "Add";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // dgvProductsBill
            // 
            dgvProductsBill.AllowUserToAddRows = false;
            dgvProductsBill.AllowUserToDeleteRows = false;
            dgvProductsBill.AllowUserToResizeRows = false;
            dgvProductsBill.AutoGenerateColumns = false;
            dgvProductsBill.BackgroundColor = Color.White;
            dgvProductsBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsBill.Columns.AddRange(new DataGridViewColumn[] { barCodeColumn, nameColumnBill });
            dgvProductsBill.DataSource = productsBindingSource;
            dgvProductsBill.Dock = DockStyle.Fill;
            dgvProductsBill.Location = new Point(3, 153);
            dgvProductsBill.Name = "dgvProductsBill";
            dgvProductsBill.ReadOnly = true;
            dgvProductsBill.RowHeadersVisible = false;
            dgvProductsBill.RowHeadersWidth = 51;
            dgvProductsBill.RowTemplate.Height = 29;
            dgvProductsBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductsBill.Size = new Size(457, 133);
            dgvProductsBill.TabIndex = 2;
            // 
            // barCodeColumn
            // 
            barCodeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            barCodeColumn.DataPropertyName = "BarCode";
            barCodeColumn.HeaderText = "BarCode";
            barCodeColumn.MinimumWidth = 6;
            barCodeColumn.Name = "barCodeColumn";
            barCodeColumn.ReadOnly = true;
            barCodeColumn.Width = 150;
            // 
            // nameColumnBill
            // 
            nameColumnBill.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameColumnBill.DataPropertyName = "Name";
            nameColumnBill.HeaderText = "Name";
            nameColumnBill.MinimumWidth = 6;
            nameColumnBill.Name = "nameColumnBill";
            nameColumnBill.ReadOnly = true;
            // 
            // gbSupplier
            // 
            gbSupplier.BackColor = Color.White;
            gbSupplier.Controls.Add(cbSupplier);
            gbSupplier.Controls.Add(lblSupplier);
            gbSupplier.Dock = DockStyle.Fill;
            gbSupplier.Location = new Point(3, 3);
            gbSupplier.Name = "gbSupplier";
            gbSupplier.Size = new Size(457, 69);
            gbSupplier.TabIndex = 3;
            gbSupplier.TabStop = false;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(102, 21);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(340, 28);
            cbSupplier.TabIndex = 5;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(6, 29);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 20);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Supplier";
            // 
            // tbBills
            // 
            tbBills.Controls.Add(tlpBills);
            tbBills.Location = new Point(4, 29);
            tbBills.Name = "tbBills";
            tbBills.Padding = new Padding(3);
            tbBills.Size = new Size(944, 476);
            tbBills.TabIndex = 3;
            tbBills.Text = "Bills";
            tbBills.UseVisualStyleBackColor = true;
            // 
            // tlpBills
            // 
            tlpBills.ColumnCount = 1;
            tlpBills.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBills.Controls.Add(tlpDate, 0, 0);
            tlpBills.Controls.Add(dgvBills, 0, 1);
            tlpBills.Dock = DockStyle.Fill;
            tlpBills.Location = new Point(3, 3);
            tlpBills.Name = "tlpBills";
            tlpBills.RowCount = 2;
            tlpBills.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpBills.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBills.Size = new Size(938, 470);
            tlpBills.TabIndex = 0;
            // 
            // tlpDate
            // 
            tlpDate.ColumnCount = 2;
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDate.Controls.Add(gbDateTo, 1, 0);
            tlpDate.Controls.Add(gbDateFrom, 0, 0);
            tlpDate.Dock = DockStyle.Fill;
            tlpDate.Location = new Point(3, 3);
            tlpDate.Name = "tlpDate";
            tlpDate.RowCount = 1;
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDate.Size = new Size(932, 69);
            tlpDate.TabIndex = 1;
            // 
            // gbDateTo
            // 
            gbDateTo.BackColor = Color.White;
            gbDateTo.Controls.Add(dtpTo);
            gbDateTo.Controls.Add(lblTo);
            gbDateTo.Dock = DockStyle.Fill;
            gbDateTo.Location = new Point(469, 3);
            gbDateTo.Name = "gbDateTo";
            gbDateTo.Size = new Size(460, 63);
            gbDateTo.TabIndex = 1;
            gbDateTo.TabStop = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(85, 18);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(369, 27);
            dtpTo.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(6, 23);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // gbDateFrom
            // 
            gbDateFrom.BackColor = Color.White;
            gbDateFrom.Controls.Add(dtpFrom);
            gbDateFrom.Controls.Add(lblFrom);
            gbDateFrom.Dock = DockStyle.Fill;
            gbDateFrom.Location = new Point(3, 3);
            gbDateFrom.Name = "gbDateFrom";
            gbDateFrom.Size = new Size(460, 63);
            gbDateFrom.TabIndex = 0;
            gbDateFrom.TabStop = false;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(85, 18);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(369, 27);
            dtpFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(6, 23);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(43, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.AllowUserToResizeRows = false;
            dgvBills.AutoGenerateColumns = false;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] { supplierNameDataGridViewTextBoxColumn, Id, date, total });
            dgvBills.DataSource = procurementBindingSource1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBills.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.Dock = DockStyle.Fill;
            dgvBills.Location = new Point(3, 78);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 51;
            dgvBills.RowTemplate.Height = 29;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(932, 389);
            dgvBills.TabIndex = 2;
            dgvBills.CellDoubleClick += dgvBills_CellDoubleClick;
            // 
            // procurementBindingSource1
            // 
            procurementBindingSource1.DataSource = typeof(Database.DTO.Procurement);
            // 
            // procurementBindingSource
            // 
            procurementBindingSource.DataSource = typeof(Database.DTO.Procurement);
            // 
            // billBindingSource
            // 
            billBindingSource.DataSource = typeof(Database.DTO.Bill);
            // 
            // IdBill
            // 
            IdBill.DataPropertyName = "IdBill";
            IdBill.HeaderText = "IdProduct";
            IdBill.MinimumWidth = 6;
            IdBill.Name = "IdBill";
            IdBill.ReadOnly = true;
            IdBill.Visible = false;
            IdBill.Width = 125;
            // 
            // billItemBindingSource
            // 
            billItemBindingSource.DataSource = typeof(Database.DTO.BillItem);
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.DataPropertyName = "Date";
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.DataPropertyName = "Total";
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // StoreTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 509);
            Controls.Add(tcShop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreTable";
            Text = "Store";
            tcShop.ResumeLayout(false);
            tpProducts.ResumeLayout(false);
            tlpProducts.ResumeLayout(false);
            tlpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            gbProducts.ResumeLayout(false);
            gbProducts.PerformLayout();
            tbProcurement.ResumeLayout(false);
            tlpProcurement.ResumeLayout(false);
            tlpBill.ResumeLayout(false);
            gbBuy.ResumeLayout(false);
            gbBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)procurementItemBindingSource).EndInit();
            tlypSelect.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductsBill).EndInit();
            gbSupplier.ResumeLayout(false);
            gbSupplier.PerformLayout();
            tbBills.ResumeLayout(false);
            tlpBills.ResumeLayout(false);
            tlpDate.ResumeLayout(false);
            gbDateTo.ResumeLayout(false);
            gbDateTo.PerformLayout();
            gbDateFrom.ResumeLayout(false);
            gbDateFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ((System.ComponentModel.ISupportInitialize)procurementBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)procurementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)billBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBIllBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)billItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcShop;
        private TabPage tbProcurement;
        private TabPage tpProducts;
        private DataGridView dgvProducts;
        private BindingSource productsBindingSource;
        private TableLayoutPanel tlpProducts;
        private GroupBox gbProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Supplies;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ManufacturerName;
        private TabPage tbBills;
        private TableLayoutPanel tlpProcurement;
        private TableLayoutPanel tlpBill;
        private TableLayoutPanel tlypSelect;
        private GroupBox gbBuy;
        private GroupBox gbSearch;
        private GroupBox gbAdd;
        private TextBox txtSearchBarCode;
        private Label lblSearchProduct;
        private Button btnAddToCart;
        private Button btnBuy;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtTotal;
        private Label lblTotal;
        private DataGridView dgvProductsBill;
        private DataGridView dgvBill;
        private BindingSource productBIllBindingSource;
        private Button btnDeleteItem;
        private DataGridViewTextBoxColumn barCodeColumn;
        private DataGridViewTextBoxColumn nameColumnBill;
        private GroupBox gbSupplier;
        private ComboBox cbSupplier;
        private Label lblSupplier;
        private TableLayoutPanel tlpBills;
        private TableLayoutPanel tlpDate;
        private GroupBox gbDateFrom;
        private GroupBox gbDateTo;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private Label lblFrom;
        private DataGridView dgvBills;
        private BindingSource procurementBindingSource;
        private BindingSource procurementItemBindingSource;
        private DataGridViewTextBoxColumn IdBill;
        private BindingSource billItemBindingSource;
        private DataGridViewTextBoxColumn productNameColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn IdProduct;
        private BindingSource billBindingSource;
        private BindingSource procurementBindingSource1;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn total;
    }
}