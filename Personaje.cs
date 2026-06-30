public class Personaje
{
    // Campo privado, solo esta clase puede modificarlo directamente
    protected int puntosDeVidaActuales; // protected para que las clases hijas puedan tocar los puntos de vida

    // Propiedades públicas, la forma "correcta" de exponer datos hacia afuera de la clase
    public string Nombre { get; set; }
    public int PuntosDeVidaMaximos { get; set; }

    // Función Constructor: se ejecuta una sola vez cuando  creamos el objeto con new
    public Personaje(string nombre, int puntosDeVidaMaximos)
    {
        Nombre = nombre;
        PuntosDeVidaMaximos = puntosDeVidaMaximos;
        puntosDeVidaActuales = puntosDeVidaMaximos; // Arranca con la vida al maximo
    }

    public void RecibirDanio(int cantidadDeDanio)
    {
        puntosDeVidaActuales -= cantidadDeDanio;

        if (puntosDeVidaActuales < 0)
        {
            puntosDeVidaActuales = 0;
        }

        Console.WriteLine($"{Nombre} -> recibió {cantidadDeDanio} de daño. Vida actual {puntosDeVidaActuales}/{PuntosDeVidaMaximos}");
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"{Nombre} -> {puntosDeVidaActuales}/{PuntosDeVidaMaximos} HP");
    }

    public virtual void Atacar () 
    {
        Console.WriteLine($"{Nombre} ataca de forma genérica.");
    }
}