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
		//Console.WriteLine("Tohirjon Odilov");

		builder.Services.AddScoped<DatabaseMock>();
		builder.Services
			.AddKeyedScoped<IRepositoryMock, RepositoryMockElyor>(ServiceKeys.Elyor)
			.AddKeyedScoped<IRepositoryMock, RepositoryMockTohirjon>(ServiceKeys.Tohirjon);

		builder.Services.AddScoped<IMyService, MyService>();

		var app = builder.Build();


		app.MapControllers();

		app.Run();
	}
}