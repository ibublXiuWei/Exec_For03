using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
    /// <summary>
    /// 右側對齊星形三角形
    ///     *
    ///    **
    ///   ***
    ///  ****
    /// *****
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                int countempty = 6 - i;
                int countstar = i;

                string row = new string(' ', countempty) + new string('*', countstar);
                Console.WriteLine(row);

            }

        }
    }
}
