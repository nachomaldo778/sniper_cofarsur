using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.Vialidad.Expediente_Electrónico
{
    public class INSTANCIAS
    {
        [Column("ID_INSTANCIA")]
        public long ID_INSTANCIA { get; set; }

        [Column("ID_SUBPROCESO")]
        public decimal ID_SUBPROCESO { get; set; }

        [Column("ID_PASO")]
        public long ID_PASO { get; set; }

        [Column("N_PASO")]
        public string N_PASO { get; set; }

        [Column("ID_PASO_SUCESOR_OK")]
        public decimal ID_PASO_SUCESOR_OK { get; set; }

        [Column("ID_ESTADO")]
        public long ID_ESTADO { get; set; }

        [Column("ID_ROL")]
        public decimal ID_ROL { get; set; }

        [Column("N_ROL")]
        public string N_ROL { get; set; }

        [Column("ID_PROCEDIMIENTO")]
        public decimal ID_PROCEDIMIENTO { get; set; }

        [Column("N_PROCEDIMIENTO")]
        public string N_PROCEDIMIENTO { get; set; }

        [Column("NRO_SECUENCIA")]
        public decimal NRO_SECUENCIA { get; set; }

    }
}
