using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alumno;
            float pagoAlumno, Total;
            Console.WriteLine("Cuantos alumnos iran de viaje: ");
            alumno = int.Parse (Console.ReadLine());    
             if (alumno >= 100)
            {
                pagoAlumno = 65;
            }
             else
            {
                if (alumno >= 50)
                {
                    pagoAlumno = 70;
                }
                else
                {
                    if (alumno >= 30)
                    {
                        pagoAlumno = 95;
                    }
                    else
                    {
                        pagoAlumno = 4000;
                    }
                }
            }
            Total = pagoAlumno * alumno;
            Console.WriteLine("Pago individual es de: S/" + pagoAlumno);
            Console.WriteLine("El pago total es de: S/" + Total);
            Console.ReadKey();
        }
    }
}
