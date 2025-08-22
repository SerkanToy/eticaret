using eticaret.Domain.Database.Context;
using eticaret.Domain.Extensions;
using eticaret.Hubs;
using eticaret.Models.MailMessageSend;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration"));

builder.Services.AddDbContext<CommerceContext>();
builder.Services.AddServerSideBlazor()
    .AddInteractiveServerComponents().AddInteractiveWebAssemblyComponents();


builder.Services.IdentityAdd();
builder.Services.PolicyAdd();

builder.Services.TransientAdd();
builder.Services.ScopedAdd();
builder.Services.AddSignalR();
/*builder.Services.AddSignalR()
    .AddHubOptions<eticaret.Hubs.BasketCountHub>(options =>
    {
        //options.EnableDetailedErrors = true;
        //options.MaximumReceiveMessageSize = 2048 * 2048; // 2MB
        options.MaximumReceiveMessageSize = null; // no limit or use a number
    });*/

builder.Services.Configure<HubOptions>(options =>
{
    //options.MaximumReceiveMessageSize = 2048 * 2048;
    options.MaximumReceiveMessageSize = null; // no limit or use a number
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.MapHub<WebHub>("/WebHub");
app.MapBlazorHub();
//app.MapRazorComponents<ProactionsComponent>().AddInteractiveServerRenderMode(o => o.DisableWebSocketCompression = true);
//app.MapRazorComponents<NewsletterComponent>().AddInteractiveServerRenderMode(o => o.DisableWebSocketCompression = true);

app.Run();
