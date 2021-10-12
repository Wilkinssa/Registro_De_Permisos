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
    public partial class rRolesForm : Form
    {

        public List<RolesDetalle> Detalle { get; set; }
        public rRolesForm()
        {
            InitializeComponent();
            this.Detalle = new List<RolesDetalle>();
        }

        private void Limpiar()
        {
            
            IdRolesNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            EsActivoCheckBox.Checked = false;

            PermisoIdComboBox.SelectedIndex = 1;
            EsAsignadoCheckBox.Checked = false;

            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }

        private void CargarGrid()
        {
            RolesDetalleDataGridView.DataSource = null;
            RolesDetalleDataGridView.DataSource = this.Detalle;
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();

            rol.rolesId = (int)IdRolesNumericUpDown.Value;
            rol.descripcion = DescripcionTextBox.Text;
            rol.fechaCreacion = FechaCreacionDateTimePicker.Value;
            rol.esActivo = EsActivoCheckBox.Checked;

            rol.RolesDetalle = this.Detalle;

            return rol;
        }

        private void LlenarCampos(Roles rol)
        {
            IdRolesNumericUpDown.Value = rol.rolesId;
            DescripcionTextBox.Text = rol.descripcion;
            FechaCreacionDateTimePicker.Value = rol.fechaCreacion;
            EsActivoCheckBox.Checked = rol.esActivo;

            this.Detalle = rol.RolesDetalle;
            CargarGrid();
        
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

            if (IdRolesNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IdRolesNumericUpDown, "No se puede guardar ningun campo con valor 0");
                IdRolesNumericUpDown.Focus();
                paso = false;
            }

            if (PermisosBLL.ExisteDescripcion(DescripcionTextBox.Text, (int)IdRolesNumericUpDown.Value))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if(this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(RolesDetalleDataGridView, "Debes Agregar un telefono");
                RolesDetalleGroupBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void RegistroRolesForm_Load(object sender, EventArgs e)
        {
            PermisoIdComboBox.DataSource = PermisosBLL.GetRoles();
            PermisoIdComboBox.DisplayMember = "descripcion";
            PermisoIdComboBox.ValueMember = "permisoId";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;

            if (!Validar())
                return;

            rol = LlenarClase();

            paso = RolesBLL.Guardar(rol);

            if (!paso)
                MessageBox.Show("No fue posible guardar o modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                Limpiar();
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (RolesBLL.Eliminar((int)IdRolesNumericUpDown.Value))
                Limpiar();
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles roles = RolesBLL.Buscar((int)IdRolesNumericUpDown.Value);

            if (roles != null)
                LlenarCampos(roles);
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolesDetalleDataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)RolesDetalleDataGridView.DataSource;

            this.Detalle.Add(new RolesDetalle
                (
                    id: 0,
                    Rolid: (int) IdRolesNumericUpDown.Value,
                    PermisoId: (int)PermisoIdComboBox.SelectedIndex,
                    esAsignado: EsAsignadoCheckBox.Checked
                )
            );
            CargarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (RolesDetalleDataGridView.Rows.Count > 0 || RolesDetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(RolesDetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
