
using System.Diagnostics.CodeAnalysis;

namespace Genericclass
{
    //Creating a Generic Interface with the name IBank

    public interface IBank<T>
    {
        // creating generic method for deposit 

        public void deposit(T amount);

        //creating generic method for withdraw 

        public void withdraw(T amount);

    }

    //child class for the parent class 

    public class Bank<T> : IBank<T>
    {

        //creating the static variable for balance 

        private static T balance;

     
        public void deposit(T amount)
        {

         
        balance = (dynamic)balance + amount;
        balance =( dynamic)balance;
        Console.WriteLine($"deposit : {amount} and New balance is {balance}" );

        }
        public void withdraw(T amount)
        {
        balance = (dynamic) balance - amount;
        balance = (dynamic)balance;
        Console.WriteLine($"withdrawing : {amount} and New balance is {balance}");
        }


    }
    class Class1
    {
        static void Main(string[] args)
        {
            IBank<double> Bank = new  Bank<double>();
            Bank.deposit(1500);
            Bank.withdraw(1200);
           
        }
    }




}
