using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dextermd.FeliciaHelper.Domain.Entities
{
    public class Mural
    {
        public int MuralId { get; set; }
        public DateTime Data { get; set; }
        public string? Title { get; set; }
        public string? Notice { get; set; }
        public string? Author { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return this.Notice + " " + this.Author;
        }
    }
}
