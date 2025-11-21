using System;
using System.Collections.Generic;

public class Gerente : Empleado
{
    public double Bono { get; set; }

    public Gerente(string nombre, string cargo, double sueldo, double bono)
        : base(nombre, cargo, sueldo)
    {
        Bono = bono;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Gerente: {Nombre}, Cargo: {Cargo}, Sueldo: {Sueldo}, Bono: {Bono}");
    }


    public void MostrarEquipo()
    {
        List<Empleado> equipo = new List<Empleado>
        {
            new Empleado("Juan", "Diseñador", 120000),
            new Gerente("Ana", "Jefa de Proyecto", 180000, 30000)
        };

        foreach (Empleado emp in equipo)
        {
            emp.MostrarInfo();
        }
    }
}
