public class Guerrero : Personaje 
{
    public int Armadura { get; set; }

    //base (nombre, puntosDeVidaMaximos) llama al constructor de Personaje primero
    // Es obligatorio: la clase padre necesita inicializarse antes que la hija

    public Guerrero (string nombre, int puntosDeVidaMaximos, int armadura)
        : base (nombre, puntosDeVidaMaximos)
    {
        Armadura = armadura;
    }

    // override: reemplaza el comportamiento del método Atacar que viene de la clase Personaje
    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca.(armadura {Armadura}).");
    }
}