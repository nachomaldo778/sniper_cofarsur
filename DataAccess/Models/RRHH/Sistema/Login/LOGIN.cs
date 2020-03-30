using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.RRHH.Sistema.Login
{
    public class LOGIN
    {
        [Column("P_ID")]
        public long P_ID { get; set; }

        //[Column("ERROR")]
        //public string ERROR { get; set; }
    }
}
