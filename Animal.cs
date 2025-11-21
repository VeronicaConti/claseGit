public class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido que hace el animal:");
    }
}
