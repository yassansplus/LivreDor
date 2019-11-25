using System;
using System.Collections.Generic;
using System.Text;

namespace LivreDOr
{
    class Critique
    {
        private string name;
        private string message;

        public Critique(string n, string m)
        {
            this.Name = n;
            this.Message = m;
        }

        public Critique()
        {
        }


        public string Name { get ; set; }
        public string Message { get; set; }

    }

}
