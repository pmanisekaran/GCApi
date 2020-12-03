using GCApi.Models;
using GCApi.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCApi.Data
{
	public class DeviceContext : DbContext
	{
		// Constructors

		static string[] Keys = new[] { "DES-PC1", "SERVER-2W", "LAPTOP-2w", "TAB-13INCH","PH-TXC" };
		public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
		{




			if (this.DeskTopPcs.Find(Keys[0]) == null)
				this.DeskTopPcs.Add(new DeskTopPc() { DeviceModelId = Keys[0], Brand = "Dell", DeviceType = DeviceType.DesktopPc, Price = 99999, Processor = "Intel", Quantity = 99, RAMSlots = 4, USBPorts = 3, FormFactor = FormFactorType.MidTower });
			if (this.Servers.Find(Keys[1]) == null)
				this.Servers.Add(new Server() { DeviceModelId = Keys[1], Brand = "IBM", DeviceType = DeviceType.Server, Price = 19999, Processor = "Intel", Quantity = 12, RAMSlots = 4, USBPorts = 3, FormFactor = FormFactorType.MidTower });

			if (this.Laptops.Find(Keys[2]) == null)
				this.Laptops.Add(new Laptop()
				{
					DeviceModelId = Keys[2],
					Brand = "Sony",
					DeviceType = DeviceType.Laptop,
					Price = 3999,
					Quantity = 339,
					OperatingSystem = OperatingSystemType.Windows,
					OSVersion = "iOS13",
					ScreenSize = 13
				});
			if (this.Tablets.Find(Keys[3]) == null)
				this.Tablets.Add(new Tablet() { DeviceModelId = Keys[3], Brand = "Apple", DeviceType = DeviceType.DesktopPc, Price = 1999, Quantity = 99, OperatingSystem = OperatingSystemType.Mac, ScreenSize = 15, OSVersion = "Android 12" });
			if (this.Phones.Find(Keys[4]) == null)
				this.Phones.Add(new Phone()
				{
					DeviceModelId = Keys[4],
					Brand = "Samsung",
					DeviceType = DeviceType.DesktopPc,
					Price = 1200,
					Quantity = 99,
					OperatingSystem = OperatingSystemType.Mac,
					ScreenSize = 15,
					OSVersion = "Android 12"});

			//this.Servers.Add(new Server());
			//this.Phones.Add(new Phone());
			//this.Tablets.Add(new Tablet());
			//this.Laptops.Add(new Tablet());
			this.SaveChanges();



		}

		

		public DbSet<DeskTopPc> DeskTopPcs { get; set; }

		public DbSet<Laptop> Laptops { get; set; }

		public DbSet<Phone> Phones { get; set; }

		public DbSet<Server> Servers { get; set; }
		public DbSet<Tablet> Tablets { get; set; }

	}
}
