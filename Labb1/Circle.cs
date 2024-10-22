namespace Labb1
{
    internal class Circle
    {
        private float _Radius;
        private readonly float _pi = 3.141f;

        public Circle(float radius)
        {
            _Radius = radius;
        }


        public float GetArea()
        {
            return ((_Radius * _Radius) * _pi);
        }

        public float GetCircumference()
        {
            return (_Radius * 2 * _pi);
        }

        public float GetSphereArea()
        {
            return (4 * _pi * _Radius * 2);
        }

        public float GetSphereVolume()
        {
            return ((4 * _pi * (_Radius * _Radius * _Radius)) / 3);
        }
    }
}
