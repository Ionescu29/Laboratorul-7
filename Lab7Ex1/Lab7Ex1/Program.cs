// See https://aka.ms/new-console-template for more information
using Lab7Ex1;

Console.WriteLine("Hello, World!");
//Un autoturism detine un motor precum si un numar de usi. De asemenea autovehiculul este
//caracterizat de marca, model si an de fabricatie
//Autoturismul va avea urmatoarele metode / proprietati
//Va returna descrierea completa a autovehicolului sub forma unui sir de caractere
//Marca, model, anDeFabricatie, capacitate cilindrica, combustibil, putere motor, numar de usi'
// am facut o a doua clasa "autoturism" cu urmatoarele caracteristici
//marca
//model
//an de fabricatie
//numar de usi
Console.WriteLine(Autoturism.GetDescription);
class Autoturism
{
    private string marca;
    private string model;
    private int anDeFabricatie;
    private int numarDeUsi;
    public Autoturism(string marca, string model, int anDeFabricatie, int numarDeUsi)
    {
        marca = "Nissan";
        model = "Juke";
        anDeFabricatie = 2012;
        numarDeUsi = 4;
    }
    public string GetDescription()
    {
        return $"{marca}, {model}, {anDeFabricatie}, {capacitateCilindrica}, {putere}, {tipulCombustibilului}, {numarDeUsi}";
    }
}
