var builder = WebApplication.CreateBuilder(args); //builder
builder.Services.AddRazorPages(); //adiciona suporte a Razor Pages

var app = builder.Build(); //instancia do builder

app.UseHttpsRedirection(); //redireciona para https
app.UseStaticFiles(); //habilita o uso de arquivos estáticos (css, js, imagens) na aplicação

app.UseRouting(); //habilita o roteamento, permitindo que a aplicação responda a diferentes URLs e direcione as requisições para os manipuladores apropriados
app.MapRazorPages(); //mapeia as Razor Pages para as rotas da aplicação

app.Run(); //inicia a aplicação

//Razor é um motor de visualização misturando c# com html(padrão para as views do asp net mvc)
//ASP.NET Razor Pages - forma de estruturar aplicação
//ASP. NET MVC - outra forma de estruturar aplicação, mais complexa.

