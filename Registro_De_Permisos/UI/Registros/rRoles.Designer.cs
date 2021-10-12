
namespace Registro_De_Permisos.UI.Registros
{
    partial class rRolesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRolesForm));
            this.IdRolesLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.IdRolesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RolesDetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RolesDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EsAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.EsActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdRolesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.RolesDetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IdRolesLabel
            // 
            this.IdRolesLabel.AutoSize = true;
            this.IdRolesLabel.Location = new System.Drawing.Point(17, 14);
            this.IdRolesLabel.Name = "IdRolesLabel";
            this.IdRolesLabel.Size = new System.Drawing.Size(18, 15);
            this.IdRolesLabel.TabIndex = 0;
            this.IdRolesLabel.Text = "ID";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(17, 46);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Location = new System.Drawing.Point(16, 78);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(105, 15);
            this.FechaCreacionLabel.TabIndex = 2;
            this.FechaCreacionLabel.Text = "Fecha De Creacion";
            // 
            // IdRolesNumericUpDown
            // 
            this.IdRolesNumericUpDown.Location = new System.Drawing.Point(133, 12);
            this.IdRolesNumericUpDown.Name = "IdRolesNumericUpDown";
            this.IdRolesNumericUpDown.Size = new System.Drawing.Size(40, 23);
            this.IdRolesNumericUpDown.TabIndex = 4;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(134, 43);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(227, 23);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // FechaCreacionDateTimePicker
            // 
            this.FechaCreacionDateTimePicker.CustomFormat = "dd/mm/yyyy";
            this.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCreacionDateTimePicker.Location = new System.Drawing.Point(134, 72);
            this.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            this.FechaCreacionDateTimePicker.Size = new System.Drawing.Size(86, 23);
            this.FechaCreacionDateTimePicker.TabIndex = 6;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(114, 415);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(65, 40);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(185, 415);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(66, 40);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(257, 415);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(65, 40);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(179, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(26, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RolesDetalleGroupBox
            // 
            this.RolesDetalleGroupBox.Controls.Add(this.PermisoIdComboBox);
            this.RolesDetalleGroupBox.Controls.Add(this.PermisoIdLabel);
            this.RolesDetalleGroupBox.Controls.Add(this.EsAsignadoCheckBox);
            this.RolesDetalleGroupBox.Controls.Add(this.AgregarButton);
            this.RolesDetalleGroupBox.Controls.Add(this.RemoverButton);
            this.RolesDetalleGroupBox.Controls.Add(this.RolesDetalleDataGridView);
            this.RolesDetalleGroupBox.Location = new System.Drawing.Point(16, 117);
            this.RolesDetalleGroupBox.Name = "RolesDetalleGroupBox";
            this.RolesDetalleGroupBox.Size = new System.Drawing.Size(427, 279);
            this.RolesDetalleGroupBox.TabIndex = 11;
            this.RolesDetalleGroupBox.TabStop = false;
            this.RolesDetalleGroupBox.Text = "Roles A Detalle";
            // 
            // RolesDetalleDataGridView
            // 
            this.RolesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDetalleDataGridView.Location = new System.Drawing.Point(12, 85);
            this.RolesDetalleDataGridView.Name = "RolesDetalleDataGridView";
            this.RolesDetalleDataGridView.RowTemplate.Height = 25;
            this.RolesDetalleDataGridView.Size = new System.Drawing.Size(398, 150);
            this.RolesDetalleDataGridView.TabIndex = 0;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(12, 241);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(80, 23);
            this.RemoverButton.TabIndex = 1;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(330, 37);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(80, 23);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EsAsignadoCheckBox
            // 
            this.EsAsignadoCheckBox.AutoSize = true;
            this.EsAsignadoCheckBox.Location = new System.Drawing.Point(12, 28);
            this.EsAsignadoCheckBox.Name = "EsAsignadoCheckBox";
            this.EsAsignadoCheckBox.Size = new System.Drawing.Size(100, 19);
            this.EsAsignadoCheckBox.TabIndex = 3;
            this.EsAsignadoCheckBox.Text = "Esta Asignado";
            this.EsAsignadoCheckBox.UseVisualStyleBackColor = true;
            this.EsAsignadoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EsActivoCheckBox
            // 
            this.EsActivoCheckBox.AutoSize = true;
            this.EsActivoCheckBox.Location = new System.Drawing.Point(278, 15);
            this.EsActivoCheckBox.Name = "EsActivoCheckBox";
            this.EsActivoCheckBox.Size = new System.Drawing.Size(84, 19);
            this.EsActivoCheckBox.TabIndex = 12;
            this.EsActivoCheckBox.Text = "Esta Activo";
            this.EsActivoCheckBox.UseVisualStyleBackColor = true;
            this.EsActivoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Location = new System.Drawing.Point(12, 56);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(55, 15);
            this.PermisoIdLabel.TabIndex = 4;
            this.PermisoIdLabel.Text = "Permisos";
            this.PermisoIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(73, 53);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(162, 23);
            this.PermisoIdComboBox.TabIndex = 5;
            // 
            // rRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 467);
            this.Controls.Add(this.EsActivoCheckBox);
            this.Controls.Add(this.RolesDetalleGroupBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.FechaCreacionDateTimePicker);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdRolesNumericUpDown);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdRolesLabel);
            this.MaximizeBox = false;
            this.Name = "rRolesForm";
            this.Text = "Registro De Roles";
            this.Load += new System.EventHandler(this.RegistroRolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdRolesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.RolesDetalleGroupBox.ResumeLayout(false);
            this.RolesDetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdRolesLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.NumericUpDown IdRolesNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimePicker;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox RolesDetalleGroupBox;
        private System.Windows.Forms.CheckBox EsAsignadoCheckBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView RolesDetalleDataGridView;
        private System.Windows.Forms.CheckBox EsActivoCheckBox;
        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdLabel;
    }
}