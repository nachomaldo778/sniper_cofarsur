using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.RRHH.Novedades
{

    //A.sector,
    //     A.legajo,
    //     A.apellido,
    //     A.nombre,
    //     A.fecha,
    //     A.jornadas,
    //     A.marcaciones,
    //     A.hs_trabajadas,
    //     A.incidencias,
    //     A.anomalias,
    //     A.controles,
    //     A.permisos

    public class ParteDiario
    {
        [Column("SECTOR")]
        public string SECTOR { get; set; }

        [Column("LEGAJO")]
        public long LEGAJO { get; set; }

        [Column("APELLIDO")]
        public string APELLIDO { get; set; }

        [Column("NOMBRE")]
        public string NOMBRE { get; set; }

        [Column("FECHA")]
        public DateTime FECHA { get; set; }

        [Column("JORNADAS")]
        public string JORNADAS { get; set; }

        [Column("MARCACIONES")]
        public string MARCACIONES { get; set; }

        [Column("HS_TRABAJADAS")]
        public long HS_TRABAJADAS { get; set; }
    }
}
