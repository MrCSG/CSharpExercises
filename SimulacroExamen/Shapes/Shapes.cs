using System;
namespace SimulacroExamen
{
    public abstract class Shapes
    {
        public string name;

        protected Shapes(string name)
        {
            this.name = name;
        }
        public abstract float Area();

        public abstract float Perimeter();
    }
}