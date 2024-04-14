Console.WriteLine("Keshcha dasturini ishga tushirish uchun parolni kiriting!");

string password = null;

do
{
    Console.Write("Parolni kiriting: ");
    password = Console.ReadLine();

} while (password != "thebude");


Console.WriteLine("Asalomu allaykum men Keshcha bilan sizning yoshingizni solishtiradigan Dasturman.");

Console.Write("Menga uzingizni tanishtirng\nIsmingiz: ");
string name = Console.ReadLine();

Console.Write($"{name} yoshingizni kiriting: ");
int age = Convert.ToInt32(Console.ReadLine());

int keshcha = 19;
Console.WriteLine($"Keshchani yoshi {keshcha} da");

int dic = age - keshcha;

Console.WriteLine($"Siz bilan Keshchani orasidagi yosh farqi {dic} ga teng");

string mesagge =
    dic >= 0
        ? "Keshcha bilan Sizning yosh tafavudlaringiz noldan katta yoki teng"
        : "Keshcha bilan Sizning yosh tafavudlaringiz noldan kichkina";
Console.WriteLine(mesagge);

string mesagge1 =
    age >= 0 && keshcha >= 0
        ? "sizning va Keshchaning yoshi musbat"
        : "Sizning yoki Keshchaning yoshi Manfiy";
Console.WriteLine(mesagge1);

if (age < keshcha)
{
    Console.WriteLine($"{name} Siz  keshchadan {dic} yosh kichiksiz");
}
else if (age == keshcha)
{
    Console.WriteLine($"{name} siz Keshcha bilan teng yoshdasiz");
}
else
{
    Console.WriteLine($"{name} Siz Keshchadan {dic} yosh kattasiz ");
}

Console.WriteLine("Keshchani Do'stlari haqida ma'lumot!");


string[] friends = new string[3];
friends[0] = "Orif";
friends[1] = "Samandar";
friends[2] = name;
int[] friendsAge = { 10, 22, age, };
string[] country = new string[3];
country[0] = "Buxoro";
country[1] = "Namangan";
country[2] = "Samarqand";

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine($"{friends[i]} {friendsAge[i]} yoshda va u {country[i]}dan");
}
