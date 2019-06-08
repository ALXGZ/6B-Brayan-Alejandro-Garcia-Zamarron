using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.USUARIO = txt_user.Text;
            lg.CONTRASEÑA = txt_pass.Text;

            if (lg.validarLogin(lg.USUARIO, lg.CONTRASEÑA))
            {
                Menu_ppal mp = new Menu_ppal();
                mp.Show();
            }
        }
    }
}
