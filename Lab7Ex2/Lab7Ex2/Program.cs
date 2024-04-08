// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//Un autoturism detine un motor precum si un numar de usi.De asemenea autovehiculul este caracterizat de marca,
//model si an de fabricatie
//Autoturismul va avea urmatoarele metode/proprietati
//Va returna descrierea complete a autovehicolului sub forma unui sir de caractere
//“Marca, model, anDeFabricatie, capacitate cilindrica, combustibil, putere motor, numar de usi
//Va afisa textul “masina porneste” , va inchide usile si va porni motorul
//Va afisa textul “masina se opreste”, va opri motorul si va inchide usile
class Autoturism
{
    private string marca;
    private string model;
    private int anDeFabricatie;
 
    public Autoturism(string marca, string model, int anDeFabricatie, int numarDeUsi)
    {
        marca = "Nissan";
        model = "Juke";
        anDeFabricatie = 2012;
    }
}