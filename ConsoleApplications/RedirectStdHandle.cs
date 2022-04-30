using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications.StdRedirections
{
    internal class RedirectStdHandle
    {
        private static TextWriter BaseOutputWriter;
        private static TextWriter BaseErrorWriter;

        private static String OutputFileName = "output.txt";
        private static String ErrorFileName = "error.txt";

        static private void Write(string text, bool isError = false)
        {
            using (StreamWriter sw = new StreamWriter(isError ? ErrorFileName : OutputFileName, append: true))
            {
                Console.SetOut(sw);
                Console.WriteLine(text);
            }
        }
        static private void Write(string text) => Write(text, false);
        static private void WriteError(string text) => Write(text, true);
        static public void main()
        {
            BaseOutputWriter = Console.Out;
            BaseErrorWriter = Console.Error;
            Console.Write("Enter line to output: ");
            var output = Console.ReadLine();
            Console.Write("Enter line to error: ");
            var error = Console.ReadLine();

            Write(output ?? "nothing entered into output");
            WriteError(error ?? "nothing entered into error");

            Console.SetOut(BaseOutputWriter);
            Console.SetError(BaseErrorWriter);
        }
    }
}
