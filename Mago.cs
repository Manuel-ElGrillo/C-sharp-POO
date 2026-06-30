public class Mago : Personaje
{
    public int PuntosDeMana { get; set; }

    public Mago (string nombre, int puntosDeVidaMaximos, int puntosDeMana)
        : base (nombre, puntosDeVidaMaximos)
    {
        PuntosDeMana = puntosDeMana;
    }

    public override void Atacar()
    {
        if(PuntosDeMana >= 10)
        {
            PuntosDeMana -= 10;
            Console.WriteLine($"{Nombre} lanza Bola de Fuego. Puntos de maná restantes: {PuntosDeMana}");
        }
        else 
        {
            Console.WriteLine("Maná insuficiente.");
        }
    }
}