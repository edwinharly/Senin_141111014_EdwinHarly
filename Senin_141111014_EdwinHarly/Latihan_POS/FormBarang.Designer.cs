namespace Latihan_POS
{
    partial class FormBarang
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.productsTabControl = new FlatUI.FlatTabControl();
            this.addProductsPage = new System.Windows.Forms.TabPage();
            this.txtAddID = new FlatUI.FlatLabel();
            this.addAlertBox = new FlatUI.FlatAlertBox();
            this.btnAddCancel = new FlatUI.FlatButton();
            this.btnAddSave = new FlatUI.FlatButton();
            this.txtAddHrgJual = new FlatUI.FlatTextBox();
            this.txtAddHrgHPP = new FlatUI.FlatTextBox();
            this.txtAddJlhAwal = new FlatUI.FlatTextBox();
            this.txtAddNama = new FlatUI.FlatTextBox();
            this.txtAddKode = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.updateProductsPage = new System.Windows.Forms.TabPage();
            this.lastBtn = new FlatUI.FlatButton();
            this.nextBtn = new FlatUI.FlatButton();
            this.prevBtn = new FlatUI.FlatButton();
            this.firstBtn = new FlatUI.FlatButton();
            this.btnDelete = new FlatUI.FlatButton();
            this.txtUpdateID = new FlatUI.FlatLabel();
            this.btnCancelEdit = new FlatUI.FlatButton();
            this.btnUpdate = new FlatUI.FlatButton();
            this.txtUpdateHargaJual = new FlatUI.FlatTextBox();
            this.txtUpdateHargaHPP = new FlatUI.FlatTextBox();
            this.txtUpdateJlhAwal = new FlatUI.FlatTextBox();
            this.txtUpdateNama = new FlatUI.FlatTextBox();
            this.txtUpdateKode = new FlatUI.FlatTextBox();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.flatLabel9 = new FlatUI.FlatLabel();
            this.flatLabel10 = new FlatUI.FlatLabel();
            this.flatLabel11 = new FlatUI.FlatLabel();
            this.flatLabel12 = new FlatUI.FlatLabel();
            this.viewProductsPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatClose1 = new FlatUI.FlatClose();
            this.editAlertBox = new FlatUI.FlatAlertBox();
            this.formSkin1.SuspendLayout();
            this.productsTabControl.SuspendLayout();
            this.addProductsPage.SuspendLayout();
            this.updateProductsPage.SuspendLayout();
            this.viewProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.productsTabControl);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(813, 410);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.TabStop = false;
            this.formSkin1.Text = "Products - Point of Sale";
            // 
            // productsTabControl
            // 
            this.productsTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.productsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsTabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.productsTabControl.Controls.Add(this.addProductsPage);
            this.productsTabControl.Controls.Add(this.updateProductsPage);
            this.productsTabControl.Controls.Add(this.viewProductsPage);
            this.productsTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productsTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.productsTabControl.Location = new System.Drawing.Point(0, 44);
            this.productsTabControl.Name = "productsTabControl";
            this.productsTabControl.SelectedIndex = 0;
            this.productsTabControl.Size = new System.Drawing.Size(813, 366);
            this.productsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.productsTabControl.TabIndex = 2;
            this.productsTabControl.TabStop = false;
            // 
            // addProductsPage
            // 
            this.addProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.addProductsPage.Controls.Add(this.txtAddID);
            this.addProductsPage.Controls.Add(this.addAlertBox);
            this.addProductsPage.Controls.Add(this.btnAddCancel);
            this.addProductsPage.Controls.Add(this.btnAddSave);
            this.addProductsPage.Controls.Add(this.txtAddHrgJual);
            this.addProductsPage.Controls.Add(this.txtAddHrgHPP);
            this.addProductsPage.Controls.Add(this.txtAddJlhAwal);
            this.addProductsPage.Controls.Add(this.txtAddNama);
            this.addProductsPage.Controls.Add(this.txtAddKode);
            this.addProductsPage.Controls.Add(this.flatLabel6);
            this.addProductsPage.Controls.Add(this.flatLabel5);
            this.addProductsPage.Controls.Add(this.flatLabel4);
            this.addProductsPage.Controls.Add(this.flatLabel3);
            this.addProductsPage.Controls.Add(this.flatLabel2);
            this.addProductsPage.Controls.Add(this.flatLabel1);
            this.addProductsPage.Location = new System.Drawing.Point(4, 44);
            this.addProductsPage.Name = "addProductsPage";
            this.addProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.addProductsPage.Size = new System.Drawing.Size(805, 318);
            this.addProductsPage.TabIndex = 6;
            this.addProductsPage.Text = "New";
            // 
            // txtAddID
            // 
            this.txtAddID.AutoSize = true;
            this.txtAddID.BackColor = System.Drawing.Color.Transparent;
            this.txtAddID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddID.ForeColor = System.Drawing.Color.White;
            this.txtAddID.Location = new System.Drawing.Point(222, 37);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(51, 17);
            this.txtAddID.TabIndex = 15;
            this.txtAddID.Text = "rndmID";
            // 
            // addAlertBox
            // 
            this.addAlertBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.addAlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addAlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.addAlertBox.Location = new System.Drawing.Point(83, 255);
            this.addAlertBox.Name = "addAlertBox";
            this.addAlertBox.Size = new System.Drawing.Size(624, 42);
            this.addAlertBox.TabIndex = 14;
            this.addAlertBox.Text = "The data has been successfully added.";
            this.addAlertBox.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAddCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddCancel.Location = new System.Drawing.Point(601, 206);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Rounded = false;
            this.btnAddCancel.Size = new System.Drawing.Size(106, 32);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAddCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSave.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAddSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddSave.Location = new System.Drawing.Point(601, 168);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Rounded = false;
            this.btnAddSave.Size = new System.Drawing.Size(106, 32);
            this.btnAddSave.TabIndex = 6;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAddSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddHrgJual
            // 
            this.txtAddHrgJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddHrgJual.BackColor = System.Drawing.Color.Transparent;
            this.txtAddHrgJual.FocusOnHover = false;
            this.txtAddHrgJual.Location = new System.Drawing.Point(225, 209);
            this.txtAddHrgJual.MaxLength = 15;
            this.txtAddHrgJual.Multiline = false;
            this.txtAddHrgJual.Name = "txtAddHrgJual";
            this.txtAddHrgJual.ReadOnly = false;
            this.txtAddHrgJual.Size = new System.Drawing.Size(350, 29);
            this.txtAddHrgJual.TabIndex = 5;
            this.txtAddHrgJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddHrgJual.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddHrgJual.UseSystemPasswordChar = false;
            // 
            // txtAddHrgHPP
            // 
            this.txtAddHrgHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddHrgHPP.BackColor = System.Drawing.Color.Transparent;
            this.txtAddHrgHPP.FocusOnHover = false;
            this.txtAddHrgHPP.Location = new System.Drawing.Point(225, 174);
            this.txtAddHrgHPP.MaxLength = 15;
            this.txtAddHrgHPP.Multiline = false;
            this.txtAddHrgHPP.Name = "txtAddHrgHPP";
            this.txtAddHrgHPP.ReadOnly = false;
            this.txtAddHrgHPP.Size = new System.Drawing.Size(350, 29);
            this.txtAddHrgHPP.TabIndex = 4;
            this.txtAddHrgHPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddHrgHPP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddHrgHPP.UseSystemPasswordChar = false;
            // 
            // txtAddJlhAwal
            // 
            this.txtAddJlhAwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddJlhAwal.BackColor = System.Drawing.Color.Transparent;
            this.txtAddJlhAwal.FocusOnHover = false;
            this.txtAddJlhAwal.Location = new System.Drawing.Point(225, 139);
            this.txtAddJlhAwal.MaxLength = 4;
            this.txtAddJlhAwal.Multiline = false;
            this.txtAddJlhAwal.Name = "txtAddJlhAwal";
            this.txtAddJlhAwal.ReadOnly = false;
            this.txtAddJlhAwal.Size = new System.Drawing.Size(350, 29);
            this.txtAddJlhAwal.TabIndex = 3;
            this.txtAddJlhAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddJlhAwal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddJlhAwal.UseSystemPasswordChar = false;
            // 
            // txtAddNama
            // 
            this.txtAddNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddNama.BackColor = System.Drawing.Color.Transparent;
            this.txtAddNama.FocusOnHover = false;
            this.txtAddNama.Location = new System.Drawing.Point(225, 104);
            this.txtAddNama.MaxLength = 50;
            this.txtAddNama.Multiline = false;
            this.txtAddNama.Name = "txtAddNama";
            this.txtAddNama.ReadOnly = false;
            this.txtAddNama.Size = new System.Drawing.Size(350, 29);
            this.txtAddNama.TabIndex = 2;
            this.txtAddNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddNama.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddNama.UseSystemPasswordChar = false;
            // 
            // txtAddKode
            // 
            this.txtAddKode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddKode.BackColor = System.Drawing.Color.Transparent;
            this.txtAddKode.FocusOnHover = false;
            this.txtAddKode.Location = new System.Drawing.Point(225, 69);
            this.txtAddKode.MaxLength = 10;
            this.txtAddKode.Multiline = false;
            this.txtAddKode.Name = "txtAddKode";
            this.txtAddKode.ReadOnly = false;
            this.txtAddKode.Size = new System.Drawing.Size(134, 29);
            this.txtAddKode.TabIndex = 1;
            this.txtAddKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddKode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddKode.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(80, 212);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(36, 17);
            this.flatLabel6.TabIndex = 13;
            this.flatLabel6.Text = "Price";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(80, 177);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(123, 17);
            this.flatLabel5.TabIndex = 12;
            this.flatLabel5.Text = "Cost of Goods Sold";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(80, 142);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(56, 17);
            this.flatLabel4.TabIndex = 11;
            this.flatLabel4.Text = "Quantity";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(80, 107);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(43, 17);
            this.flatLabel3.TabIndex = 10;
            this.flatLabel3.Text = "Name";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(80, 72);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(104, 17);
            this.flatLabel2.TabIndex = 9;
            this.flatLabel2.Text = "Code of Product";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(80, 37);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(20, 17);
            this.flatLabel1.TabIndex = 8;
            this.flatLabel1.Text = "ID";
            // 
            // updateProductsPage
            // 
            this.updateProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.updateProductsPage.Controls.Add(this.editAlertBox);
            this.updateProductsPage.Controls.Add(this.lastBtn);
            this.updateProductsPage.Controls.Add(this.nextBtn);
            this.updateProductsPage.Controls.Add(this.prevBtn);
            this.updateProductsPage.Controls.Add(this.firstBtn);
            this.updateProductsPage.Controls.Add(this.btnDelete);
            this.updateProductsPage.Controls.Add(this.txtUpdateID);
            this.updateProductsPage.Controls.Add(this.btnCancelEdit);
            this.updateProductsPage.Controls.Add(this.btnUpdate);
            this.updateProductsPage.Controls.Add(this.txtUpdateHargaJual);
            this.updateProductsPage.Controls.Add(this.txtUpdateHargaHPP);
            this.updateProductsPage.Controls.Add(this.txtUpdateJlhAwal);
            this.updateProductsPage.Controls.Add(this.txtUpdateNama);
            this.updateProductsPage.Controls.Add(this.txtUpdateKode);
            this.updateProductsPage.Controls.Add(this.flatLabel7);
            this.updateProductsPage.Controls.Add(this.flatLabel8);
            this.updateProductsPage.Controls.Add(this.flatLabel9);
            this.updateProductsPage.Controls.Add(this.flatLabel10);
            this.updateProductsPage.Controls.Add(this.flatLabel11);
            this.updateProductsPage.Controls.Add(this.flatLabel12);
            this.updateProductsPage.Location = new System.Drawing.Point(4, 44);
            this.updateProductsPage.Name = "updateProductsPage";
            this.updateProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateProductsPage.Size = new System.Drawing.Size(805, 318);
            this.updateProductsPage.TabIndex = 7;
            this.updateProductsPage.Text = "Edit";
            // 
            // lastBtn
            // 
            this.lastBtn.BackColor = System.Drawing.Color.Transparent;
            this.lastBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.lastBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastBtn.Location = new System.Drawing.Point(488, 262);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Rounded = false;
            this.lastBtn.Size = new System.Drawing.Size(82, 32);
            this.lastBtn.TabIndex = 33;
            this.lastBtn.Text = "Last";
            this.lastBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nextBtn.Location = new System.Drawing.Point(400, 262);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Rounded = false;
            this.nextBtn.Size = new System.Drawing.Size(82, 32);
            this.nextBtn.TabIndex = 32;
            this.nextBtn.Text = "Next";
            this.nextBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.prevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prevBtn.Location = new System.Drawing.Point(312, 262);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Rounded = false;
            this.prevBtn.Size = new System.Drawing.Size(82, 32);
            this.prevBtn.TabIndex = 31;
            this.prevBtn.Text = "Prev";
            this.prevBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // firstBtn
            // 
            this.firstBtn.BackColor = System.Drawing.Color.Transparent;
            this.firstBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.firstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.firstBtn.Location = new System.Drawing.Point(224, 262);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Rounded = false;
            this.firstBtn.Size = new System.Drawing.Size(82, 32);
            this.firstBtn.TabIndex = 30;
            this.firstBtn.Text = "First";
            this.firstBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(621, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rounded = false;
            this.btnDelete.Size = new System.Drawing.Size(106, 32);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.AutoSize = true;
            this.txtUpdateID.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateID.ForeColor = System.Drawing.Color.White;
            this.txtUpdateID.Location = new System.Drawing.Point(219, 41);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(51, 17);
            this.txtUpdateID.TabIndex = 28;
            this.txtUpdateID.Text = "rndmID";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelEdit.Location = new System.Drawing.Point(621, 175);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Rounded = false;
            this.btnCancelEdit.Size = new System.Drawing.Size(106, 32);
            this.btnCancelEdit.TabIndex = 21;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(621, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rounded = false;
            this.btnUpdate.Size = new System.Drawing.Size(106, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateHargaJual
            // 
            this.txtUpdateHargaJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateHargaJual.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateHargaJual.FocusOnHover = false;
            this.txtUpdateHargaJual.Location = new System.Drawing.Point(222, 213);
            this.txtUpdateHargaJual.MaxLength = 15;
            this.txtUpdateHargaJual.Multiline = false;
            this.txtUpdateHargaJual.Name = "txtUpdateHargaJual";
            this.txtUpdateHargaJual.ReadOnly = false;
            this.txtUpdateHargaJual.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateHargaJual.TabIndex = 19;
            this.txtUpdateHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateHargaJual.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateHargaJual.UseSystemPasswordChar = false;
            // 
            // txtUpdateHargaHPP
            // 
            this.txtUpdateHargaHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateHargaHPP.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateHargaHPP.FocusOnHover = false;
            this.txtUpdateHargaHPP.Location = new System.Drawing.Point(222, 178);
            this.txtUpdateHargaHPP.MaxLength = 15;
            this.txtUpdateHargaHPP.Multiline = false;
            this.txtUpdateHargaHPP.Name = "txtUpdateHargaHPP";
            this.txtUpdateHargaHPP.ReadOnly = false;
            this.txtUpdateHargaHPP.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateHargaHPP.TabIndex = 18;
            this.txtUpdateHargaHPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateHargaHPP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateHargaHPP.UseSystemPasswordChar = false;
            // 
            // txtUpdateJlhAwal
            // 
            this.txtUpdateJlhAwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateJlhAwal.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateJlhAwal.FocusOnHover = false;
            this.txtUpdateJlhAwal.Location = new System.Drawing.Point(222, 143);
            this.txtUpdateJlhAwal.MaxLength = 4;
            this.txtUpdateJlhAwal.Multiline = false;
            this.txtUpdateJlhAwal.Name = "txtUpdateJlhAwal";
            this.txtUpdateJlhAwal.ReadOnly = false;
            this.txtUpdateJlhAwal.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateJlhAwal.TabIndex = 17;
            this.txtUpdateJlhAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateJlhAwal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateJlhAwal.UseSystemPasswordChar = false;
            // 
            // txtUpdateNama
            // 
            this.txtUpdateNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateNama.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateNama.FocusOnHover = false;
            this.txtUpdateNama.Location = new System.Drawing.Point(222, 108);
            this.txtUpdateNama.MaxLength = 50;
            this.txtUpdateNama.Multiline = false;
            this.txtUpdateNama.Name = "txtUpdateNama";
            this.txtUpdateNama.ReadOnly = false;
            this.txtUpdateNama.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateNama.TabIndex = 16;
            this.txtUpdateNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateNama.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateNama.UseSystemPasswordChar = false;
            // 
            // txtUpdateKode
            // 
            this.txtUpdateKode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateKode.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateKode.FocusOnHover = false;
            this.txtUpdateKode.Location = new System.Drawing.Point(222, 73);
            this.txtUpdateKode.MaxLength = 10;
            this.txtUpdateKode.Multiline = false;
            this.txtUpdateKode.Name = "txtUpdateKode";
            this.txtUpdateKode.ReadOnly = false;
            this.txtUpdateKode.Size = new System.Drawing.Size(134, 29);
            this.txtUpdateKode.TabIndex = 15;
            this.txtUpdateKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateKode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateKode.UseSystemPasswordChar = false;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(77, 216);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(36, 17);
            this.flatLabel7.TabIndex = 27;
            this.flatLabel7.Text = "Price";
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(77, 181);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(123, 17);
            this.flatLabel8.TabIndex = 26;
            this.flatLabel8.Text = "Cost of Goods Sold";
            // 
            // flatLabel9
            // 
            this.flatLabel9.AutoSize = true;
            this.flatLabel9.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel9.ForeColor = System.Drawing.Color.White;
            this.flatLabel9.Location = new System.Drawing.Point(77, 146);
            this.flatLabel9.Name = "flatLabel9";
            this.flatLabel9.Size = new System.Drawing.Size(56, 17);
            this.flatLabel9.TabIndex = 25;
            this.flatLabel9.Text = "Quantity";
            // 
            // flatLabel10
            // 
            this.flatLabel10.AutoSize = true;
            this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel10.ForeColor = System.Drawing.Color.White;
            this.flatLabel10.Location = new System.Drawing.Point(77, 111);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(43, 17);
            this.flatLabel10.TabIndex = 24;
            this.flatLabel10.Text = "Name";
            // 
            // flatLabel11
            // 
            this.flatLabel11.AutoSize = true;
            this.flatLabel11.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel11.ForeColor = System.Drawing.Color.White;
            this.flatLabel11.Location = new System.Drawing.Point(77, 76);
            this.flatLabel11.Name = "flatLabel11";
            this.flatLabel11.Size = new System.Drawing.Size(104, 17);
            this.flatLabel11.TabIndex = 23;
            this.flatLabel11.Text = "Code of Product";
            // 
            // flatLabel12
            // 
            this.flatLabel12.AutoSize = true;
            this.flatLabel12.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel12.ForeColor = System.Drawing.Color.White;
            this.flatLabel12.Location = new System.Drawing.Point(77, 41);
            this.flatLabel12.Name = "flatLabel12";
            this.flatLabel12.Size = new System.Drawing.Size(20, 17);
            this.flatLabel12.TabIndex = 22;
            this.flatLabel12.Text = "ID";
            // 
            // viewProductsPage
            // 
            this.viewProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.viewProductsPage.Controls.Add(this.dataGridView1);
            this.viewProductsPage.Location = new System.Drawing.Point(4, 44);
            this.viewProductsPage.Name = "viewProductsPage";
            this.viewProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewProductsPage.Size = new System.Drawing.Size(805, 318);
            this.viewProductsPage.TabIndex = 9;
            this.viewProductsPage.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(747, 0);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 2;
            this.flatMini1.TabStop = false;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(771, 0);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 1;
            this.flatMax1.TabStop = false;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(795, 0);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.TabStop = false;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // editAlertBox
            // 
            this.editAlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.editAlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editAlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editAlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.editAlertBox.Location = new System.Drawing.Point(333, 16);
            this.editAlertBox.Name = "editAlertBox";
            this.editAlertBox.Size = new System.Drawing.Size(452, 42);
            this.editAlertBox.TabIndex = 34;
            this.editAlertBox.Text = "flatAlertBox1";
            this.editAlertBox.Visible = false;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 410);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.formSkin1.ResumeLayout(false);
            this.productsTabControl.ResumeLayout(false);
            this.addProductsPage.ResumeLayout(false);
            this.addProductsPage.PerformLayout();
            this.updateProductsPage.ResumeLayout(false);
            this.updateProductsPage.PerformLayout();
            this.viewProductsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatTabControl productsTabControl;
        private System.Windows.Forms.TabPage addProductsPage;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton btnAddCancel;
        private FlatUI.FlatButton btnAddSave;
        private FlatUI.FlatTextBox txtAddHrgJual;
        private FlatUI.FlatTextBox txtAddHrgHPP;
        private FlatUI.FlatTextBox txtAddJlhAwal;
        private FlatUI.FlatTextBox txtAddNama;
        private FlatUI.FlatTextBox txtAddKode;
        private System.Windows.Forms.TabPage updateProductsPage;
        private System.Windows.Forms.TabPage viewProductsPage;
        private FlatUI.FlatAlertBox addAlertBox;
        private FlatUI.FlatButton btnCancelEdit;
        private FlatUI.FlatButton btnUpdate;
        private FlatUI.FlatTextBox txtUpdateHargaJual;
        private FlatUI.FlatTextBox txtUpdateHargaHPP;
        private FlatUI.FlatTextBox txtUpdateJlhAwal;
        private FlatUI.FlatTextBox txtUpdateNama;
        private FlatUI.FlatTextBox txtUpdateKode;
        private FlatUI.FlatLabel flatLabel7;
        private FlatUI.FlatLabel flatLabel8;
        private FlatUI.FlatLabel flatLabel9;
        private FlatUI.FlatLabel flatLabel10;
        private FlatUI.FlatLabel flatLabel11;
        private FlatUI.FlatLabel flatLabel12;
        private FlatUI.FlatLabel txtAddID;
        private FlatUI.FlatLabel txtUpdateID;
        private FlatUI.FlatButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FlatUI.FlatButton lastBtn;
        private FlatUI.FlatButton nextBtn;
        private FlatUI.FlatButton prevBtn;
        private FlatUI.FlatButton firstBtn;
        private FlatUI.FlatAlertBox editAlertBox;
    }
}

