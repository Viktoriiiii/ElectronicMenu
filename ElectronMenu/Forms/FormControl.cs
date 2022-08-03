using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronMenu
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormControl"].Close();
            Application.OpenForms[0].Show();
        }

        private void FormControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Закрыть данную страницу?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes);
        }
    }
}
