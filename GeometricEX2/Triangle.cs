
namespace GeometricEX2
{
    internal class Triangle
    {
        //PROPS
        protected double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        protected double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //CONSTRUCTORS
        public Triangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        // METHODS
        public double GetArea()
        {
            return (width * height) / 2;
        }
    }
}
