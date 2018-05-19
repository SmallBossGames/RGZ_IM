using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_IM
{
    public class Request
    {
        Random random = new Random();

        /// <summary>
        /// Генерация интервала прихода заявок
        /// </summary>
        /// <returns></returns>
        public double GetInterval() => 0.5 + PlusMinus();

        /// <summary>
        /// Генерация заявок
        /// </summary>
        /// <returns></returns>
        public int GetRequest() => random.Next(0, 6);

        /// <summary>
        /// Уйдёт ли заявка?
        /// 0, 1, 2, 3, 4, 5, 6, 7, 8 - проходит в очередь, 9 - отказ
        /// </summary>
        /// <returns></returns>
        public int IsRequestDenied() => random.Next(0, 9);

        /// <summary>
        /// Пояснений не требуется
        /// </summary>
        /// <returns></returns>
        double PlusMinus()
        {
            if (random.Next(0, 1) == 0) return random.NextDouble() / 3;
            else return -random.NextDouble() / 3;
        }
    }
}