using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Models
{
	public class Tablet : Laptop
	{
		public Tablet() : base()
		{ this.DeviceType = DeviceType.Tablet; }
	}
}
