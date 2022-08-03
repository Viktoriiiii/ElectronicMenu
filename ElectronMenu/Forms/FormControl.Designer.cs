namespace ElectronMenu
{
    partial class FormControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.buttonReturnToMain = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelUprControl = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl.SuspendLayout();
            this.panelUprControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
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
            this.buttonReturnToMain.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Controls.Add(this.panelUprControl);
            this.panelControl.Controls.Add(this.tableLayoutPanelControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(100);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl.Size = new System.Drawing.Size(534, 511);
            this.panelControl.TabIndex = 2;
            // 
            // panelUprControl
            // 
            this.panelUprControl.Controls.Add(this.pictureBoxLogo);
            this.panelUprControl.Controls.Add(this.buttonReturnToMain);
            this.panelUprControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUprControl.Location = new System.Drawing.Point(8, 8);
            this.panelUprControl.Name = "panelUprControl";
            this.panelUprControl.Padding = new System.Windows.Forms.Padding(10);
            this.panelUprControl.Size = new System.Drawing.Size(518, 66);
            this.panelUprControl.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::ElectronMenu.Properties.Resources.icon1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(61, 46);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanelControl
            // 
            this.tableLayoutPanelControl.ColumnCount = 2;
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelControl.Location = new System.Drawing.Point(8, 80);
            this.tableLayoutPanelControl.Name = "tableLayoutPanelControl";
            this.tableLayoutPanelControl.RowCount = 2;
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.Size = new System.Drawing.Size(518, 423);
            this.tableLayoutPanelControl.TabIndex = 3;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "FormControl";
            this.Text = "Управление меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControl_FormClosing);
            this.panelControl.ResumeLayout(false);
            this.panelUprControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReturnToMain;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControl;
        private System.Windows.Forms.Panel panelUprControl;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}