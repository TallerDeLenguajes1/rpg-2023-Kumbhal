namespace Personaje{

public class personaje{
    private string? tipo;
    private string? nombre;
    private DateTime fechadenac;
    private string? apodo;
    private int edad; //Entre 0 a 300
    private int velocidad; //Del 1 al 10
    private int destreza; //Del 1 al 5
    private int fuerza; //Del 1 al 10
    private int nivel; //Del 1 al 10
    private int salud; //Siempre comienza con 100
    private int armadura; //Del 1 al 100
    public string? Tipo{get => tipo; set => tipo = value;}
    public string? Nombre{get => nombre; set => nombre = value;}
    public DateTime FechaDeNac{get => fechadenac; set => fechadenac = value;}
    public int Edad{get => edad; set => edad = value;}
    public int Velocidad{get => velocidad; set => velocidad = value;}
    public int Destreza{get => destreza; set => destreza = value;}
    public int Fuerza{get => fuerza; set => fuerza = value;}
    public int Nivel{get => nivel; set => nivel = value;}
    public int Armadura{get => armadura; set => armadura = value;}
    public int Salud{get => salud; set => salud = value;}

}

public class FabricaDePersonajes{
    public personaje generarPersonaje(){
        personaje nuevo = new personaje();
        nuevo.Tipo = "Humano";
        nuevo.Nombre = "Jose";
        Random NumeroRandom = new Random();
        int dia = NumeroRandom.Next(1,31);
        int mes = NumeroRandom.Next(1,13);
        nuevo.Nivel = NumeroRandom.Next(0, 11);
        nuevo.Fuerza = NumeroRandom.Next(0, 11);
        nuevo.Armadura = NumeroRandom.Next(0, 11);
        nuevo.Destreza = NumeroRandom.Next(0, 11);
        nuevo.Velocidad = NumeroRandom.Next(0, 11);
        nuevo.Edad = NumeroRandom.Next(0, 301);
        int anio = DateTime.Now.Year - nuevo.Edad;
        nuevo.FechaDeNac = new DateTime(anio, mes, dia);
        return nuevo;
        }
    }
}