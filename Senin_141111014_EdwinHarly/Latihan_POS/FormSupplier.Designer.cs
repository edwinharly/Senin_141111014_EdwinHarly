namespace Latihan_POS
{
    partial class FormSupplier
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
            this.suppliersTabControl = new FlatUI.FlatTabControl();
            this.addProductsPage = new System.Windows.Forms.TabPage();
            this.txtAddID = new FlatUI.FlatLabel();
            this.addAlertBox = new FlatUI.FlatAlertBox();
            this.btnAddCancel = new FlatUI.FlatButton();
            this.btnAddSave = new FlatUI.FlatButton();
            this.txtAddEmail = new FlatUI.FlatTextBox();
            this.txtAddPhone = new FlatUI.FlatTextBox();
            this.txtAddZip = new FlatUI.FlatTextBox();
            this.txtAddAddress = new FlatUI.FlatTextBox();
            this.txtAddName = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.updateProductsPage = new System.Windows.Forms.TabPage();
            this.flatLabel13 = new FlatUI.FlatLabel();
            this.flatLabel14 = new FlatUI.FlatLabel();
            this.flatLabel15 = new FlatUI.FlatLabel();
            this.flatLabel16 = new FlatUI.FlatLabel();
            this.flatLabel17 = new FlatUI.FlatLabel();
            this.flatLabel18 = new FlatUI.FlatLabel();
            this.editAlertBox = new FlatUI.FlatAlertBox();
            this.lastBtn = new FlatUI.FlatButton();
            this.nextBtn = new FlatUI.FlatButton();
            this.prevBtn = new FlatUI.FlatButton();
            this.firstBtn = new FlatUI.FlatButton();
            this.btnDelete = new FlatUI.FlatButton();
            this.txtUpdateID = new FlatUI.FlatLabel();
            this.btnCancelEdit = new FlatUI.FlatButton();
            this.btnUpdate = new FlatUI.FlatButton();
            this.txtUpdateEmail = new FlatUI.FlatTextBox();
            this.txtUpdatePhone = new FlatUI.FlatTextBox();
            this.txtUpdateZip = new FlatUI.FlatTextBox();
            this.txtUpdateAddress = new FlatUI.FlatTextBox();
            this.txtUpdateName = new FlatUI.FlatTextBox();
            this.viewProductsPage = new System.Windows.Forms.TabPage();
            this.DGVSupplier = new System.Windows.Forms.DataGridView();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatMini1 = new FlatUI.FlatMini();
            this.formSkin1.SuspendLayout();
            this.suppliersTabControl.SuspendLayout();
            this.addProductsPage.SuspendLayout();
            this.updateProductsPage.SuspendLayout();
            this.viewProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.suppliersTabControl);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(813, 410);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Supplier - Point of Sale";
            // 
            // suppliersTabControl
            // 
            this.suppliersTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.suppliersTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersTabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.suppliersTabControl.Controls.Add(this.addProductsPage);
            this.suppliersTabControl.Controls.Add(this.updateProductsPage);
            this.suppliersTabControl.Controls.Add(this.viewProductsPage);
            this.suppliersTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.suppliersTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.suppliersTabControl.Location = new System.Drawing.Point(0, 44);
            this.suppliersTabControl.Name = "suppliersTabControl";
            this.suppliersTabControl.SelectedIndex = 0;
            this.suppliersTabControl.Size = new System.Drawing.Size(813, 366);
            this.suppliersTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.suppliersTabControl.TabIndex = 4;
            this.suppliersTabControl.TabStop = false;
            // 
            // addProductsPage
            // 
            this.addProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.addProductsPage.Controls.Add(this.txtAddID);
            this.addProductsPage.Controls.Add(this.addAlertBox);
            this.addProductsPage.Controls.Add(this.btnAddCancel);
            this.addProductsPage.Controls.Add(this.btnAddSave);
            this.addProductsPage.Controls.Add(this.txtAddEmail);
            this.addProductsPage.Controls.Add(this.txtAddPhone);
            this.addProductsPage.Controls.Add(this.txtAddZip);
            this.addProductsPage.Controls.Add(this.txtAddAddress);
            this.addProductsPage.Controls.Add(this.txtAddName);
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
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
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
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtAddEmail.FocusOnHover = false;
            this.txtAddEmail.Location = new System.Drawing.Point(225, 209);
            this.txtAddEmail.MaxLength = 30;
            this.txtAddEmail.Multiline = false;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.ReadOnly = false;
            this.txtAddEmail.Size = new System.Drawing.Size(350, 29);
            this.txtAddEmail.TabIndex = 5;
            this.txtAddEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddEmail.UseSystemPasswordChar = false;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtAddPhone.FocusOnHover = false;
            this.txtAddPhone.Location = new System.Drawing.Point(225, 174);
            this.txtAddPhone.MaxLength = 15;
            this.txtAddPhone.Multiline = false;
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.ReadOnly = false;
            this.txtAddPhone.Size = new System.Drawing.Size(172, 29);
            this.txtAddPhone.TabIndex = 4;
            this.txtAddPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddPhone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddPhone.UseSystemPasswordChar = false;
            // 
            // txtAddZip
            // 
            this.txtAddZip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddZip.BackColor = System.Drawing.Color.Transparent;
            this.txtAddZip.FocusOnHover = false;
            this.txtAddZip.Location = new System.Drawing.Point(225, 139);
            this.txtAddZip.MaxLength = 5;
            this.txtAddZip.Multiline = false;
            this.txtAddZip.Name = "txtAddZip";
            this.txtAddZip.ReadOnly = false;
            this.txtAddZip.Size = new System.Drawing.Size(172, 29);
            this.txtAddZip.TabIndex = 3;
            this.txtAddZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddZip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddZip.UseSystemPasswordChar = false;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddAddress.FocusOnHover = false;
            this.txtAddAddress.Location = new System.Drawing.Point(225, 104);
            this.txtAddAddress.MaxLength = 50;
            this.txtAddAddress.Multiline = false;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.ReadOnly = false;
            this.txtAddAddress.Size = new System.Drawing.Size(350, 29);
            this.txtAddAddress.TabIndex = 2;
            this.txtAddAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddAddress.UseSystemPasswordChar = false;
            // 
            // txtAddName
            // 
            this.txtAddName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddName.BackColor = System.Drawing.Color.Transparent;
            this.txtAddName.FocusOnHover = false;
            this.txtAddName.Location = new System.Drawing.Point(225, 69);
            this.txtAddName.MaxLength = 30;
            this.txtAddName.Multiline = false;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.ReadOnly = false;
            this.txtAddName.Size = new System.Drawing.Size(350, 29);
            this.txtAddName.TabIndex = 1;
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddName.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(80, 212);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(45, 17);
            this.flatLabel6.TabIndex = 13;
            this.flatLabel6.Text = "E-Mail";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(80, 177);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(96, 17);
            this.flatLabel5.TabIndex = 12;
            this.flatLabel5.Text = "Phone Number";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(80, 142);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(61, 17);
            this.flatLabel4.TabIndex = 11;
            this.flatLabel4.Text = "Zip Code";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(80, 107);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(56, 17);
            this.flatLabel3.TabIndex = 10;
            this.flatLabel3.Text = "Address";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(80, 72);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(43, 17);
            this.flatLabel2.TabIndex = 9;
            this.flatLabel2.Text = "Name";
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
            this.updateProductsPage.Controls.Add(this.flatLabel13);
            this.updateProductsPage.Controls.Add(this.flatLabel14);
            this.updateProductsPage.Controls.Add(this.flatLabel15);
            this.updateProductsPage.Controls.Add(this.flatLabel16);
            this.updateProductsPage.Controls.Add(this.flatLabel17);
            this.updateProductsPage.Controls.Add(this.flatLabel18);
            this.updateProductsPage.Controls.Add(this.editAlertBox);
            this.updateProductsPage.Controls.Add(this.lastBtn);
            this.updateProductsPage.Controls.Add(this.nextBtn);
            this.updateProductsPage.Controls.Add(this.prevBtn);
            this.updateProductsPage.Controls.Add(this.firstBtn);
            this.updateProductsPage.Controls.Add(this.btnDelete);
            this.updateProductsPage.Controls.Add(this.txtUpdateID);
            this.updateProductsPage.Controls.Add(this.btnCancelEdit);
            this.updateProductsPage.Controls.Add(this.btnUpdate);
            this.updateProductsPage.Controls.Add(this.txtUpdateEmail);
            this.updateProductsPage.Controls.Add(this.txtUpdatePhone);
            this.updateProductsPage.Controls.Add(this.txtUpdateZip);
            this.updateProductsPage.Controls.Add(this.txtUpdateAddress);
            this.updateProductsPage.Controls.Add(this.txtUpdateName);
            this.updateProductsPage.Location = new System.Drawing.Point(4, 44);
            this.updateProductsPage.Name = "updateProductsPage";
            this.updateProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateProductsPage.Size = new System.Drawing.Size(805, 318);
            this.updateProductsPage.TabIndex = 7;
            this.updateProductsPage.Text = "Edit";
            // 
            // flatLabel13
            // 
            this.flatLabel13.AutoSize = true;
            this.flatLabel13.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel13.ForeColor = System.Drawing.Color.White;
            this.flatLabel13.Location = new System.Drawing.Point(85, 216);
            this.flatLabel13.Name = "flatLabel13";
            this.flatLabel13.Size = new System.Drawing.Size(45, 17);
            this.flatLabel13.TabIndex = 40;
            this.flatLabel13.Text = "E-Mail";
            // 
            // flatLabel14
            // 
            this.flatLabel14.AutoSize = true;
            this.flatLabel14.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel14.ForeColor = System.Drawing.Color.White;
            this.flatLabel14.Location = new System.Drawing.Point(85, 181);
            this.flatLabel14.Name = "flatLabel14";
            this.flatLabel14.Size = new System.Drawing.Size(96, 17);
            this.flatLabel14.TabIndex = 39;
            this.flatLabel14.Text = "Phone Number";
            // 
            // flatLabel15
            // 
            this.flatLabel15.AutoSize = true;
            this.flatLabel15.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel15.ForeColor = System.Drawing.Color.White;
            this.flatLabel15.Location = new System.Drawing.Point(85, 146);
            this.flatLabel15.Name = "flatLabel15";
            this.flatLabel15.Size = new System.Drawing.Size(61, 17);
            this.flatLabel15.TabIndex = 38;
            this.flatLabel15.Text = "Zip Code";
            // 
            // flatLabel16
            // 
            this.flatLabel16.AutoSize = true;
            this.flatLabel16.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel16.ForeColor = System.Drawing.Color.White;
            this.flatLabel16.Location = new System.Drawing.Point(85, 111);
            this.flatLabel16.Name = "flatLabel16";
            this.flatLabel16.Size = new System.Drawing.Size(56, 17);
            this.flatLabel16.TabIndex = 37;
            this.flatLabel16.Text = "Address";
            // 
            // flatLabel17
            // 
            this.flatLabel17.AutoSize = true;
            this.flatLabel17.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel17.ForeColor = System.Drawing.Color.White;
            this.flatLabel17.Location = new System.Drawing.Point(85, 76);
            this.flatLabel17.Name = "flatLabel17";
            this.flatLabel17.Size = new System.Drawing.Size(43, 17);
            this.flatLabel17.TabIndex = 36;
            this.flatLabel17.Text = "Name";
            // 
            // flatLabel18
            // 
            this.flatLabel18.AutoSize = true;
            this.flatLabel18.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel18.ForeColor = System.Drawing.Color.White;
            this.flatLabel18.Location = new System.Drawing.Point(85, 41);
            this.flatLabel18.Name = "flatLabel18";
            this.flatLabel18.Size = new System.Drawing.Size(20, 17);
            this.flatLabel18.TabIndex = 35;
            this.flatLabel18.Text = "ID";
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
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateEmail.FocusOnHover = false;
            this.txtUpdateEmail.Location = new System.Drawing.Point(222, 213);
            this.txtUpdateEmail.MaxLength = 30;
            this.txtUpdateEmail.Multiline = false;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.ReadOnly = false;
            this.txtUpdateEmail.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateEmail.TabIndex = 19;
            this.txtUpdateEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateEmail.UseSystemPasswordChar = false;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdatePhone.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdatePhone.FocusOnHover = false;
            this.txtUpdatePhone.Location = new System.Drawing.Point(222, 178);
            this.txtUpdatePhone.MaxLength = 15;
            this.txtUpdatePhone.Multiline = false;
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.ReadOnly = false;
            this.txtUpdatePhone.Size = new System.Drawing.Size(172, 29);
            this.txtUpdatePhone.TabIndex = 18;
            this.txtUpdatePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdatePhone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdatePhone.UseSystemPasswordChar = false;
            // 
            // txtUpdateZip
            // 
            this.txtUpdateZip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateZip.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateZip.FocusOnHover = false;
            this.txtUpdateZip.Location = new System.Drawing.Point(222, 143);
            this.txtUpdateZip.MaxLength = 5;
            this.txtUpdateZip.Multiline = false;
            this.txtUpdateZip.Name = "txtUpdateZip";
            this.txtUpdateZip.ReadOnly = false;
            this.txtUpdateZip.Size = new System.Drawing.Size(172, 29);
            this.txtUpdateZip.TabIndex = 17;
            this.txtUpdateZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateZip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateZip.UseSystemPasswordChar = false;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateAddress.FocusOnHover = false;
            this.txtUpdateAddress.Location = new System.Drawing.Point(222, 108);
            this.txtUpdateAddress.MaxLength = 100;
            this.txtUpdateAddress.Multiline = false;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.ReadOnly = false;
            this.txtUpdateAddress.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateAddress.TabIndex = 16;
            this.txtUpdateAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateAddress.UseSystemPasswordChar = false;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateName.BackColor = System.Drawing.Color.Transparent;
            this.txtUpdateName.FocusOnHover = false;
            this.txtUpdateName.Location = new System.Drawing.Point(222, 73);
            this.txtUpdateName.MaxLength = 30;
            this.txtUpdateName.Multiline = false;
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.ReadOnly = false;
            this.txtUpdateName.Size = new System.Drawing.Size(350, 29);
            this.txtUpdateName.TabIndex = 15;
            this.txtUpdateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUpdateName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUpdateName.UseSystemPasswordChar = false;
            // 
            // viewProductsPage
            // 
            this.viewProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.viewProductsPage.Controls.Add(this.DGVSupplier);
            this.viewProductsPage.Location = new System.Drawing.Point(4, 44);
            this.viewProductsPage.Name = "viewProductsPage";
            this.viewProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewProductsPage.Size = new System.Drawing.Size(805, 318);
            this.viewProductsPage.TabIndex = 9;
            this.viewProductsPage.Text = "View";
            // 
            // DGVSupplier
            // 
            this.DGVSupplier.AllowUserToAddRows = false;
            this.DGVSupplier.AllowUserToDeleteRows = false;
            this.DGVSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSupplier.Location = new System.Drawing.Point(6, 23);
            this.DGVSupplier.Name = "DGVSupplier";
            this.DGVSupplier.ReadOnly = true;
            this.DGVSupplier.Size = new System.Drawing.Size(793, 289);
            this.DGVSupplier.TabIndex = 0;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(792, 4);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 5;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(768, 4);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 6;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(744, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 7;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 410);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupplier";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.formSkin1.ResumeLayout(false);
            this.suppliersTabControl.ResumeLayout(false);
            this.addProductsPage.ResumeLayout(false);
            this.addProductsPage.PerformLayout();
            this.updateProductsPage.ResumeLayout(false);
            this.updateProductsPage.PerformLayout();
            this.viewProductsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTabControl suppliersTabControl;
        private System.Windows.Forms.TabPage addProductsPage;
        private FlatUI.FlatLabel txtAddID;
        private FlatUI.FlatAlertBox addAlertBox;
        private FlatUI.FlatButton btnAddCancel;
        private FlatUI.FlatButton btnAddSave;
        private FlatUI.FlatTextBox txtAddEmail;
        private FlatUI.FlatTextBox txtAddPhone;
        private FlatUI.FlatTextBox txtAddZip;
        private FlatUI.FlatTextBox txtAddAddress;
        private FlatUI.FlatTextBox txtAddName;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.TabPage updateProductsPage;
        private FlatUI.FlatLabel flatLabel13;
        private FlatUI.FlatLabel flatLabel14;
        private FlatUI.FlatLabel flatLabel15;
        private FlatUI.FlatLabel flatLabel16;
        private FlatUI.FlatLabel flatLabel17;
        private FlatUI.FlatLabel flatLabel18;
        private FlatUI.FlatAlertBox editAlertBox;
        private FlatUI.FlatButton lastBtn;
        private FlatUI.FlatButton nextBtn;
        private FlatUI.FlatButton prevBtn;
        private FlatUI.FlatButton firstBtn;
        private FlatUI.FlatButton btnDelete;
        private FlatUI.FlatLabel txtUpdateID;
        private FlatUI.FlatButton btnCancelEdit;
        private FlatUI.FlatButton btnUpdate;
        private FlatUI.FlatTextBox txtUpdateEmail;
        private FlatUI.FlatTextBox txtUpdatePhone;
        private FlatUI.FlatTextBox txtUpdateZip;
        private FlatUI.FlatTextBox txtUpdateAddress;
        private FlatUI.FlatTextBox txtUpdateName;
        private System.Windows.Forms.TabPage viewProductsPage;
        private System.Windows.Forms.DataGridView DGVSupplier;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatClose flatClose1;
    }
}