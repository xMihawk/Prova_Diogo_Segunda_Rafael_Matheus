using rafaelaloncofoggiatto.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();


//cadastrar
app.MapPost("/rafaelaloncofoggiatto/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDbContext ctx) =>

{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
});

//listar
app.MapGet("/rafaelaloncofoggiatto/funcionario/listar", ([FromServices] AppDbContext ctx) =>

{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
});

//folha cadastrar
app.MapPost("/rafaelaloncofoggiatto/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDbContext ctx) =>

{
    // if (folha.funcionario == null)
    // {
    //     return Results.NotFound();
    // }
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);

});

//listar folhas
app.MapGet("/rafaelaloncofoggiatto/folha/listar", ([FromServices] AppDbContext ctx) =>

{
    if (ctx.Folhas.Any())
    {
        return Results.Ok(ctx.Folhas.ToList());
    }
    return Results.NotFound();
});

//buscar folhas
app.MapGet("/rafaelaloncofoggiatto/folha/buscar/{cpf}/{mes}/{ano}", ([FromRoute] string cpf, int mes, int ano, [FromBody] Folha folha, [FromServices] AppDbContext ctx) =>

{
    Folha? folha1 = ctx.Folhas.Find(cpf, mes, ano);
    if (folha1 is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(ctx.Folhas.ToList());

});


app.MapGet("/", () => "provadiogo");

app.Run();
