using GCApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Models
{
	public class Laptop : ComputeDevice
	{
		public Laptop() : base()
		{ this.DeviceType = DeviceType.Laptop; }
		public int ScreenSize { get; set; }
		public OperatingSystemType OperatingSystem { get; set; }
		public string OSVersion { get; set; }
	}
}
