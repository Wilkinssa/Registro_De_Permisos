using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_De_Permisos.UI.Registros;

namespace Registro_De_Permisos
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItem_ItemClicked);
            this.PermisosToolStripMenuItem.Click += new EventHandler(this.PermisosToolStripMenuItem_ItemClicked);
            this.UsuariosToolStripMenuItem.Click += new EventHandler(this.UsuariosToolStripMenuItem_ItemClicked);

        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rRoles = new rRolesForm();
            rRoles.MdiParent = this;
            rRoles.Show();
        }

        private void PermisosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rPermisos = new rPermisoForm();
            rPermisos.MdiParent = this;
            rPermisos.Show();
        }

        private void UsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rusuario = new rUsuarioForm();
            rusuario.MdiParent = this;
            rusuario.Show();
        }

    }
}
