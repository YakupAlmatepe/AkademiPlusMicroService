using AkademiPusMicroservice.Catalog.Services.CategoryService;
using AkademiPusMicroservice.Catalog.Services.ProductService;
using AkademiPusMicroservice.Catalog.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;

namespace AkademiPusMicroservice.Catalog
{
    public class Program
    {
        public static void Main(string[] args)

        {
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
			{
				opt.Authority = builder.Configuration["IdentityServerUrl"];
				opt.Audience = "resource_catalog";
				opt.RequireHttpsMetadata = false;
			});
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<ICategoryService, CategoryService>();

			builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
			builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
			builder.Services.AddSingleton<IDatabaseSettings>(sp =>
			{
				return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}



			app.UseHttpsRedirection();
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
    }
}