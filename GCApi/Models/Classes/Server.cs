using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Models
{
	public class Server : DeskTopPc
	{

		public Server() : base()
		{

			this.DeviceType = DeviceType.Server;
		}
	}
}
