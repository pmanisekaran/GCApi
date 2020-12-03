namespace GCApi.Models
{
	public interface IComputeDevice
	{
		string Brand { get; set; }
		string DeviceModelId { get; set; }
		DeviceType DeviceType { get; set; }
		decimal Price { get; set; }
		int Quantity { get; set; }
	}
}