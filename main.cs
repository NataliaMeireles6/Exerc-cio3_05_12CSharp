using System;

class Program {
  public static void Main (string[] args) {

  String maçãs, entrada;
  Double valor; 
  Int16  num;

  Console.WriteLine("Digite o número de maçãs compradas");
  
  num = Int16.Parse(Console.ReadLine());

  if(num<12)
  {
  valor = num*1.30;
  
Console.WriteLine("O valor total de maçãs compradas foi : " + valor + "reais");

  }
  
  else (num>12)
  valor = num*1.00;
    {
      
  Console.WriteLine("O valor total de maçãs compradas foi : " + valor + "reais");
    
    }

  }

  }
