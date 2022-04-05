using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Detalle_A_E
    {
        public int Id { get; set; }
        public Empleado empleado { get; set; }
        public Activo activo { get; set; }
        public long DateInicio { get; set; }

    }
}
