//Scrieti un program care va modela un autoturism. Un autoturism va avea o
//marca (string), un numar de inmatriculare (string), precum si o
//capacitate cilindrica(int).
//Autoturismul va avea:
// Campurile corespunzatoare caracteristicilor autoturismului.
// Un constructor care va initializa campurile acestuia
// O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
//numarDeInmatriculare, capacitateCilindrica”.
//Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
//xml pentru metodele publice.
//Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
//metodele “Tipareste



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter car details:");

        Console.Write("Enter car brand: ");
        string brand = Console.ReadLine();

        Console.Write("Enter car registration number: ");
        string registrationNumber = Console.ReadLine();

        Console.Write("Enter car engine capacity: ");
        int engineCapacity = int.Parse(Console.ReadLine());

        Car car = new Car(brand, registrationNumber, engineCapacity);

        Console.WriteLine("\nCar details:");
        car.Print();
    }
}

public class Car
{
    private string brand;
    private string registrationNumber;
    private int engineCapacity;

    public Car(string brand, string registrationNumber, int engineCapacity)
    {
        this.brand = brand;
        this.registrationNumber = registrationNumber;
        this.engineCapacity = engineCapacity;
    }
    public void Print()
    {
        Console.WriteLine($"{brand}, {registrationNumber}, {engineCapacity}cc");
    }
}

