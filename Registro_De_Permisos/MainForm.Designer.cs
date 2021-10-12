
namespace Registro_De_Permisos
{
    partial class MenuForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EditarToolStripMenuItem,
            this.RegistroToolStripMenuItem,
            this.ConsultaToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(757, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // EditarToolStripMenuItem
            // 
            this.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem";
            this.EditarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.EditarToolStripMenuItem.Text = "&Editar";
            // 
            // RegistroToolStripMenuItem
            // 
            this.RegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem,
            this.RolesToolStripMenuItem,
            this.PermisosToolStripMenuItem});
            this.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem";
            this.RegistroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.RegistroToolStripMenuItem.Text = "&Registro";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.UsuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // RolesToolStripMenuItem
            // 
            this.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem";
            this.RolesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.RolesToolStripMenuItem.Text = "&Roles";
            // 
            // PermisosToolStripMenuItem
            // 
            this.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem";
            this.PermisosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.PermisosToolStripMenuItem.Text = "&Permisos";
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ConsultaToolStripMenuItem.Text = "&Consulta";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AyudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 473);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PermisosToolStripMenuItem;
    }
}