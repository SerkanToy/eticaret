using eticaret.Domain.Database.Context;
using eticaret.Domain.Extensions;
using eticaret.Models.MailMessageSend;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration"));

builder.Services.AddDbContext<CommerceContext>();
builder.Services.AddServerSideBlazor();

builder.Services.IdentityAdd();
builder.Services.PolicyAdd();

builder.Services.TransientAdd();
builder.Services.ScopedAdd();

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
app.MapRazorPages()
   .WithStaticAssets();

app.MapBlazorHub();
//app.MapRazorComponents<NavbarComponent>();

app.Run();
