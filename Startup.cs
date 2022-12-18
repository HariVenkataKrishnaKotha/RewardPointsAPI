using Microsoft.AspNetCore.Builder;

namespace RewardPointsAPI
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            } // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
