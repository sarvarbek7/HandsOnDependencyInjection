using HandsOnDependencyInjection;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddControllers();

		//builder.Services.AddTransient()  -> Har safar so'ralganda yangi instance yaratadi
		//builder.Services.AddScoped();    -> Har bir request/responce cycle uchun yangi instance yaratadi
		//builder.Services.AddSingleton(); -> Bir marta yaratiladi tamom.

		builder.Services.AddScoped<DatabaseMock>();
		builder.Services.AddScoped<IRepositoryMock, RepositoryMock>();
		builder.Services.AddScoped<IMyService, MyService>();

		var app = builder.Build();

		if (app.Environment.IsDevelopment())
		{
			app.UseHttpLogging();
		}
		/////////////////////////////////
		app.MapControllers();

		app.Run();
	}
}

//coder km
//AbuProgrammiy: blmadm 