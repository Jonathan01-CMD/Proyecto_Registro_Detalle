using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Proyecto_Registro.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariosToolStripMenuItem_ItemClicked);
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItem_ItemClicked);
        }

       private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var roles = new rRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void UsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuario = new rUsuario();
            usuario.MdiParent = this;
            usuario.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
