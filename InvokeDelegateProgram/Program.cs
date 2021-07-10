using System;

namespace InvokeDelegateProgram
{
    class Program
    {
        public class Test
        {
            static public void M1() { }
            static public void M2(string data) { }
            public int M3(int x) { return x; }
            public bool M4(string data, string msg) { return true; }
            static double Calculate(int x, double y) { return x + y; }
        }
            void Update(int newNumber) { System.Console.WriteLine(newNumber); }

            void Delete(string key) { }
        
            static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3,
                                                Func<string, string, bool> obj4, Func<int,double,double>
                                                Calculate, Action <int> Update, Action<string> Delete)
            {

                //Invoke Delegate objects


            }

             static void Main(string[] args)
            {
            Test object = new Test();

            //Call FunctionAsAnArguments 

            Action m1ptr = new Action(Test.M1);
            Action<string> m2Ptr = new Action<string>(Test.M2);
            Func<int, int> m3Pt3 = new Action<int, int>(object.M3);
            Func<int, double, double> m5Ptr = new Func<int, double, double>(object.M4);
            Func<int, double, double> _calc = new Func<int, double, double>(object.Calculate);
            Action<int> _update = new Action<int>(object.Update);
            Action<string> _delet = new Action<int>(object.Delete);



        }
    }
}
