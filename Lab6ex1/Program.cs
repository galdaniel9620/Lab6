//Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
//metoda care va calcula volumul acestuia.
//Folositi o clasa care va modela un dulap.
// Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
// Cele trei campuri vor fi initializate cu ajutorul constructorului
// Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
//Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
//afisati rezultatul.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter length of the wardrobe:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter width of the wardrobe:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter height of the wardrobe:");
        int height = int.Parse(Console.ReadLine());

        Wardrobe myCupboard = new Wardrobe(length, width, height);
        int volume = myCupboard.CalculateVolume();
        Console.WriteLine("The volume of the wardrobe is: " + volume);
    }
}

public class Wardrobe
{
    private int length;
    private int width;
    private int height;

    public Wardrobe(int length, int width, int height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public int CalculateVolume()
    {
        return length * width * height;
    }
}