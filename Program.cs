using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
  static void Main()
  {


    Iphone iphone = new Iphone("1234-5678", "iPhone 13", "123456548", 256);
    Nokia nokia = new Nokia("5678-1234", "Nokia 222", "32165478", 125);

    Console.WriteLine("iPhone: ");
    iphone.Ligar();
    iphone.InstalarAplicativo("Whatsapp");

    Console.WriteLine("\n");

    Console.WriteLine("Nokia: ");
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Telegram");
  }
}