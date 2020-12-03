using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Models
{
	public class DeviceDetail : IDeviceDetail
	{

		public DeviceDetail(ComputeDevice computeDevice)
		{
			
						
			Brand = computeDevice.Brand;
			ComputerType = computeDevice.DeviceType.ToString();
			DeviceModelId = computeDevice.DeviceModelId;
			
			OperatingSystem = "N/A";
			OSVersion = "N/A";
			Price = computeDevice.Price;
			
			Quantity = computeDevice.Quantity;
			
			ScreenSize = 0;
			
			if (computeDevice is DeskTopPc )
			{
				var desktop = (computeDevice as DeskTopPc);
				FormFactor = desktop.FormFactor.ToString();
				Processor = desktop.Processor;
				RAMSlots = desktop.RAMSlots;
				USBPorts = desktop.USBPorts;

				ScreenSize = 0;
				OperatingSystem = "N/A";
				OSVersion = "N/A";
			}
			if (computeDevice is Laptop)
			{
				ScreenSize = (computeDevice as Laptop).ScreenSize;
				OperatingSystem = (computeDevice as Laptop).OperatingSystem.ToString();
				OSVersion = (computeDevice as Laptop).OSVersion;
			}


		}


		public string DeviceModelId { get; set; }
		public string ComputerType { get; set; }
		public string Processor { get; set; }
		public string Brand { get; set; }
		public int USBPorts { get; set; }
		public int RAMSlots { get; set; }
		public string FormFactor { get; set; }
		public int Quantity { get; set; }
		public int ScreenSize { get; set; }
		public decimal Price { get; set; }
		public string OperatingSystem { get; set; }
		public string OSVersion { get; set; }
	}
}
