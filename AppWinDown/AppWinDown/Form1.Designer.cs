namespace AppWinDown
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.iconAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.iconAddCart = new FontAwesome.Sharp.IconPictureBox();
            this.IconLogout = new FontAwesome.Sharp.IconPictureBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btnCart = new FontAwesome.Sharp.IconButton();
            this.panelCategoryItem = new System.Windows.Forms.Panel();
            this.btnAllCategories = new FontAwesome.Sharp.IconButton();
            this.btnTablet = new FontAwesome.Sharp.IconButton();
            this.btnPhone = new FontAwesome.Sharp.IconButton();
            this.btnLaptop = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnCategories = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelCategoryItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnSignIn);
            this.panelHeader.Controls.Add(this.iconAvatar);
            this.panelHeader.Controls.Add(this.iconAddCart);
            this.panelHeader.Controls.Add(this.IconLogout);
            this.panelHeader.Controls.Add(this.pictureLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(10, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelHeader.Size = new System.Drawing.Size(1904, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSignIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignIn.Location = new System.Drawing.Point(1394, 5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(200, 90);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Visible = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // iconAvatar
            // 
            this.iconAvatar.BackColor = System.Drawing.Color.Gainsboro;
            this.iconAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconAvatar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconAvatar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAvatar.IconSize = 90;
            this.iconAvatar.Location = new System.Drawing.Point(1594, 5);
            this.iconAvatar.Name = "iconAvatar";
            this.iconAvatar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconAvatar.Size = new System.Drawing.Size(100, 90);
            this.iconAvatar.TabIndex = 8;
            this.iconAvatar.TabStop = false;
            // 
            // iconAddCart
            // 
            this.iconAddCart.BackColor = System.Drawing.Color.Gainsboro;
            this.iconAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAddCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconAddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconAddCart.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconAddCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconAddCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddCart.IconSize = 90;
            this.iconAddCart.Location = new System.Drawing.Point(1694, 5);
            this.iconAddCart.Name = "iconAddCart";
            this.iconAddCart.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconAddCart.Size = new System.Drawing.Size(100, 90);
            this.iconAddCart.TabIndex = 6;
            this.iconAddCart.TabStop = false;
            // 
            // IconLogout
            // 
            this.IconLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.IconLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IconLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.IconLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconLogout.IconSize = 90;
            this.IconLogout.Location = new System.Drawing.Point(1794, 5);
            this.IconLogout.Name = "IconLogout";
            this.IconLogout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IconLogout.Size = new System.Drawing.Size(100, 90);
            this.IconLogout.TabIndex = 5;
            this.IconLogout.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(10, 5);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(390, 90);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSideBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 924);
            this.panel2.TabIndex = 1;
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoScroll = true;
            this.panelSideBar.BackColor = System.Drawing.Color.Transparent;
            this.panelSideBar.Controls.Add(this.btnCart);
            this.panelSideBar.Controls.Add(this.panelCategoryItem);
            this.panelSideBar.Controls.Add(this.iconButton2);
            this.panelSideBar.Controls.Add(this.btnExit);
            this.panelSideBar.Controls.Add(this.btnCategories);
            this.panelSideBar.Controls.Add(this.btnHome);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelSideBar.Size = new System.Drawing.Size(390, 924);
            this.panelSideBar.TabIndex = 0;
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCart.IconSize = 40;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 510);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(390, 80);
            this.btnCart.TabIndex = 9;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // panelCategoryItem
            // 
            this.panelCategoryItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.panelCategoryItem.AutoScroll = true;
            this.panelCategoryItem.AutoSize = true;
            this.panelCategoryItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCategoryItem.Controls.Add(this.btnAllCategories);
            this.panelCategoryItem.Controls.Add(this.btnTablet);
            this.panelCategoryItem.Controls.Add(this.btnPhone);
            this.panelCategoryItem.Controls.Add(this.btnLaptop);
            this.panelCategoryItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategoryItem.Location = new System.Drawing.Point(0, 180);
            this.panelCategoryItem.Name = "panelCategoryItem";
            this.panelCategoryItem.Padding = new System.Windows.Forms.Padding(60, 0, 0, 10);
            this.panelCategoryItem.Size = new System.Drawing.Size(390, 330);
            this.panelCategoryItem.TabIndex = 7;
            // 
            // btnAllCategories
            // 
            this.btnAllCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllCategories.FlatAppearance.BorderSize = 0;
            this.btnAllCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllCategories.IconChar = FontAwesome.Sharp.IconChar.AlignCenter;
            this.btnAllCategories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllCategories.IconSize = 40;
            this.btnAllCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCategories.Location = new System.Drawing.Point(60, 0);
            this.btnAllCategories.Name = "btnAllCategories";
            this.btnAllCategories.Size = new System.Drawing.Size(330, 80);
            this.btnAllCategories.TabIndex = 5;
            this.btnAllCategories.Text = "All";
            this.btnAllCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllCategories.UseVisualStyleBackColor = true;
            this.btnAllCategories.Click += new System.EventHandler(this.btnAllCategories_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTablet.FlatAppearance.BorderSize = 0;
            this.btnTablet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTablet.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnTablet.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTablet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTablet.IconSize = 40;
            this.btnTablet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablet.Location = new System.Drawing.Point(60, 80);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(330, 80);
            this.btnTablet.TabIndex = 4;
            this.btnTablet.Text = "Computer";
            this.btnTablet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPhone.FlatAppearance.BorderSize = 0;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhone.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPhone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhone.IconSize = 40;
            this.btnPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhone.Location = new System.Drawing.Point(60, 160);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(330, 80);
            this.btnPhone.TabIndex = 3;
            this.btnPhone.Text = "Houseware";
            this.btnPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaptop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLaptop.FlatAppearance.BorderSize = 0;
            this.btnLaptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaptop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLaptop.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.btnLaptop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLaptop.IconSize = 40;
            this.btnLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaptop.Location = new System.Drawing.Point(60, 240);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(330, 80);
            this.btnLaptop.TabIndex = 2;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaptop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 744);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(390, 80);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Help";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 824);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(390, 80);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategories.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnCategories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategories.IconSize = 40;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 100);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(390, 80);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(390, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(350, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1564, 924);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.panelCategoryItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelSideBar;
        private FontAwesome.Sharp.IconPictureBox iconAvatar;
        private FontAwesome.Sharp.IconPictureBox IconLogout;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnCategories;
        private System.Windows.Forms.PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnSignIn;
        private System.Windows.Forms.Panel panelCategoryItem;
        private FontAwesome.Sharp.IconButton btnTablet;
        private FontAwesome.Sharp.IconButton btnPhone;
        private FontAwesome.Sharp.IconButton btnLaptop;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnCart;
        private FontAwesome.Sharp.IconButton btnAllCategories;
        private FontAwesome.Sharp.IconPictureBox iconAddCart;
    }
}

