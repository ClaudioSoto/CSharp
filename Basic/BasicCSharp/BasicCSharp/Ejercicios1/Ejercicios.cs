using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp.Ejercicios1
{
    public class Ejercicios
    {
        public string ValidNumber(int number)
        {
            if(number > 0 && number <= 10)
            {
                return "Valid";
            }
            return "Invalid";
        }

        public int ReturnMax(int number1, int number2) {
            return Math.Max(number1, number2);
        }

        public string TypeOfPhoto(int height, int width)
        {
            if( height > width)
            {
                return "Portrait";
            }else if(height < width)
            {
                return "LandScape";
            }
            return "None of them";
        }

        public string SpeedCamera(int speedLimit, int carSpeed)
        {
            int demeritPoints;

            if (carSpeed <= speedLimit)
            {
                return "Ok";
            }
            else
            {
                demeritPoints = (carSpeed - speedLimit) / 5;
            }

            if(demeritPoints > 12)
            {
                return "Suppended license";
            }
            return "You are over the speed limit by: " + demeritPoints.ToString();


        }

    }
}
