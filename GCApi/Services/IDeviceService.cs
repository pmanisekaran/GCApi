using GCApi.Models;
using System.Collections.Generic;

namespace GCApi.Services
{
	public interface IDeviceService
	{
		List<DeviceDetail> GetDeviceDetailList();
		void SaveDevice(DeviceDetail value);
	}
}