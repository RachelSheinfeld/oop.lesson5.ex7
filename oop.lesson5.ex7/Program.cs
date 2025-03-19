namespace oop.lesson5.ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportUnion sportUnion = new SportUnion();
            SportClube sportClube = new SportClube();
        }

        public static void excellenters(SportUnion[] sp)
        {
           
            for (int i = 0; i < sp.Length; i++)
            {
                for(int j = 0;j< sp[i].getuniondata().Length; j++)
                if (sp[i].getNumOfUnion()>=5&& sp[i].getuniondata()[j].GetCountOPlayer()>=50)
                        Console.WriteLine(sp[i].getunionName);
            }
        }
    }
}
