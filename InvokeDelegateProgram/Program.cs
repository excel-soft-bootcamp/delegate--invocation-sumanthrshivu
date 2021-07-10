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
            public int ArgumentMethod5(int data) { return data; }
            public bool M4(string data, string msg) { return true; }
            public static double Calculate(int x, double y) { return x + y; }

            public void Update(int newNumber) { System.Console.WriteLine(newNumber); }

            public void Delete(string key) { }
        }
            static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3,
                                                Func<string, string, bool> obj4, Func<int,double,double>
                                                CalculateObj, Action <int> updateObj, Action<string> DeleteObj)
            {
                //Invoke Delegate objects
                obj.Invoke();
                obj2.Invoke("string");
                int parameter = obj3.Invoke(5);
                bool result = obj4.Invoke("string1", "string2");
                double paramter = CalculateObj.Invoke(5, 6.9);
                updateObj.Invoke(10);
                DeleteObj.Invoke("sumanth");
            }

             static void Main(string[] args)
            {
                Test _obj = new Test();

                //Call FunctionAsAnArguments 

                Action m1ptr = new Action(Test.M1);
                Action<string> m2Ptr = new Action<string>(Test.M2);
                Func<int, int> m3Pt3 = new Action<int, int> (_obj.M3);
                Func < string, string, bool> m4Ptr = new Func<string, string, bool> (_obj.M4);
                Func<int, double, double> _calc = new Func<int, double, double>(Test.Calculate);
                Action<int> _update = new Action<int>(_obj.Update);
                Action<string> _delet = new Action<string>(_obj.Delete);

                FunctionsAsAnArguments(m1ptr, m2Ptr, m3Pt3, m4Ptr,  _calc, _update, _delet);
            }


        
    }
}
