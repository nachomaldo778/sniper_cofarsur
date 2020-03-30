using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.RRHH.Novedades
{
   public class Novedades
    {

            [Column("ID_LEGAJO")]
            public long ID_LEGAJO { get; set; }
            [Column("APELLIDO")]
            public string APELLIDO { get; set; }
            [Column("NOMBRE")]
            public string NOMBRE { get; set; }
            [Column("ID_JORNADA")]
            public long ID_JORNADA { get; set; }

        [Column("N_JORNADA")]
        public string N_JORNADA { get; set; }
        [Column("ID_INCIDENCIA")]
        public long ID_INCIDENCIA { get; set; }
        [Column("N_INCIDENCIA")]
        public string N_INCIDENCIA { get; set; }
        [Column("MARCACIONES")]
        public string MARCACIONES { get; set; }
        [Column("H_TEORICAS")]
        public decimal H_TEORICAS { get; set; }
        [Column("H_TRABAJADAS")]
        public decimal H_TRABAJADAS { get; set; }
        [Column("I_IMPARES")]
        public long I_IMPARES { get; set; }
        [Column("I_SIN_INCIDENCIAS")]
        public long I_SIN_INCIDENCIAS { get; set; }
        [Column("H_ADICIONALES")]
        public decimal H_ADICIONALES { get; set; }
        [Column("H_AUSENCIA")]
        public decimal H_AUSENCIA { get; set; }


    }
}
