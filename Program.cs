using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program /* хрень полная, надо сделать базовый класс прогрессия, в нем указать методы
    {                void SetStart(int x); //устанавливает начальное значение
                     int GetNext(); // возвращает следующее число ряда
                     void Reset()// выполняет сброс к начальному значению 
                     и метод типа прогрессии и все это будет в 4 раза короче 
                     но мне лень   */
    { 
        static void Main()
        {
            ArithProgression ARProg = new ArithProgression();
            GeomProgression GProg = new GeomProgression();
            Console.WriteLine("Enter the initial term of the progression, step and number of steps");
            int it = Convert.ToInt32(Console.ReadLine());
            ARProg.SetStart(it);
            GProg.SetStart(it);
            
            GProg.Step = ARProg.Step = Convert.ToInt32(Console.ReadLine());
            int NStep = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            do
            {
                Console.WriteLine("Step {0,4:# ###}: Arithmetic progression: " +
                    "{1,4:# ###} Geometric progression: " +
                    "{2,7:# ### ###}", n, ARProg.AP, GProg.GP);

                ARProg.GetNext();
                GProg.GetNext();
                n++;
            } while (n < NStep);
            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void SetStart(int x); //устанавливает начальное значение
        int GetNext(); // возвращает следующее число ряда
        void Reset(); // выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        public int AP { get; set; }
        int StX;
        public int Step;
        public void SetStart(int x)
        {
            AP = StX = x;
        }
        public int GetNext()
        {
            //Console.WriteLine("ArithProgression : {0}", AP);
            return AP += Step;
            
        }
        public void Reset()
        {
            AP = StX;
        }
    }

    class GeomProgression : ISeries
    {
    public int GP { get; set; }
        int StX;
        public int Step;
        public void SetStart(int x)
        {
            GP = StX = x;
        }
        public int GetNext()
        {
            return GP *= Step;
        }
        public void Reset()
        {
            GP = StX;
        }
    }
}
