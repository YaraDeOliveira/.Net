using HerdarvsInterface.Enums;

namespace HerdarvsInterface.Entities
{
    abstract class Shape : IShape
    {
        public Color Color{ get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
