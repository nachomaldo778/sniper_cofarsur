using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.Vialidad.Expediente_Electrónico
{
    public class PASOS
    {

[Column("AMBIENTE")]
public string AMBIENTE { get; set; }
[Column("ID_PASO")]
public long ID_PASO { get; set; }
[Column("N_PASO")]
public string N_PASO { get; set; }
[Column("ID_SUBPROCESO")]
public long ID_SUBPROCESO { get; set; }
[Column("ID_PASO_SUCESOR_OK")]
public long ID_PASO_SUCESOR_OK { get; set; }
[Column("ID_PASO_SUCESOR_REC")]
public long ID_PASO_SUCESOR_REC { get; set; }
[Column("ID_PROCEDIMIENTO")]
public long ID_PROCEDIMIENTO { get; set; }
[Column("ID_ROL")]
public long ID_ROL { get; set; }
[Column("NRO_SECUENCIA")]
public long NRO_SECUENCIA { get; set; }
[Column("DETALLE")]
public string DETALLE { get; set; }
[Column("ID_CONFIGURACION_ARCHIVO")]
public long ID_CONFIGURACION_ARCHIVO { get; set; }
[Column("ID_TIPO_ARCHIVO")]
public long ID_TIPO_ARCHIVO { get; set; }
[Column("ID_PASO_PREVIO")]
public long ID_PASO_PREVIO { get; set; }
[Column("ID_ROL_FIRMANTE")]
public long ID_ROL_FIRMANTE { get; set; }
[Column("N_TIPO_ARCHIVO")]
public string N_TIPO_ARCHIVO { get; set; }
[Column("ID_CATALOGO_CDD")]
public long ID_CATALOGO_CDD { get; set; }
[Column("ID_TIPO_OPERACION")]
public decimal ID_TIPO_OPERACION { get; set; }
[Column("N_TIPO_OPERACION")]
public string N_TIPO_OPERACION { get; set; }

    }
}
