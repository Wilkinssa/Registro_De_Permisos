using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_De_Permisos.Entidades
{
    public class RolesDetalle
    {
        public int id { get; set; }
        public int Rolid { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }
        
        public RolesDetalle()
        {
            id = 0;
            Rolid = 0;
            PermisoId = 0;
            esAsignado = false;
        }

        public RolesDetalle(int id, int Rolid, int PermisoId, bool esAsignado)
        {
            this.id = id;
            this.Rolid = Rolid;
            this.PermisoId = PermisoId;
            this.esAsignado = esAsignado;
        }
    }
}
