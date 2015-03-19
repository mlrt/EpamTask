using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_float

{
    public  class Float
    {
        private  string[] array;
        
       

        
        //функция замены символов
        public  string[] replacement(string[] lines)
        {
            int len = lines.Length;
             array = new string[len];
     
            
            for (int i = 0; i < len; i++)
            {
                
                string[] word = lines[i].Split(new char[] { ',' });
                string X="X: ";
                string Y = "Y: ";
                X += word[i*2];
                X = X.Replace(".", ",");
                Y += word[2*i+1];
                Y = Y.Replace(".",",");
                string XandY = X + " " + Y;
                array[i] = XandY;
                X=String.Empty; 
                Y = null;
                XandY=null;
               
                
                
            }
            return array;

        }

    }
}


