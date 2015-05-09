using System;


    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company name : ");
            string companyname = Console.ReadLine();
            Console.WriteLine("Enter Company address : ");
            string companyaddress = Console.ReadLine();
            Console.WriteLine("Enter Phone Number :");
            string companyphone = Console.ReadLine();
            Console.WriteLine("Enter Fax number :");
            string fax = Console.ReadLine();
            Console.WriteLine("Enter Company Web Site :" );
            string website = Console.ReadLine();
            Console.WriteLine("Company name : {0}\nCompany address : {1}\nPhone number : {2}\nFax number : {3}\nWeb Site : {4}"
             , companyname,companyaddress,companyphone,fax,website);
            
            Console.WriteLine("Enter Maneger first name :");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Manager last name :");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Maneger age :");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Manager Phone number :");
            string mfpone = Console.ReadLine();
            Console.WriteLine("Manager first name :{0}\nManager last name :{1}\nManager age :{2}\nManager Phone :{3}"
            ,firstname,lastname,age,mfpone);
            

        }
    }

