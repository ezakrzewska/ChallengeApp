// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

string name = "Ewelina";
string sex = "Kobieta";
int age = 29;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewelina" && age == 33)
{
    Console.WriteLine("Ewelina,lat 33");
}
else if (sex != "Kobieta" && (age < 18))
{
    Console.WriteLine("niepelnoletni mezczyzna");
}


