using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    //@Danin
    //This class is used to calculate the area of triangle which need 2 parameter
    //pedestal and the height
    //With the condition that the base and height can't be negative (-)
    //When the base and the height has a negative value
    //the method will return a negative value
    class AreaOfTriangle
    {
        public double Area (double pedestal, double height)
        {
            double area;
            if ((pedestal > 0) && (height > 0))     //this checker for negative value for both base and weight
            {
                area = (pedestal * height)/2;     //Area of triangle 2 / (base * height)
                return area;
            } else
            {
                return -1;      //if the base or the height has a negative value, this what will the method return
            }
        }
    }
}
