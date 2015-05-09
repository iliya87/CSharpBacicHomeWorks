using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class BankAccountData
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        string account = "Iliya Andreev Asenov";
        char currency = '\u20A4';
        decimal balance = 124.000000000000m;
        string bank = "MyBank";
        object IBAN = "GB12|1234|1234|1234|1234|1234|";
        long CreditCardOne = -965323155987513248;
        double CreditCardTwo = -34.000000001;
        sbyte CreditCardThree = -127;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}" 
        , account, currency, balance, bank, IBAN, CreditCardOne, CreditCardTwo ,CreditCardThree);

    }
}

