class User
{
   public String Nombre { get; set;}
   public String Apellido { get; set;}

public User(String nombre, String apellido  )
{   
    Nombre = nombre;
    Apellido=apellido;    
}

public String Fullname()
{
    return $"{Nombre} {Apellido}";
}

}