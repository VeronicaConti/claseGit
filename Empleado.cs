public class Empleado
{
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public double Sueldo { get; set; }

    public Empleado(string nombre, string cargo, double sueldo)
    {
        Nombre = nombre;
        Cargo = cargo;
        Sueldo = sueldo;
    }

    public double CalcularBono(double porcentaje)
    {
        return Sueldo * (porcentaje / 100);
    }
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Empleado: {Nombre}, Cargo: {Cargo}, Sueldo: {Sueldo}");
    }
}
