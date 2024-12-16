using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Vista
{
    public partial class frmHome : Form
    {
        private frmContenedor contenedor;

        public frmHome(frmContenedor contenedor)
        {
            InitializeComponent();

            this.contenedor = contenedor;
        }


        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
