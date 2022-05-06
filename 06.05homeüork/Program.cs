namespace _06._05homeüork
{
    class Program
    {
        static void Main(string[] args)
        {
            ITextable word = new Word();
            ITextable excel = new Excel();
            ITextable pdf = new PDF();
            MainPrintFile word1 = new MainPrintFile(word);
            MainPrintFile excel1 = new MainPrintFile(excel);
            MainPrintFile pdf1 = new MainPrintFile(pdf);




        }
    }
}
