using eticaret.Domain.Database.Context;
using eticaret.Domain.Extensions;
using eticaret.Models.MailMessageSend;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration"));

builder.Services.AddDbContext<CommerceContext>();
builder.Services.AddServerSideBlazor()
    .AddInteractiveServerComponents();

builder.Services.IdentityAdd();
builder.Services.PolicyAdd();

builder.Services.TransientAdd();
builder.Services.ScopedAdd();

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

app.MapBlazorHub();
//app.MapRazorComponents<ProactionsComponent>().AddInteractiveServerRenderMode(o => o.DisableWebSocketCompression = true);
//app.MapRazorComponents<NewsletterComponent>().AddInteractiveServerRenderMode(o => o.DisableWebSocketCompression = true);

app.Run();
