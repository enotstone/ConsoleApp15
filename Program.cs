using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program /* совершенно безтолоковое решение, нет понимания способов присваивания, обращения, извлечения и использования семантики */ 
                  
    { 
        static void Main()
        {
            ArithProgression ARProg = new ArithProgression();
            GeomProgression GProg = new GeomProgression();
            Console.WriteLine("Enter the initial value of the progression, step and number of steps");
            int iv = Convert.ToInt32(Console.ReadLine()); //? как грамотно передать тоже значение нескольким методам
            ARProg.SetStart(iv);
            GProg.SetStart(iv);
            
            //GProg.Step = ARProg.Step = Convert.ToInt32(Console.ReadLine());
            int step = Convert.ToInt32(Console.ReadLine());
            int NStep = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            do
            {
                Console.WriteLine("Step {0,3:###}: Arithmetic progression: " +
                    "{1,9:# ### ###} |   Geometric progression: " +
                    "{2,13:# ### ### ###}", n, ARProg.AP, GProg.GP);

                ARProg.GetNext(step);
                GProg.GetNext(step);
                n++;
            } while (n < NStep);
            Console.ReadKey();
        }
    }

    interface /*interface - предписывает порядок содержания*/ISeries
    {
        void SetStart(int x); //устанавливает начальное значение
        int GetNext(int step); // возвращает следующее число ряда
        //int GetNext();
        void Reset(); // выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        public int AP { get; set; }
        int StX;
        //public int Step;
        public void SetStart(int x)
        {
            AP = StX = x;
        }
        public int GetNext(int step)
        {
            return AP += step;
        }
        public void Reset()
        {
            AP = StX; //? как грамотно обратиться к начальному значению другого метода того же класса (другого класса)
        }
    }

    class GeomProgression : ISeries
    {
    public int GP { get; set; }
        int StX;
        //public int Step;
        public void SetStart(int x)
        {
            GP = StX = x;
        }
        public int GetNext(int step)
        {
            return GP *= step;
        }
        public void Reset()
        {
            GP = StX;
        }
    }
}







































































/*                 можно сделать базовый класс прогрессия, в нем указать методы
                   void SetStart(int x); //устанавливает начальное значение
                   int GetNext(); // возвращает следующее число ряда
                   void Reset()// выполняет сброс к начальному значению 
                   и метод типа прогрессии, все это будет в 4 раза короче 
                   не успеваю разбираться 

                    interface <имя> предписывает порядок содержания
                    разобрать использование this, обращение между методами

                   void метод возвращает значение
                   int метод для возврата, должен использовать return 
*/
