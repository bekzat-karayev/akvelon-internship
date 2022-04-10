using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoApp
{
    public class Track
    {
        public string Name { get; set; }
        public string Style { get; set; }

        // Instance of a track must have both properties defined
        public Track(string name, string style)
        {
            this.Name = name;
            this.Style = style; 
        }
    }
}
