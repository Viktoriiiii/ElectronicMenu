namespace ElectronMenu
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonPriceList = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonControlMenu = new System.Windows.Forms.Button();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMakeOrder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPriceList
            // 
            this.buttonPriceList.BackColor = System.Drawing.Color.Snow;
            this.buttonPriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriceList.Font = new System.Drawing.Font("Wingdings 2", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriceList.ForeColor = System.Drawing.Color.Brown;
            this.buttonPriceList.Location = new System.Drawing.Point(170, 320);
            this.buttonPriceList.Margin = new System.Windows.Forms.Padding(140, 20, 50, 20);
            this.buttonPriceList.Name = "buttonPriceList";
            this.buttonPriceList.Size = new System.Drawing.Size(189, 50);
            this.buttonPriceList.TabIndex = 3;
            this.buttonPriceList.Text = "Прайс-лист";
            this.buttonPriceList.UseVisualStyleBackColor = false;
            this.buttonPriceList.Click += new System.EventHandler(this.buttonPriceList_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Snow;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Wingdings 2", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Brown;
            this.buttonExit.Location = new System.Drawing.Point(170, 410);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(140, 20, 50, 20);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(189, 51);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Завершение работы";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonControlMenu
            // 
            this.buttonControlMenu.BackColor = System.Drawing.Color.Snow;
            this.buttonControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonControlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControlMenu.Font = new System.Drawing.Font("Wingdings 2", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonControlMenu.ForeColor = System.Drawing.Color.Brown;
            this.buttonControlMenu.Location = new System.Drawing.Point(170, 230);
            this.buttonControlMenu.Margin = new System.Windows.Forms.Padding(140, 20, 50, 20);
            this.buttonControlMenu.Name = "buttonControlMenu";
            this.buttonControlMenu.Size = new System.Drawing.Size(189, 50);
            this.buttonControlMenu.TabIndex = 1;
            this.buttonControlMenu.Text = "Управлять меню";
            this.buttonControlMenu.UseVisualStyleBackColor = false;
            this.buttonControlMenu.Click += new System.EventHandler(this.buttonControlMenu_Click);
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.BackColor = System.Drawing.Color.Snow;
            this.buttonMakeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeOrder.Font = new System.Drawing.Font("Wingdings 2", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeOrder.ForeColor = System.Drawing.Color.Brown;
            this.buttonMakeOrder.Location = new System.Drawing.Point(170, 140);
            this.buttonMakeOrder.Margin = new System.Windows.Forms.Padding(140, 20, 50, 20);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(189, 50);
            this.buttonMakeOrder.TabIndex = 0;
            this.buttonMakeOrder.Text = "Сделать заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = false;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            this.buttonMakeOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMakeOrder_MouseMove);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.buttonPriceList, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonControlMenu, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonMakeOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxLogo, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxMakeOrder, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox1, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox2, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox3, 1, 4);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(200);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(534, 511);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ElectronMenu.Properties.Resources.icon1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(412, 33);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMakeOrder
            // 
            this.pictureBoxMakeOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMakeOrder.Image")));
            this.pictureBoxMakeOrder.Location = new System.Drawing.Point(424, 135);
            this.pictureBoxMakeOrder.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBoxMakeOrder.Name = "pictureBoxMakeOrder";
            this.pictureBoxMakeOrder.Size = new System.Drawing.Size(65, 60);
            this.pictureBoxMakeOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMakeOrder.TabIndex = 5;
            this.pictureBoxMakeOrder.TabStop = false;
            this.pictureBoxMakeOrder.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 225);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(424, 315);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(424, 405);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "FormMain";
            this.Text = "Электронное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPriceList;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonControlMenu;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxMakeOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

