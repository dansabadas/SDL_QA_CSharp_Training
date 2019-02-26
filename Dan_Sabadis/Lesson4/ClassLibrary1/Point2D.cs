
namespace ClassLibrary1
{
    public interface IPoint
    {
        double X { get; }
        double Y { get; }
    }

    public struct Point2D : IPoint
    {
        public static int OverallNumberOfPoints = 0;
        public const string ErrorMessage = "bla bla error";

        private double _x;
        private readonly double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
            OverallNumberOfPoints += 1;
        }

        public double X // this is a property
        {
            get { return _x; }
            set
            {
                if (value < 0)
                {
                    _x = -value;
                }
                else
                {
                    _x = value + 10;
                }
            }
        }

        public double Y => _y;

        public override string ToString()
        {
            return $"({_x},{this._y})";
        }
    }
}
