using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum WhellSize
    {
        Small, Medium, Big
    }
    public class wheel
    {

        public wheel(string name, WhellSize size)
        {
            Name = name;
            Size = size;
        }
        public string Name { get; }
        public WhellSize Size { get; }
       
    }
}
