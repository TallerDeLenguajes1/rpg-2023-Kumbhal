using Personaje;

personaje nuevo;
FabricaDePersonajes fp = new FabricaDePersonajes();
nuevo = fp.generarPersonaje();
Console.WriteLine(nuevo.FechaDeNac);
Console.WriteLine(nuevo.Edad);