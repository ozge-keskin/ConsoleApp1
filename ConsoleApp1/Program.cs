// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var boy = 0;
Console.WriteLine("Lütfen boyunuzu giriniz : ");
boy = Convert.ToInt32(Console.ReadLine());

var kg = 0;
Console.WriteLine("Lütfen kilonuzu giriniz : ");
kg = Convert.ToInt32(Console.ReadLine());

var sonuc = Decide(boy, kg);

Console.WriteLine(sonuc);


string Decide(int boy, int kg)
{
    var opr = CalculateOpr(boy, kg);

    if (opr < 11)
    {
        return "kilo ver";
    }
    else if (opr == 11)
    {
        return "ideal";
    }
    else
    {
        return "kilo alll";
    }
}
int CalculateOpr(int boy, int kg)
{
    return boy - 100 - kg;
}