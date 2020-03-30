using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.Test
{
	public class Cmb
	{
		[Column("id")]
		public long Id { get; set; }

		[Column("nombre")]
		public string Nombre { get; set; }

	}
}
