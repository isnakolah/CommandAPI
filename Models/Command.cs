using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Howto { get; set; }
        public string Platform { get; set; }
        public string Commandline { get; set; }
    }
}
