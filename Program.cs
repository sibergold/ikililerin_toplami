using System;
namespace ikililerin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Kaç sayı giriceksin? Sayı adedi çift olmalı.");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] ikililer=new int[n];
            for(int j=0;j<n;j++)
            {   Console.WriteLine("Lütfen {0}. sayıyı gir.",j+1);
                ikililer[j]=Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i=0;i<n;i+=2)
            {
                if(ikililer[i]==ikililer[i+1])
                {
                    Console.Write(Math.Pow((ikililer[i]+ikililer[i+1]),2)+" ");
                }   
              else
              {
                Console.Write((ikililer[i]+ikililer[i+1])+" ");
              }
            }
        }


    }
}