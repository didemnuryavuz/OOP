namespace _21_ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Olmayan Action tipi , Herhangi bir parametre almayan ve geri donusu olmayan bir delegate tipidir
            //Action delegate kullandigimizda farkidaysaniz delegeta tanimlamasina gerek yoktur.

            Action message = () => Console.WriteLine("Action Delegate ornegi");
            message.Invoke();
            Console.WriteLine("*************");
            message();

            #region Generic Action tipi
            //Generic Action Delegate geri donus degeri olmayan en fazla 16 parametre alabilen bir delegate tipidir
            Action<string> EkranaYaz = str => Console.WriteLine(str);
            Action<int, int> toplaAction = (a, b) => Console.WriteLine("Toplam :" + (a + b));

            toplaAction(3, 5);
            #endregion
        }
    }
}
