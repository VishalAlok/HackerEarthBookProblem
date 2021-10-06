using System;


class Program
{
    static void Main()
    {
        string A = Console.ReadLine();
        string[] ArrayFromA = A.Split(" ");
        int FirstNumber = Convert.ToInt32(ArrayFromA[0].ToString());
        int SecondNumber = Convert.ToInt32(ArrayFromA[1].ToString());

        string PageNumbers = Console.ReadLine();
        string[] PageArray = PageNumbers.Split(" ");
        int[] array = new int[SecondNumber];

        for(int i = 0;i<SecondNumber;i++)
        {
            array[i] = Convert.ToInt32(PageArray[i].ToString());
        }
        int MyFinalAnswer = 0;
        MyFinalAnswer = MyFinalAnswer + array[0] % 10;

        for(int j=1;j<SecondNumber;j++)
        {
            int Num = array[j] % 10;
            if(Num!=0)
            {
                MyFinalAnswer = (MyFinalAnswer * Num) % 1000000007;
            }
        }
        Console.WriteLine(MyFinalAnswer);
        Console.ReadLine();
    }
}
