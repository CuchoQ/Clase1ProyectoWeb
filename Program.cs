var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("Api/Users/", () => {
    var user1 = new User( "Dario","Ochoa");
    var user2 = new User( "Julio","Cesar");
    
    var users = new List <User>();
    users.Add (user1);
    users.Add (user2);
    return users;


});
app.Run();
