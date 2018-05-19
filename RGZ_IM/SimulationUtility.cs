using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    static class SimulationUtility
    {
        readonly static Random random = new Random();

        /// <summary>
        /// Время прихода следующей заявки
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static double GetNextPeopleTime(bool isWave)
        {
            if (isWave == false) return -0.67 * Math.Log(random.NextDouble()); // 0.67 человека в минуту
            else return -0.3 * Math.Log(random.NextDouble());
        }

        /// <summary>
        /// Количество заявок, пришедших в очередь за 1 раз
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static int GetNextPeopleCount(bool isWave)
        {
            if (isWave == false) return random.Next(0, 6);
            else return random.Next(3, 9);
        }

        /// <summary>
        /// Время до возникновения следующей волны
        /// </summary>
        public static double GetWave(double math)
        {
            return -math * Math.Log(random.NextDouble());
        }

        /// <summary>
        /// Продолжительность волны
        /// </summary>
        /// <returns></returns>
        public static double GetWaveLength()
        {
            if (random.Next(0, 1) == 0) return 90 + 22.5 * random.NextDouble();
            else return 90 - 22.5 * random.NextDouble();
        }

        /// <summary>
        /// Время обслуживания заявки
        /// </summary>
        /// <returns></returns>
        public static double GetServiceTime(double time)
        {
            if (time < 960) return 7 + PlusMinusWork(time);
            else return 12 + PlusMinusWork(time);
        }

        /// <summary>
        /// Генерация разброса для интервала
        /// </summary>
        /// <returns></returns>
        static double PlusMinus()
        {
            if (random.Next(0, 1) == 0) return random.NextDouble() / 3;
            else return -random.NextDouble() / 3;
        }

        /// <summary>
        /// Генерация разброса для времени обслуживания заявки в зависимости от времени суток
        /// </summary>
        /// <param Время суток="time"></param>
        /// <returns></returns>
        static double PlusMinusWork(double time)
        {
            if (time < 960)
            {
                if (random.Next(0, 1) == 0) return random.NextDouble();
                else return -random.NextDouble();
            }
            else
            {
                if (random.Next(0, 1) == 0) return 2 * random.NextDouble();
                else return 2 * random.NextDouble();
            }
        }
    }
}