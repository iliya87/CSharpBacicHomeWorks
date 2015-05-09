using System;


class DeclareVariables
{   
    static void Main()
    {
        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825923;
        sbyte var4 = 97;
        short var5 = -10000;
        Console.WriteLine("52130 = {0}; \n-115 = {1}; \n4825923 = {2}; \n97 = {3}; \n-1000 = {4};"
        ,var1.GetTypeCode(), var2.GetTypeCode(), var3.GetTypeCode(), var4.GetTypeCode(), var5.GetTypeCode());
    }
}
