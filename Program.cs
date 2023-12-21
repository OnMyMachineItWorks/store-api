var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS-FOR-UI-APPLICATION",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:8080");
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Middleware 
app.UseRouting();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.UseCors("CORS-FOR-UI-APPLICATION");

app.Run();
