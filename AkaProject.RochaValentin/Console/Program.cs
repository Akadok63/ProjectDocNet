using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Model.Context();
            a.Categories.ToList();
        }
    }
}
