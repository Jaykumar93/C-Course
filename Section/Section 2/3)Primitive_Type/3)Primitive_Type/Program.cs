class Sample
{
    static void Main()
    {
        sbyte a = sbyte.MaxValue;
        sbyte b = 100;
        sbyte c = default(sbyte); ;

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);



        byte d = byte.MaxValue;
        short e = short.MaxValue;
        ushort f = ushort.MaxValue;
        int g = int.MaxValue;
        uint h = uint.MaxValue;
        long i = long.MaxValue;
        ulong j = ulong.MaxValue;
        float k = float.MaxValue;
        double l = double.MaxValue;
        decimal m = decimal.MaxValue;
        char n = 'A';
        string o = "abc";
        bool p = true;

        System.Console.WriteLine("sbyte "+a);
        System.Console.WriteLine("sbyte " + b);
        System.Console.WriteLine("sbyte " + c);
        System.Console.WriteLine("byte " + d);
        System.Console.WriteLine("short " + e);
        System.Console.WriteLine("ushort " + f);
        System.Console.WriteLine("int " + g);
        System.Console.WriteLine("uint " + h);
        System.Console.WriteLine("long " + i);
        System.Console.WriteLine("ulong " + j);
        System.Console.WriteLine("float " + k);
        System.Console.WriteLine("double "+l);
        System.Console.WriteLine("decimal "+ m);
        System.Console.WriteLine("char "+ n);
        System.Console.WriteLine("string "+o);
        System.Console.WriteLine("boolean "+p);

        System.Console.ReadKey();
    }
}
