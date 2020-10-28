using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Desktop
{
    public partial class Principal : Form
    {
        private long codUsuario;
        private int codPerfil;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(long codUsuario, int codPerfil)
        {
            this.codUsuario = codUsuario;
            this.codPerfil = codPerfil;
        }
    }
}
