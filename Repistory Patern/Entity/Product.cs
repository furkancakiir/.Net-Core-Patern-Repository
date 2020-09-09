using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repistory_Patern.Entity
{
	public class Product:IEntity
	{
		
		public string Name { get; set; }
		public double price { get; set; }
		public int id { get; set; }
	}
}
