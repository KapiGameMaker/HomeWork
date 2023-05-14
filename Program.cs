using System;
  
class GFG {
  
    // Main Method
    static public void Main(String[] args)
    {
        while(true)
        {
            int input = int.Parse(Console.ReadLine());
            if(input < 0 )
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
            else{
                for(int row = 0; row <= input ; row++ )
                {
                    for(int column = 0; column <= row; column++ )
                    {
                        Console.Write("{0} ",Pas(row,column));                
                    }
                    Console.WriteLine();
                }
                break;
            }
        }        
    }

    static public int Pas(int row, int column)
    {
        return Fac(row!) / (Fac(row - column) * Fac(column) ) ;
    }

    static public int Fac(int number)
    {
        if(number <= 1) return 1;
        return number * Fac(number - 1);
    }
}