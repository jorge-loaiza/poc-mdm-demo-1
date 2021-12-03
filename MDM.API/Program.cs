using MDM.Application;
using MDM.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDocumentService, DocumentService>();
builder.Services.AddTransient<IDocumentContainerService, DocumentContainerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/documents", (IDocumentService documentsService) => documentsService.GetDocuments());
app.MapPost("/documents", async (CreateDocumentRequest request, IDocumentService documentsService) => await documentsService.CreateDocument(request));
app.MapGet("/documents/container", (IDocumentContainerService documentContainerService) => documentContainerService.GetDocumentContainer());
app.MapGet("/documents/container/types", (IDocumentContainerService documentContainerService) => documentContainerService.GetContainerTypes());


app.Run();