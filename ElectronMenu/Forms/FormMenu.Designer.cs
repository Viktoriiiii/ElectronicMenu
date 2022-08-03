namespace ElectronMenu
{
    partial class FormMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonBasket = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.listViewD = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listViewChoice = new System.Windows.Forms.ListView();
            this.panelAddDelete = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.chartMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUprMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonReturnToMain = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelAddDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoney)).BeginInit();
            this.panelUprMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBasket
            // 
            this.buttonBasket.BackColor = System.Drawing.Color.Snow;
            this.buttonBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBasket.Font = new System.Drawing.Font("Wingdings 2", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBasket.ForeColor = System.Drawing.Color.Brown;
            this.buttonBasket.Location = new System.Drawing.Point(109, 10);
            this.buttonBasket.Margin = new System.Windows.Forms.Padding(350, 20, 30, 20);
            this.buttonBasket.Name = "buttonBasket";
            this.buttonBasket.Size = new System.Drawing.Size(154, 46);
            this.buttonBasket.TabIndex = 5;
            this.buttonBasket.Text = "Заказать";
            this.buttonBasket.UseVisualStyleBackColor = false;
            this.buttonBasket.Click += new System.EventHandler(this.buttonBasket_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.tableLayoutPanelMenu);
            this.panelMenu.Controls.Add(this.panelUprMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(8);
            this.panelMenu.Size = new System.Drawing.Size(534, 511);
            this.panelMenu.TabIndex = 3;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 3;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMenu.Controls.Add(this.textBoxCategory, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.listViewD, 1, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.listViewCategory, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.listViewChoice, 2, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.panelAddDelete, 1, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.labelOutput, 2, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.chartMoney, 0, 2);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(8, 111);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelMenu.RowCount = 3;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(518, 392);
            this.tableLayoutPanelMenu.TabIndex = 7;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BackColor = System.Drawing.Color.Snow;
            this.textBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCategory.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategory.ForeColor = System.Drawing.Color.Brown;
            this.textBoxCategory.Location = new System.Drawing.Point(8, 8);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(95, 24);
            this.textBoxCategory.TabIndex = 1;
            this.textBoxCategory.Text = "Категории";
            this.textBoxCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewD
            // 
            this.listViewD.BackColor = System.Drawing.Color.Snow;
            this.listViewD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewD.ForeColor = System.Drawing.Color.Brown;
            this.listViewD.HideSelection = false;
            this.listViewD.Location = new System.Drawing.Point(112, 53);
            this.listViewD.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.listViewD.MultiSelect = false;
            this.listViewD.Name = "listViewD";
            this.listViewD.ShowItemToolTips = true;
            this.listViewD.Size = new System.Drawing.Size(191, 235);
            this.listViewD.TabIndex = 6;
            this.listViewD.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Brown;
            this.textBox1.Location = new System.Drawing.Point(109, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Список блюд категории";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewCategory
            // 
            this.listViewCategory.BackColor = System.Drawing.Color.Snow;
            this.listViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCategory.ForeColor = System.Drawing.Color.Brown;
            this.listViewCategory.HideSelection = false;
            this.listViewCategory.Location = new System.Drawing.Point(8, 53);
            this.listViewCategory.Margin = new System.Windows.Forms.Padding(3, 10, 6, 3);
            this.listViewCategory.MultiSelect = false;
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(92, 235);
            this.listViewCategory.TabIndex = 0;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.View = System.Windows.Forms.View.List;
            this.listViewCategory.SelectedIndexChanged += new System.EventHandler(this.listViewCategory_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Snow;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Brown;
            this.textBox2.Location = new System.Drawing.Point(312, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Выбрано:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewChoice
            // 
            this.listViewChoice.BackColor = System.Drawing.Color.Snow;
            this.listViewChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChoice.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewChoice.ForeColor = System.Drawing.Color.Brown;
            this.listViewChoice.HideSelection = false;
            this.listViewChoice.Location = new System.Drawing.Point(315, 53);
            this.listViewChoice.Margin = new System.Windows.Forms.Padding(6, 10, 3, 3);
            this.listViewChoice.MultiSelect = false;
            this.listViewChoice.Name = "listViewChoice";
            this.listViewChoice.Size = new System.Drawing.Size(195, 235);
            this.listViewChoice.TabIndex = 8;
            this.listViewChoice.UseCompatibleStateImageBehavior = false;
            this.listViewChoice.View = System.Windows.Forms.View.List;
            // 
            // panelAddDelete
            // 
            this.panelAddDelete.Controls.Add(this.buttonAdd);
            this.panelAddDelete.Controls.Add(this.buttonDelete);
            this.panelAddDelete.Controls.Add(this.buttonClear);
            this.panelAddDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddDelete.Location = new System.Drawing.Point(109, 294);
            this.panelAddDelete.Name = "panelAddDelete";
            this.panelAddDelete.Size = new System.Drawing.Size(197, 90);
            this.panelAddDelete.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Snow;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Wingdings 2", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Brown;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 44);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Перенести блюдо в заказ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Snow;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Wingdings 2", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Brown;
            this.buttonDelete.Location = new System.Drawing.Point(0, 44);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 46);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить блюдо из заказа";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Snow;
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Wingdings 2", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Brown;
            this.buttonClear.Location = new System.Drawing.Point(96, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 90);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить список заказа";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutput.Font = new System.Drawing.Font("Wingdings 2", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.ForeColor = System.Drawing.Color.Brown;
            this.labelOutput.Location = new System.Drawing.Point(319, 301);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(10);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(184, 76);
            this.labelOutput.TabIndex = 11;
            this.labelOutput.Text = "Было в кошельке = 4028";
            // 
            // chartMoney
            // 
            this.chartMoney.BackColor = System.Drawing.Color.Snow;
            this.chartMoney.BackImageTransparentColor = System.Drawing.Color.Snow;
            this.chartMoney.BackSecondaryColor = System.Drawing.Color.Snow;
            this.chartMoney.BorderlineColor = System.Drawing.Color.Snow;
            chartArea1.Name = "ChartArea1";
            this.chartMoney.ChartAreas.Add(chartArea1);
            this.chartMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 30F;
            legend1.Name = "Legend3";
            this.chartMoney.Legends.Add(legend1);
            this.chartMoney.Location = new System.Drawing.Point(8, 294);
            this.chartMoney.Name = "chartMoney";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend3";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartMoney.Series.Add(series1);
            this.chartMoney.Size = new System.Drawing.Size(95, 90);
            this.chartMoney.TabIndex = 12;
            this.chartMoney.Text = "chart1";
            // 
            // panelUprMenu
            // 
            this.panelUprMenu.Controls.Add(this.pictureBoxLogo);
            this.panelUprMenu.Controls.Add(this.buttonBasket);
            this.panelUprMenu.Controls.Add(this.buttonReturnToMain);
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
            // buttonReturnToMain
            // 
            this.buttonReturnToMain.BackColor = System.Drawing.Color.Snow;
            this.buttonReturnToMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnToMain.Font = new System.Drawing.Font("Wingdings 2", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnToMain.ForeColor = System.Drawing.Color.Brown;
            this.buttonReturnToMain.Location = new System.Drawing.Point(354, 10);
            this.buttonReturnToMain.Margin = new System.Windows.Forms.Padding(350, 20, 30, 20);
            this.buttonReturnToMain.Name = "buttonReturnToMain";
            this.buttonReturnToMain.Size = new System.Drawing.Size(154, 46);
            this.buttonReturnToMain.TabIndex = 1;
            this.buttonReturnToMain.Text = "Возврат на главную";
            this.buttonReturnToMain.UseVisualStyleBackColor = false;
            this.buttonReturnToMain.Click += new System.EventHandler(this.buttonReturnToMain_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.PerformLayout();
            this.panelAddDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMoney)).EndInit();
            this.panelUprMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBasket;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUprMenu;
        private System.Windows.Forms.Button buttonReturnToMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listViewD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listViewChoice;
        private System.Windows.Forms.Panel panelAddDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoney;
    }
}