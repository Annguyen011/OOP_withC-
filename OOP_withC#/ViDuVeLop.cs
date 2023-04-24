using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_withC_
{
    public class ViDuVeLop
    {
        public static void Main(string[] args)
        {
            SimpleCircle circle1 = new SimpleCircle();
            Console.WriteLine("The area of the circle of radius " + circle1.radius + " is " + circle1.GetArea());
            SimpleCircle circle2 = new SimpleCircle(25);
            Console.WriteLine("The area of the circle of radius " + circle2.radius + " is " + circle2.GetArea());

            SimpleCircle circle3 = new SimpleCircle(125);
            Console.WriteLine("The area of the circle of radius " + circle3.radius + " is " + circle3.GetArea());
            circle2.radius = 100;
            Console.WriteLine("The area of the circle of radius " + circle2.radius + " is " + circle2.GetArea());
        }
    }

    class SimpleCircle
    {
        public double radius;
        /* Construct a circle with radius */

        public SimpleCircle()
        {
            radius = 1;
        }

        /* Construct a circle with a specified radius */
        public SimpleCircle(double newRadius)
        {
            radius = newRadius;
        }

        /* Return the area of this circle */
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        /* return the perimeter of this circle */
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        /* set a new radius for this circle */
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
    }
    public class TV
    {
        int channel = 1;
        int volumeLevel = 1;
        bool on = false;

        public TV()
        {
        }

        public void TurnOn()
        {
            on = true;
        }

        public void TurnOff()
        {
            on = false;
        }

        public void SetChannel(int newChannel)
        {
            if (on && newChannel >= 1 && newChannel <= 120)
                channel = newChannel;
        }

        public void SetVolume(int newVolumeLevel)
        {
            if (on && newVolumeLevel >= 1 && newVolumeLevel <= 7)
                volumeLevel = newVolumeLevel;
        }

        public void ChannelUp()
        {
            if (on && channel < 120)
                channel++;
        }

        public void ChannelDown()
        {
            if (on && channel > 1)
                channel--;
        }

        public void VolumeUp()
        {
            if (on && volumeLevel < 7)
                volumeLevel++;
        }

        public void VolumeDown()
        {
            if (on && volumeLevel > 1)
                volumeLevel--;
        }
    }
}
