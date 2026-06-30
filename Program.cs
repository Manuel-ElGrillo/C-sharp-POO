Personaje heroe  = new Personaje ("Lyra", 100);

heroe.MostrarEstado();
heroe.RecibirDanio(30);
heroe.RecibirDanio(50);
heroe.MostrarEstado();

Guerrero guerrero =  new Guerrero ("Thorin", 120, 15);
Mago mago = new Mago ("Elara", 80, 50);

guerrero.MostrarEstado();
mago.MostrarEstado();

Console.WriteLine();

// Enlista los tipos de Personaje y contiene los objetos de tipo Guerrero y Mago
// Polimorfismo acá: se tratan distinto a  los tipos a través de su tipo base

List<Personaje> equipo = new List<Personaje> { guerrero, mago };

foreach (Personaje pj in equipo)
{
    pj.Atacar(); // Cada uno ejecuta su propia versión de Atacar
}

Console.WriteLine();

guerrero.RecibirDanio(40);
guerrero.MostrarEstado();