using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Registro_De_Permisos.Entidades
{
    public class Permiso
    {

        [Key]
        public int permisoId { get; set; }
        public string descripcion { get; set; }

        public Permiso()
        {
            permisoId = 0;
            descripcion = string.Empty;

        }
    }
}
