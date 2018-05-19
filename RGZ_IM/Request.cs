using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    class Request
    {
        Random random = new Random();

        /// <summary>
        /// Генерация интервала прихода заявок
        /// </summary>
        /// <returns></returns>
        double GetInterval() => 0.5 + PlusMinus();

        /// <summary>
        /// Уйдёт ли заявка?
        /// 0, 1, 2, 3, 4, 5, 6, 7, 8 - проходит в очередь, 9 - отказ
        /// </summary>
        /// <returns></returns>
        int IsRequestDenied() => random.Next(0, 9);

        /// <summary>
        /// Генерация события волны
        /// </summary>
        /// <param Матожидание="math"></param>
        /// <returns></returns>
        double GetWave(double math) => -math * Math.Log(random.NextDouble());

        /// <summary>
        /// Генерация продолжительности волны
        /// </summary>
        /// <returns></returns>
        double GetWaveTime() => 90 + random.Next(0, 30);

        /// <summary>
        /// Генерация количества пришедших одновременно заявок
        /// </summary>
        /// <returns></returns>
        int GetRequest(bool isWave)
        {
            if (isWave == false) return random.Next(0, 6);
            else return random.Next(3, 6);
        }

        /// <summary>
        /// Получить время обслуживания заявки
        /// Здесь будет отправляться времени суток и в зависимости от него будет генерироваться время обслуживания
        /// </summary>
        /// <param Время суток="time"></param>
        /// <returns></returns>
        double GetWorkTime(double time)
        {
            if (time < 960) return 7 + PlusMinusWork(time);
            else return 12 + PlusMinusWork(time);
        }

        /// <summary>
        /// Генерация разброса для интервала
        /// </summary>
        /// <returns></returns>
        double PlusMinus()
        {
            if (random.Next(0, 1) == 0) return random.NextDouble() / 3;
            else return -random.NextDouble() / 3;
        }

        /// <summary>
        /// Генерация разброса для времени обслуживания заявки в зависимости от времени суток
        /// </summary>
        /// <param Время суток="time"></param>
        /// <returns></returns>
        double PlusMinusWork(double time)
        {
            if (time < 16)
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