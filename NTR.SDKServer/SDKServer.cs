using System.Reflection;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;

namespace NTR.SDKServer
{
    public class SDKServer
    {
        public static void Main(string[] args)
        {
            Log.Information("Starting SDK Server...");
            try
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.Configure<KestrelServerOptions>(op =>
                    op.AllowSynchronousIO = true
                );
                builder.Host.UseSerilog();

                builder.Services.AddControllers();
                builder.Services.AddControllers().AddApplicationPart(Assembly.GetAssembly(typeof(SDKServer)));

                var app = builder.Build();

                app.UseAuthorization();
                app.UseSerilogRequestLogging();

                app.MapControllers();
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled exception occurred during runtime");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
