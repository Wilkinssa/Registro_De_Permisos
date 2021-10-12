using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registro_De_Permisos.Entidades
{
    public class Roles
    {
        [Key]
        public int rolesId { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool esActivo { get; set; }

        [ForeignKey("rolesId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }

        public Roles()
        {
            rolesId = 0;
            fechaCreacion = DateTime.Now;
            descripcion = string.Empty;
            esActivo = false;

            RolesDetalle = new List<RolesDetalle>();
        }

    }
}
