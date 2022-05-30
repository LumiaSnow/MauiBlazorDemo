using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Func { get; set; }
        public string Content { get; set; }
    }
}
