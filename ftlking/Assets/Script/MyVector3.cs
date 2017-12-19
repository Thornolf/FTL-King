using System;

namespace DefaultNamespace
{
    public class MyVector3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public MyVector3(float newX, float newY, float newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }
        
        public MyVector3(float newX, float newY)
        {
            x = newX;
            y = newY;
            z = 0f;
        }

        public void setAllAxe(float newX, float newY, float newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }
    }
}