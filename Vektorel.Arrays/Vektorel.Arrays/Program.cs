namespace Vektorel.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int[] numbers = new int[4];

            numbers[3] = 23;
            numbers[0] = 45;
            numbers[1] = 11;
            //numbers[2] = 9;
            string b = "Perk";
            string[] names = new string[5];
            names[0] = "Can";
            names[1] = "Mücahit";
            names[2] = "Arda";
            names[3] = "Gürkan";
            names[4] = "Mert";

            Person[] people = new Person[3];
            people[0] = new Person("Can", 36);
            people[1] = new Person("Mücahit", 21);
            people[2] = new Person("Arda", 18);

            var c = new Car("Honda", "Accord", 2024, 221);

        }
    }

    record Person(string name, int age);
    record Car(string brand, string model, int year, int maxSpeed);
}
