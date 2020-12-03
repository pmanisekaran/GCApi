using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCApi.Data;
using GCApi.Models;
using GCApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GCApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class DeviceController : ControllerBase
	{
		private IDeviceService DeviceService;

		public DeviceController(IDeviceService DeviceService)
		{
			this.DeviceService = DeviceService;
		}
		// GET: api/<ValuesController>
		[HttpGet]
		public List<DeviceDetail> Get()
		{

			return DeviceService.GetDeviceDetailList(); ; 
		}

		// GET api/<ValuesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ValuesController>
		[HttpPost]
		public void Post([FromBody] DeviceDetail value)
		{

			this.DeviceService.SaveDevice(value);
		}

		// PUT api/<ValuesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
