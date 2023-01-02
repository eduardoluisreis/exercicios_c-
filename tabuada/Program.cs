using System;

class Program{

public static void Main(){

    Console.WriteLine("Digite um número no qual deseja saber a tabuada!");
      
    int N = int.Parse(Console.ReadLine());
    
      tabuada(N, 0);
            
    }
   public static void tabuada(int N, int fm){

     if (fm > 10)
       return;
  
   Console.WriteLine (N + "x" + fm + "=" + N * fm);
   tabuada (N, fm + 1);
   
   }
   
 }