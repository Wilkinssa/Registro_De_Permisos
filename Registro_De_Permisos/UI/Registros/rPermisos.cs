using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_De_Permisos.Entidades;
using Registro_De_Permisos.BLL;

namespace Registro_De_Permisos.UI.Registros
{
    public partial class rPermisoForm : Form
    {
        public rPermisoForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            PermisosIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
        }

        private Permiso LlenarClase()
        {
            Permiso permiso = new Permiso();

            permiso.permisoId = (int)PermisosIdNumericUpDown.Value;
            permiso.descripcion = DescripcionTextBox.Text;

            return permiso;
        }

        private void LlenarCampos(Permiso permiso)
        {
            PermisosIdNumericUpDown.Value = permiso.permisoId;
            DescripcionTextBox.Text = permiso.descripcion;
        }

        private bool EstaEnLaBaseDeDatos()
        {
            Permiso permiso = PermisosBLL.Buscar((int)PermisosIdNumericUpDown.Value);
            return (permiso != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo nombre no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if (PermisosBLL.ExisteDescripcion(DescripcionTextBox.Text, (int)PermisosIdNumericUpDown.Value))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroRolesForm_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Permiso permiso;
            bool paso = false;

            if (!Validar())
                return;

            permiso = LlenarClase();

            paso = PermisosBLL.Guardar(permiso);

            if (!paso)
            {
                MessageBox.Show("No fue posible guardar o modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                Limpiar();
            }
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!PermisosBLL.Eliminar((int)PermisosIdNumericUpDown.Value))
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Permiso permiso = PermisosBLL.Buscar((int)PermisosIdNumericUpDown.Value);

            if (EstaEnLaBaseDeDatos())
            {
                LlenarCampos(permiso);

            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
