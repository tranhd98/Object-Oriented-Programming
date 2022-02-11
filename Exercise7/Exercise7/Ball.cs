using System;
namespace Exercise7
{
    public class Ball
    {
        private Color color;
        private int size;
        private int throwCount;
        public Ball(Color color, int size)
        {
            this.color = color;
            this.size = size;
            throwCount = 0;
        }
        public void Throw()
        {
            if(size != 0)
            {
                throwCount++;
            }
        }

        public void Pop()
        {
            size = 0;
        }

        public int numberOfThrow()
        {
            return throwCount;
        }
    }
}
