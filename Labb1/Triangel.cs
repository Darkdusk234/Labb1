namespace Labb1
{
    internal class Triangel
    {
        private float _Width;
        private float _Height;

        public Triangel(float width, float height)
        {
            _Width = width;
            _Height = height;
        }

        public float GetArea()
        {
            return (_Width * _Height) / 2;
        }

        public float GetConeVolume()
        {
            float radius = _Height / 2;
            float pi = 3.141f;
            return (pi * radius * radius * _Height) / 3; 
        }
    }
}
