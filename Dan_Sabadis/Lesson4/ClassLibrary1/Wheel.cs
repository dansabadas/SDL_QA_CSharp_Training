
using System.CodeDom;

namespace ClassLibrary1
{
    public enum WheelSize
    {
        Small, Medium, Big
    }

    public class Wheel
    {
        public string Name { get; }

        public WheelSize Size { get; }

        public Wheel(string name, WheelSize size)
        {
            Name = name;
            Size = size;
        }
    }
}
