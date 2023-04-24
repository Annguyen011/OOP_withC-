using OOP_withC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_withC_
{
    public class HinhChuNhat
    {
        private double width, height;
        public HinhChuNhat(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public HinhChuNhat()
        {

        }
        public double GetArea(double x, double y)
        {
            return width * height;
        }
        public double GetPerimeter(double x, double y)
        {
            return (width + height) * 2;
        }
        public void Display(double x, double y)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        HinhChuNhat hinh = new HinhChuNhat();

    }



}
