using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    static class SimaulationUtility
    {
        readonly static Random random = new Random();

        /// <summary>
        /// Время прихода следующей заявки
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static double GetNextPeopleTime(bool isWave)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Количество заявок, пришедших в очередь за 1 раз
        /// </summary>
        /// <param name="isWave">Режим волны</param>
        public static int GetNextPeopleCount(bool isWave)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Время до возникновения следующей волны
        /// </summary>
        public static double GetWave()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Продолжительность волны
        /// </summary>
        /// <returns></returns>
        public static double GetWaveLength()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Время обслуживания заявки
        /// </summary>
        /// <returns></returns>
        public static double GetServiceTime()
        {
            throw new NotImplementedException();
        }
    }
}