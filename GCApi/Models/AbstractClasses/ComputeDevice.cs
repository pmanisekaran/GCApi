using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GCApi.Models
{
	public abstract class ComputeDevice : IComputeDevice
	{
		public ComputeDevice()
		{
			this.DeviceModelId = RandomString(5);
		}
		
		
		[Key]
		public string DeviceModelId { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }

		public DeviceType DeviceType { get; set; }

		public int Quantity { get; set; }
		private static Random random = new Random();
		private static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}
	}
}
