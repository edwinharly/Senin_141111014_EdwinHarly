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
            this.btnCancel = new FlatUI.FlatButton();
            this.btnSave = new FlatUI.FlatButton();
            this.txtHrgJual = new FlatUI.FlatTextBox();
            this.txtHrgHPP = new FlatUI.FlatTextBox();
            this.txtJlhAwal = new FlatUI.FlatTextBox();
            this.txtNama = new FlatUI.FlatTextBox();
            this.txtKode = new FlatUI.FlatTextBox();
            this.txtID = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.updateProductsPage = new System.Windows.Forms.TabPage();
            this.deleteProductsPage = new System.Windows.Forms.TabPage();
            this.viewProductsPage = new System.Windows.Forms.TabPage();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.formSkin1.SuspendLayout();
            this.productsTabControl.SuspendLayout();
            this.addProductsPage.SuspendLayout();
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
            this.formSkin1.Text = "Products";
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
            this.productsTabControl.Controls.Add(this.deleteProductsPage);
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
            this.addProductsPage.Controls.Add(this.flatAlertBox1);
            this.addProductsPage.Controls.Add(this.btnCancel);
            this.addProductsPage.Controls.Add(this.btnSave);
            this.addProductsPage.Controls.Add(this.txtHrgJual);
            this.addProductsPage.Controls.Add(this.txtHrgHPP);
            this.addProductsPage.Controls.Add(this.txtJlhAwal);
            this.addProductsPage.Controls.Add(this.txtNama);
            this.addProductsPage.Controls.Add(this.txtKode);
            this.addProductsPage.Controls.Add(this.txtID);
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
            this.addProductsPage.Text = "Add";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(601, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rounded = false;
            this.btnCancel.Size = new System.Drawing.Size(106, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(601, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rounded = false;
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHrgJual
            // 
            this.txtHrgJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHrgJual.BackColor = System.Drawing.Color.Transparent;
            this.txtHrgJual.FocusOnHover = false;
            this.txtHrgJual.Location = new System.Drawing.Point(225, 209);
            this.txtHrgJual.MaxLength = 15;
            this.txtHrgJual.Multiline = false;
            this.txtHrgJual.Name = "txtHrgJual";
            this.txtHrgJual.ReadOnly = false;
            this.txtHrgJual.Size = new System.Drawing.Size(350, 29);
            this.txtHrgJual.TabIndex = 5;
            this.txtHrgJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHrgJual.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHrgJual.UseSystemPasswordChar = false;
            // 
            // txtHrgHPP
            // 
            this.txtHrgHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHrgHPP.BackColor = System.Drawing.Color.Transparent;
            this.txtHrgHPP.FocusOnHover = false;
            this.txtHrgHPP.Location = new System.Drawing.Point(225, 174);
            this.txtHrgHPP.MaxLength = 15;
            this.txtHrgHPP.Multiline = false;
            this.txtHrgHPP.Name = "txtHrgHPP";
            this.txtHrgHPP.ReadOnly = false;
            this.txtHrgHPP.Size = new System.Drawing.Size(350, 29);
            this.txtHrgHPP.TabIndex = 4;
            this.txtHrgHPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHrgHPP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHrgHPP.UseSystemPasswordChar = false;
            // 
            // txtJlhAwal
            // 
            this.txtJlhAwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJlhAwal.BackColor = System.Drawing.Color.Transparent;
            this.txtJlhAwal.FocusOnHover = false;
            this.txtJlhAwal.Location = new System.Drawing.Point(225, 139);
            this.txtJlhAwal.MaxLength = 4;
            this.txtJlhAwal.Multiline = false;
            this.txtJlhAwal.Name = "txtJlhAwal";
            this.txtJlhAwal.ReadOnly = false;
            this.txtJlhAwal.Size = new System.Drawing.Size(350, 29);
            this.txtJlhAwal.TabIndex = 3;
            this.txtJlhAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJlhAwal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtJlhAwal.UseSystemPasswordChar = false;
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.FocusOnHover = false;
            this.txtNama.Location = new System.Drawing.Point(225, 104);
            this.txtNama.MaxLength = 50;
            this.txtNama.Multiline = false;
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = false;
            this.txtNama.Size = new System.Drawing.Size(350, 29);
            this.txtNama.TabIndex = 2;
            this.txtNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNama.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNama.UseSystemPasswordChar = false;
            // 
            // txtKode
            // 
            this.txtKode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode.BackColor = System.Drawing.Color.Transparent;
            this.txtKode.FocusOnHover = false;
            this.txtKode.Location = new System.Drawing.Point(225, 69);
            this.txtKode.MaxLength = 10;
            this.txtKode.Multiline = false;
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = false;
            this.txtKode.Size = new System.Drawing.Size(134, 29);
            this.txtKode.TabIndex = 1;
            this.txtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtKode.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.FocusOnHover = false;
            this.txtID.Location = new System.Drawing.Point(225, 34);
            this.txtID.MaxLength = 10;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(134, 29);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtID.UseSystemPasswordChar = false;
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
            this.updateProductsPage.Location = new System.Drawing.Point(4, 44);
            this.updateProductsPage.Name = "updateProductsPage";
            this.updateProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateProductsPage.Size = new System.Drawing.Size(805, 318);
            this.updateProductsPage.TabIndex = 7;
            this.updateProductsPage.Text = "Update";
            // 
            // deleteProductsPage
            // 
            this.deleteProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.deleteProductsPage.Location = new System.Drawing.Point(4, 44);
            this.deleteProductsPage.Name = "deleteProductsPage";
            this.deleteProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteProductsPage.Size = new System.Drawing.Size(805, 318);
            this.deleteProductsPage.TabIndex = 8;
            this.deleteProductsPage.Text = "Delete";
            // 
            // viewProductsPage
            // 
            this.viewProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.viewProductsPage.Location = new System.Drawing.Point(4, 44);
            this.viewProductsPage.Name = "viewProductsPage";
            this.viewProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewProductsPage.Size = new System.Drawing.Size(805, 318);
            this.viewProductsPage.TabIndex = 9;
            this.viewProductsPage.Text = "View";
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
            // flatAlertBox1
            // 
            this.flatAlertBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.flatAlertBox1.Location = new System.Drawing.Point(83, 255);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(624, 42);
            this.flatAlertBox1.TabIndex = 14;
            this.flatAlertBox1.Text = "The data has been successfully added.";
            this.flatAlertBox1.Visible = false;
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
        private FlatUI.FlatButton btnCancel;
        private FlatUI.FlatButton btnSave;
        private FlatUI.FlatTextBox txtHrgJual;
        private FlatUI.FlatTextBox txtHrgHPP;
        private FlatUI.FlatTextBox txtJlhAwal;
        private FlatUI.FlatTextBox txtNama;
        private FlatUI.FlatTextBox txtKode;
        private FlatUI.FlatTextBox txtID;
        private System.Windows.Forms.TabPage updateProductsPage;
        private System.Windows.Forms.TabPage deleteProductsPage;
        private System.Windows.Forms.TabPage viewProductsPage;
        private FlatUI.FlatAlertBox flatAlertBox1;
    }
}

