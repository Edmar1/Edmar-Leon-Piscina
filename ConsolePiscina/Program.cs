// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Piscinas
{
    public int Id;
    public string? Nombre;
    public Socorristas? SocorristaAsignado; // Socorrista asignado a la piscina
}

public class Socorristas
{
    public int Id;
    public string? Nombre;
    public int Edad;
    public string? Turno;
}

public class Clientes
{
    public int Id;
    public string? Nombre;
    public int Edad;
}

public class Reservas
{
    public List<Clientes> Clientes; // Lista de clientes en la reserva
    public Piscinas Piscina; // Piscina asociada a la reserva
    public int Id;
    public DateTime Fecha;
    public int DuracionHoras;
}