using System;
namespace SimulacroExamen
{
    public class Triangle : Shapes
    {
        public float side1, side2, side3, baseT, height;
        public Triangle(string name, float side1, float side2, float side3, float baseT, float height) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.baseT = baseT;
            this.height = height;
        }

        public override float Area()
        {
            return (baseT * height)/2.0f;
        }
        
        public override float Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}