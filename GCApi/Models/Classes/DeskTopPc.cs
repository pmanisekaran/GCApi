using GCApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Models
{
	public class DeskTopPc : ComputeDevice
	{

		public DeskTopPc() : base()
		{
			this.DeviceType = DeviceType.DesktopPc;
		}
		public FormFactorType FormFactor { get; set; }
		public string Processor { get; set; }
		public int USBPorts { get; set; }
		public int RAMSlots { get; set; }
		
	}
}
