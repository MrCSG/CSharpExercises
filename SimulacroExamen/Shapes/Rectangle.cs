using System;
namespace SimulacroExamen
{
    public class Rectangle : Shapes
    {
        public float baseR, height;

        public Rectangle(string name, float baseR, float height) : base(name)
        {
            this.baseR = baseR;
            this.height = height;
        }

        public override float Area()
        {
            return baseR * height;
        }

        public override float Perimeter()
        {
            return ( baseR * 2 ) + (height * 2);
        }
    }
}