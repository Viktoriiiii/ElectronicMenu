namespace ElectronMenu
{
    partial class FormBasket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasket));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBasket = new System.Windows.Forms.Panel();
            this.textBoxSumOrder = new System.Windows.Forms.TextBox();
            this.groupBoxOplata = new System.Windows.Forms.GroupBox();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonNal = new System.Windows.Forms.RadioButton();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUprMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelBasket.SuspendLayout();
            this.groupBoxOplata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panelUprMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panelBasket);
            this.panelMenu.Controls.Add(this.panelUprMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(8);
            this.panelMenu.Size = new System.Drawing.Size(534, 511);
            this.panelMenu.TabIndex = 4;
            // 
            // panelBasket
            // 
            this.panelBasket.Controls.Add(this.textBoxSumOrder);
            this.panelBasket.Controls.Add(this.groupBoxOplata);
            this.panelBasket.Controls.Add(this.dataGridViewOrder);
            this.panelBasket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBasket.Location = new System.Drawing.Point(8, 83);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(518, 420);
            this.panelBasket.TabIndex = 5;
            // 
            // textBoxSumOrder
            // 
            this.textBoxSumOrder.BackColor = System.Drawing.Color.Pink;
            this.textBoxSumOrder.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumOrder.ForeColor = System.Drawing.Color.Brown;
            this.textBoxSumOrder.Location = new System.Drawing.Point(10, 392);
            this.textBoxSumOrder.Name = "textBoxSumOrder";
            this.textBoxSumOrder.ReadOnly = true;
            this.textBoxSumOrder.Size = new System.Drawing.Size(498, 25);
            this.textBoxSumOrder.TabIndex = 2;
            this.textBoxSumOrder.Text = "Сумма за Ваш заказ: ";
            // 
            // groupBoxOplata
            // 
            this.groupBoxOplata.Controls.Add(this.radioButtonCard);
            this.groupBoxOplata.Controls.Add(this.radioButtonNal);
            this.groupBoxOplata.Font = new System.Drawing.Font("Wingdings 2", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOplata.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxOplata.Location = new System.Drawing.Point(4, 297);
            this.groupBoxOplata.Name = "groupBoxOplata";
            this.groupBoxOplata.Size = new System.Drawing.Size(510, 78);
            this.groupBoxOplata.TabIndex = 1;
            this.groupBoxOplata.TabStop = false;
            this.groupBoxOplata.Text = "Форма оплаты";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(290, 34);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(185, 21);
            this.radioButtonCard.TabIndex = 1;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Картой (Кэшбек 10%)";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            this.radioButtonCard.CheckedChanged += new System.EventHandler(this.radioButtonNal_CheckedChanged);
            // 
            // radioButtonNal
            // 
            this.radioButtonNal.AutoSize = true;
            this.radioButtonNal.Location = new System.Drawing.Point(21, 34);
            this.radioButtonNal.Name = "radioButtonNal";
            this.radioButtonNal.Size = new System.Drawing.Size(206, 21);
            this.radioButtonNal.TabIndex = 0;
            this.radioButtonNal.TabStop = true;
            this.radioButtonNal.Text = "Наличными (Кэшбек 0%)";
            this.radioButtonNal.UseVisualStyleBackColor = true;
            this.radioButtonNal.CheckedChanged += new System.EventHandler(this.radioButtonNal_CheckedChanged);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Category,
            this.Dish,
            this.CostU,
            this.Num,
            this.CostO});
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOrder.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(518, 291);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // Number
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.DefaultCellStyle = dataGridViewCellStyle3;
            this.Number.FillWeight = 10F;
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.Width = 35;
            // 
            // Category
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.DefaultCellStyle = dataGridViewCellStyle4;
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // Dish
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dish.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dish.HeaderText = "Блюда";
            this.Dish.Name = "Dish";
            this.Dish.ReadOnly = true;
            this.Dish.Width = 200;
            // 
            // CostU
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostU.DefaultCellStyle = dataGridViewCellStyle6;
            this.CostU.HeaderText = "Цена";
            this.CostU.Name = "CostU";
            this.CostU.ReadOnly = true;
            // 
            // Num
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num.DefaultCellStyle = dataGridViewCellStyle7;
            this.Num.HeaderText = "Кол-во";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // CostO
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostO.DefaultCellStyle = dataGridViewCellStyle8;
            this.CostO.HeaderText = "Стоимость";
            this.CostO.Name = "CostO";
            this.CostO.ReadOnly = true;
            // 
            // panelUprMenu
            // 
            this.panelUprMenu.Controls.Add(this.pictureBoxLogo);
            this.panelUprMenu.Controls.Add(this.buttonReturnToMenu);
            this.panelUprMenu.Controls.Add(this.buttonCheck);
            this.panelUprMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUprMenu.Location = new System.Drawing.Point(8, 8);
            this.panelUprMenu.Name = "panelUprMenu";
            this.panelUprMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelUprMenu.Size = new System.Drawing.Size(518, 66);
            this.panelUprMenu.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::ElectronMenu.Properties.Resources.icon1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(61, 46);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.Color.Snow;
            this.buttonReturnToMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Wingdings 2", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.Brown;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(354, 10);
            this.buttonReturnToMenu.Margin = new System.Windows.Forms.Padding(350, 20, 30, 20);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(154, 46);
            this.buttonReturnToMenu.TabIndex = 5;
            this.buttonReturnToMenu.Text = "Возврат в меню";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Snow;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Wingdings 2", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.Color.Brown;
            this.buttonCheck.Location = new System.Drawing.Point(109, 10);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(350, 20, 30, 20);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(154, 46);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Оплатить";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "FormBasket";
            this.Text = "Корзина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBasket_FormClosing);
            this.Load += new System.EventHandler(this.FormBasket_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBasket.ResumeLayout(false);
            this.panelBasket.PerformLayout();
            this.groupBoxOplata.ResumeLayout(false);
            this.groupBoxOplata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panelUprMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUprMenu;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelBasket;
        private System.Windows.Forms.TextBox textBoxSumOrder;
        private System.Windows.Forms.GroupBox groupBoxOplata;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonNal;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostO;
    }
}