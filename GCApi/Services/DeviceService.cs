using GCApi.Data;
using GCApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Services
{
	public class DeviceService : IDeviceService
	{
		private DeviceContext DeviceContext;
		public DeviceService(DeviceContext DeviceContext)
		{
			this.DeviceContext = DeviceContext;
		}


		public void SaveDevice(DeviceDetail d)
		{
			ComputeDevice cd = null;
			if (d.ComputerType == "Desktop PC")
			{
				cd = this.DeviceContext.DeskTopPcs.Find(d.DeviceModelId);
				if (cd == null)
					cd = new DeskTopPc();
				var desktop = cd as DeskTopPc;

				desktop.DeviceModelId = d.DeviceModelId;
				desktop.DeviceType = DeviceType.DesktopPc;
				desktop.Brand = d.Brand;
				desktop.FormFactor = Models.Enums.FormFactorType.MidTower;
				desktop.Price = d.Price;
				desktop.Processor = d.Processor;
				desktop.Quantity = d.Quantity;
				desktop.RAMSlots = d.RAMSlots;
				desktop.USBPorts = d.USBPorts;


			}
			if (d.ComputerType == "Server")
			{
				cd = this.DeviceContext.DeskTopPcs.Find(d.DeviceModelId);
				if (cd == null)
					cd = new Server();
				var server = cd as Server;

				server.DeviceModelId = d.DeviceModelId;
				server.DeviceType = DeviceType.Server;
				server.Brand = d.Brand;
				server.FormFactor = Models.Enums.FormFactorType.FullTower;
				server.Price = d.Price;
				server.Processor = d.Processor;
				server.Quantity = d.Quantity;
				server.RAMSlots = d.RAMSlots;
				server.USBPorts = d.USBPorts;
			}
			if (d.ComputerType == "Laptop")
			{
				cd = this.DeviceContext.DeskTopPcs.Find(d.DeviceModelId);
				if (cd == null)
					cd = new Laptop()
					{
						DeviceModelId = d.DeviceModelId,
						DeviceType = DeviceType.DesktopPc,
						Brand = d.Brand,
						Price = d.Price,
						Quantity = d.Quantity,
					};
			}
			if (d.ComputerType == "Tablet")
			{
				cd = this.DeviceContext.DeskTopPcs.Find(d.DeviceModelId);
				if (cd == null)
					cd = new Tablet()
					{
						DeviceModelId = d.DeviceModelId,
						DeviceType = DeviceType.DesktopPc,
						Brand = d.Brand,
						Price = d.Price,
						Quantity = d.Quantity,
					};
			}
			if (d.ComputerType == "Phone")
			{
				cd = this.DeviceContext.DeskTopPcs.Find(d.DeviceModelId);
				if (cd == null)
					cd = new Phone()
					{
						DeviceModelId = d.DeviceModelId,
						DeviceType = DeviceType.DesktopPc,
						Brand = d.Brand,
						Price = d.Price,
						Quantity = d.Quantity,
					};
			}

		}
		public List<DeviceDetail> GetDeviceDetailList()
		{
			var list = new List<DeviceDetail>();
			DeviceContext.DeskTopPcs.ToList().ForEach(x => list.Add(new DeviceDetail(x)));
			DeviceContext.Servers.ToList().ForEach(x => list.Add(new DeviceDetail(x)));
			DeviceContext.Laptops.ToList().ForEach(x => list.Add(new DeviceDetail(x)));
			DeviceContext.Tablets.ToList().ForEach(x => list.Add(new DeviceDetail(x)));
			DeviceContext.Phones.ToList().ForEach(x => list.Add(new DeviceDetail(x)));
			return list;
		}
	}
}
