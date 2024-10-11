using Libarary.Domain.Contract;

namespace Library.Apis.Extention
{
    public static class IntializerExtention
    {
        public async static Task<WebApplication> IntalizerContextApplicationAsync(this WebApplication web)
        {
            using var scope = web.Services.CreateAsyncScope();

            var service = scope.ServiceProvider;
            var ApplicationContextINtializer = service.GetRequiredService<IApplicationContextIntializer>();
            var LoggerFactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
                await ApplicationContextINtializer.UpdateDatabaseAsync();
            }
            catch (Exception ex)
            {

                var logger = LoggerFactory.CreateLogger<Program>();
                logger.LogError(string.Empty, "An Error during Migrate");

                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }

            return web;
        }
    }
}
