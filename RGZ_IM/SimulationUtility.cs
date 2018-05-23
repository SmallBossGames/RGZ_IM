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

        static double R => (double)random.Next(int.MaxValue) / int.MaxValue;

        /// <summary>
        /// Время прихода следующей заявки
        /// Равномерный закон распределения
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static double GetNextPeopleTime(bool isWave)
        {
            if (isWave == false) return 1.5 + PlusMinus(); // 0.67 человека в минуту
            else return 0.75 + PlusMinus();
        }

        /// <summary>
        /// Количество заявок, пришедших в очередь за 1 раз
        /// Нормальный закон распределения
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static int GetNextPeopleCount(bool isWave)
        {
            if (isWave == false) return random.Next(1, 3);
            else return random.Next(1, 3);
        }

        /// <summary>
        /// Время до возникновения следующей волны
        /// Равномерный закон распределения
        /// </summary>
        public static double GetWave() => 330 + 60 * R;

        /// <summary>
        /// Продолжительность волны
        /// </summary>
        /// <returns></returns>
        public static double GetWaveLength() => 60 + 60 * R;

        /// <summary>
        /// Время обслуживания заявки
        /// Равномерный закон распределения
        /// </summary>
        /// <returns></returns>
        public static double GetServiceTime(double time)
        {
            if (time % 1440 < 960) return 2.8 + 2 * R;
            else return 7.8 + 2 * R;
        }

        /// <summary>
        /// Время совершения заказа
        /// Равномерный закон распределения
        /// </summary>
        /// <returns></returns>
        public static double GetOrderTime() => 2.2 + R;

        static double PlusMinus()
        {
            if (random.Next(0, 1) == 0) return 0.322 * random.NextDouble();
            else return -0.322 * random.NextDouble();
        }
    }
}