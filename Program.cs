namespace Megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> lista = new List<int[]>()
            {
                new int[] { 3,1,2,3},
                new int[] { 4,2,2,2,2},
                new int[] { 1,1},
                new int[] { 4,2,2,2,1},
            };
            string v = "";
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    if (lista[i].Skip(1).Count(x => x % 2 == 1) > lista[i].Skip(1).Count(x => x % 2 == 0)
            //          || lista[i].Skip(1).Count(x => x % 2 == 0) == lista[i].Length - 1)
            //        v += 1;
            //    else
            //        v += 0;
            //}
            //Console.WriteLine(v);


            lista.ForEach(x => v += x.Skip(1)
            .Count(x => x % 2 == 1) > x.Skip(1).Count(x => x % 2 == 0)
                   || x.Skip(1).Count(x => x % 2 == 0) == x.Length - 1 ? 1 : 0);
            Console.WriteLine(v);
        }
    }
}