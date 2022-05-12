using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemenu
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void tsmi_verme_Click(object sender, EventArgs e)
        {
            FrmVermelho vermei = new FrmVermelho();
            this.Hide();
            vermei.ShowDialog();
        }

        private void tsmi_azul_Click(object sender, EventArgs e)
        {
            FrmAzul azul = new FrmAzul();
            this.Hide();
            azul.ShowDialog();
        }

        private void tsmi_ama_Click(object sender, EventArgs e)
        {
            FrmAmarelo marelo = new FrmAmarelo();
            this.Hide();
            marelo.ShowDialog();
        }
    }
}
