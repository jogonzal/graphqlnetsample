using DataRepositories.Database;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLSample.GraphQLUtils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLSample
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
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			var builder = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.AddJsonFile("appSettingsProd.json", true)
				.AddEnvironmentVariables();

			var config = builder.Build();
			var connstr = config.GetConnectionString("(default)");

			services.AddDbContext<EtisysContext>(options =>
			{
				options.UseSqlServer(connstr);
			});
			services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
			services.AddSingleton<GraphQLSampleQuery>();
			services.AddSingleton<GraphQLSampleMutation>();
			services.AddSingleton<AgenteType>();
			services.AddSingleton<ProveedorType>();
			services.AddSingleton<CuentaGastoType>();
			services.AddSingleton<AgenteInputType>();
			var sp = services.BuildServiceProvider();
			services.AddSingleton<ISchema>(new GraphQLSampleSchema(new FuncDependencyResolver(type => sp.GetService(type))));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDeveloperExceptionPage();

			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//}
			//else
			//{
			//	app.UseHsts();
			//}

			app.UseGraphiQl();
			app.UseHttpsRedirection();
			app.UseMvc(routes =>
			{
				routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

				routes.MapSpaFallbackRoute(
					name: "spa-fallback",
					defaults: new { controller = "Home", action = "Index" });
			});
		}
	}
}
