namespace SizeOfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int类型的存储空间大小：{0}", sizeof(int));
            Console.WriteLine("long类型的存储空间大小：{0}", sizeof(long));
            Console.WriteLine("float类型的存储空间大小：{0}", sizeof(float));
            Console.WriteLine("double类型的存储空间大小：{0}", sizeof(double));
            Console.WriteLine("decimal类型的存储空间大小：{0}", sizeof(decimal));
            Console.WriteLine("bool类型的存储空间大小：{0}", sizeof(bool));
            Console.WriteLine("char类型的存储空间大小：{0}", sizeof(char));

            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            Console.WriteLine("字符串的长度为：" + str.Length);
            Console.WriteLine("字符串中第一个字符为：" + str[0]);
            Console.WriteLine("字符串中最后一个字符为：" + str[str.Length - 1]);

            Console.ReadKey();
        }
    }
}