/*анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.*/

public delegate int Delegate(params Delegate1[] arr );
public delegate int Delegate1();


class Programm
{
    public static void Main(string[] args)
    {
        Delegate1 delegate1 = new Delegate1(Num);
        Delegate1 delegate2 = new Delegate1(Num);
        Delegate1 delegate3 = new Delegate1(Num);
        Delegate delegateSum = (Delegate1[] arr) =>
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i]();
            }
            return temp/2;
        };
        Console.WriteLine(delegateSum(delegate1, delegate2, delegate3));
    }

        public static int Num()
        {
            Random rand = new Random();
            return rand.Next(0,100);

        }
    }  
