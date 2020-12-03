using System;

namespace GCApi.Models
{
	public interface IDeviceDetail
	{
		string DeviceModelId{get;set;}
		string ComputerType{get;set;}
		string Processor{get;set;}
		string Brand{get;set;}
		int USBPorts{get;set;}
		int RAMSlots{get;set;}
		string FormFactor{get;set;}//Full tower, mid-tower, and mini-ITX
		int Quantity{get;set;}
		int ScreenSize{get;set;}
		decimal Price{get;set;}
		string OperatingSystem{get;set;}
		string OSVersion{get;set;}
	}
}
