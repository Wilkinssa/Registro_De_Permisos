﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_De_Permisos.BLL;
using Registro_De_Permisos.Entidades;

namespace Registro_De_Permisos.UI.Registros
{
    public partial class rUsuarioForm : Form
    {
        public rUsuarioForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            RolIdComboBox.SelectedIndex = 1;
            AliasTextBox.Clear();
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmaClaveTextBox.Clear();
            ActivoCheckBox.Checked = false;
            EmailTextBox.Clear();
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenarClase()
        {
            Usuarios user = new Usuarios();

            user.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            user.RolId = RolIdComboBox.SelectedIndex;
            user.Alias = AliasTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Clave = ClaveTextBox.Text;
            user.Activo = ActivoCheckBox.Checked;
            user.Email = EmailTextBox.Text;
            user.FechaIngreso = FechaIngresoDateTimePicker.Value;


            return user;
        }
        private void LlenarCampos(Usuarios user)
        {
            RolIdComboBox.SelectedIndex = user.RolId;
            AliasTextBox.Text = user.Alias;
            NombreTextBox.Text = user.Nombre;
            ClaveTextBox.Text = user.Clave;
            ConfirmaClaveTextBox.Text = user.Clave;
            ActivoCheckBox.Checked = user.Activo;
            EmailTextBox.Text = user.Email;
            FechaIngresoDateTimePicker.Value = user.FechaIngreso;
        }


        private bool EstaEnLaBaseDeDatos()
        {
            Usuarios user = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (user != null);
        }

        private void RegistroUsuarioForm_Load(object sender, EventArgs e)
        {
            RolIdComboBox.DataSource = RolesBLL.GetRoles();
            RolIdComboBox.DisplayMember = "descripcion";
            RolIdComboBox.ValueMember = "rolesId";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios user;
            bool paso = false;

            if (!Validar())
                return;

            user = LlenarClase();

            paso = UsuariosBLL.Guardar(user);

            if (paso)
            {
                MessageBox.Show("Transaccion exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No fue posible guardar o modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool Validar()
        {
            bool paso = true;

            if (ClaveTextBox.Text != ConfirmaClaveTextBox.Text)
            {
                MyErrorProvider.SetError(ClaveTextBox, "Los campos Clave y confrimar Clave no pueden ser diferentes");
                MyErrorProvider.SetError(ConfirmaClaveTextBox, "Los campos Clave y confrimar Clave no pueden ser diferentes");

                ClaveTextBox.Clear();
                ConfirmaClaveTextBox.Clear();

                NombreTextBox.Focus();
                paso = false;
            }

            if (NombreTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El Campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (AliasTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(AliasTextBox, "El Campo alias no puede estar vacio");
                AliasTextBox.Focus();
                paso = false;
            }

            if (ClaveTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(ClaveTextBox, "El Campo Clave no puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            if (ConfirmaClaveTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(ConfirmaClaveTextBox, "El Campo Confirmar Clave no puede estar vacio");
                ConfirmaClaveTextBox.Focus();
                paso = false;
            }

            if (EmailTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(EmailTextBox, "El Campo E-mail Clave no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            if (UsuariosBLL.ExisteAlias(AliasTextBox.Text, (int)UsuarioIdNumericUpDown.Value))
            {
                MyErrorProvider.SetError(AliasTextBox, "El Campo alias ya existe");
                AliasTextBox.Focus();
                AliasTextBox.Clear();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);

            if (EstaEnLaBaseDeDatos())
            {
                MessageBox.Show("Encontrado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampos(user);
            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Eliminar((int)UsuarioIdNumericUpDown.Value))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }
    }
}
