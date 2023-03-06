using Классы;

Console.WriteLine("Hello, World!");

//Person x = new Person();
//x.Read();
//x.Print();

Console.WriteLine("Input count of persons: ");
int n = int.Parse(Console.ReadLine());

Person[] Persons = new Person[n];

for (int i = 0; i < n; i++)
{
    Persons[i] = new Person();
    Persons[i].Read();
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Persons[i].Surname);
    Console.WriteLine(Persons[i].Name[0]);
    Console.WriteLine(Persons[i].Age(Persons[i].BirthDate));
    Console.WriteLine(Persons[i].Gender);
}

