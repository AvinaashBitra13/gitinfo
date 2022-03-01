using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Area
    {

        public static void Main()
        {
            Area Obj = new Area();
            Obj.AreaOfSquare();
            Obj.AreaOfRectangle();

        }
        public void AreaOfSquare()
        {
            Console.WriteLine("Enter the side of Square");
            int side = Convert.ToInt32(Console.ReadLine());
            int Area = side * side;
            Console.WriteLine($"Area of square with side {side} is {Area}");
            Console.ReadLine();
        }


        public void AreaOfRectangle()
        {
            Console.WriteLine("Enter the length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            int Area = length * width;
            Console.WriteLine($"Area of Rectangle is {Area}");
            Console.ReadLine();
            Console.WriteLine(Area);
            Console.ReadLine();
        }

    }

}


     
    

       
        
           
      
       
 
        

        
        

      
        
          
    
        
    



        



     


    


