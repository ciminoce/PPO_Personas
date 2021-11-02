using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_Personas.Windows.Classes;

namespace POO_Personas.Windows
{
    public partial class FrmComienzaCon : Form
    {
        public FrmComienzaCon()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            letras = txtComienza.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }
        string letras;
        public string GetTexto()
        {
            return letras;
        }

        private void txtComienza_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.SoloTexto(e);
        }
    }
}
