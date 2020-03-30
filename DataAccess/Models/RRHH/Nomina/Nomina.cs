using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.RRHH.Nomina
{
public class Nomina
    {

        [Column("ID_LEGAJO")]
        public long ID_LEGAJO { get; set; }

        [Column("APELLIDO")]
        public string APELLIDO { get; set; }

        [Column("NOMBRE")]
        public string NOMBRE { get; set; }

        [Column("F_NACIMIENTO")]
        public DateTime F_NACIMIENTO { get; set; }

        [Column("CUIL")]
        public long CUIL { get; set; }
    }
}
