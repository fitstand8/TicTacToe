using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormChoosePlayer : Form
    {
        public FormChoosePlayer()
        {
            InitializeComponent();
        }

        private void FormChoosePlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void XPic_Click(object sender, EventArgs e)
        {
            FormMain.turn = true;
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void OPic_Click(object sender, EventArgs e)
        {
            FormMain.turn = false;
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
