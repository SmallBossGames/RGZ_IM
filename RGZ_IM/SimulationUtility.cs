using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    class SimulationUtility
    {
        readonly static Random random = new Random();

        static double R => (double)random.Next(int.MaxValue) / int.MaxValue;

        readonly double NextPeopleTime = 1.5;
        readonly double NextPeopleTimeWave = 0.75;
        readonly double NextWaveTime = 360;
        readonly double WaveTime = 90;
        readonly double ServiceTimeDefault = 2.8;
        readonly double ServiceTimeWave = 7.8;
        readonly double OrderTime = 2.2;

        public SimulationUtility(double NextPeopleTime, double NextPeopleTimeWave, double NextWaveTime, double WaveTime, double ServiceTimeDefault, double ServiceTimeWave, double OrderTime)
        {
            this.NextPeopleTime = NextPeopleTime;
            this.NextPeopleTimeWave = NextPeopleTimeWave;
            this.NextWaveTime = NextWaveTime;
            this.WaveTime = WaveTime;
            this.ServiceTimeDefault = ServiceTimeDefault;
            this.ServiceTimeWave = ServiceTimeWave;
            this.OrderTime = OrderTime;
        }        

        /// <summary>
        /// Время прихода следующей заявки
        /// Равномерный закон распределения
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public double GetNextPeopleTime(bool isWave)
        {
            if (isWave == false) return NextPeopleTime + PlusMinus(); // 0.67 человека в минуту
            else return NextPeopleTimeWave + PlusMinus();
        }

        /// <summary>
        /// Количество заявок, пришедших в очередь за 1 раз
        /// Нормальный закон распределения
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public int GetNextPeopleCount(bool isWave)
        {
            if (isWave == false) return random.Next(1, 3);
            else return random.Next(1, 3);
        }

        /// <summary>
        /// Время до возникновения следующей волны
        /// Равномерный закон распределения
        /// </summary>
        public double GetWave() => NextWaveTime-30 + 60 * R;

        /// <summary>
        /// Продолжительность волны
        /// </summary>
        /// <returns></returns>
        public double GetWaveLength() => WaveTime-30 + 60 * R;

        /// <summary>
        /// Время обслуживания заявки
        /// Равномерный закон распределения
        /// </summary>
        /// <returns></returns>
        public double GetServiceTime(double time)
        {
            if (time % 1440 < 960) return ServiceTimeDefault + 2 * R;
            else return ServiceTimeWave + 2 * R;
        }

        /// <summary>
        /// Время совершения заказа
        /// Равномерный закон распределения
        /// </summary>
        /// <returns></returns>
        public double GetOrderTime() => OrderTime + R;

        static double PlusMinus()
        {
            if (random.Next(0, 1) == 0) return 0.322 * random.NextDouble();
            else return -0.322 * random.NextDouble();
        }
    }
}