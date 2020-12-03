using GCApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GCApi.Services;

namespace GCApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddCors(options =>
			{
				options.AddPolicy(name: "MyAllowSpecificOrigins",
								  builder =>
								  {
									  builder.WithOrigins("http://localhost:4200", "http://localhost:4200/device");
								  });
			});
			services.AddControllers();
			services.AddDbContext<DeviceContext>(o => o.UseInMemoryDatabase(databaseName: "GCData"));
			services.AddTransient<IDeviceService, DeviceService>();
			



		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{


			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseCors("MyAllowSpecificOrigins");
			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
