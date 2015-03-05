using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MethodNOD
{
    public static class AlgorithmNOD
    {
        public static int MethodEvklida(int a, int b, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            while (b != 0)
                b = a % (a = b);
            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return a;
        }

        public static int MethodEvklidaThreeArgum(int a, int b, int c, out TimeSpan time)
        {
            TimeSpan time1;
            int nodTwo = MethodEvklida(a, b, out time1);
            int nodThree = MethodEvklida(nodTwo, c, out time);
            time += time1;
            return nodThree;
        }

        public static int MethodEvklidaParamsArgum(out TimeSpan time, params int[] value)
        {
            int temp = value[0];
            int resNod = 0;
            TimeSpan tempTime, resTime = new TimeSpan(0, 0, 0);
            for (int i = 1; i < value.Length; i++)
            {
                resNod = MethodEvklida(temp, value[i], out tempTime);
                temp = resNod;
                resTime += tempTime;
            }
            time = resTime;
            return resNod;
        }

        public static int MethodSchteina(int a, int b, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int k;
            if (a == 0 || b == 0)
            {
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return a | b;
            }
            for (k = 0; ((a | b) & 1) == 0; ++k)
            {
                a >>= 1;
                b >>= 1;
            }
            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)
                    b >>= 1;
                if (a < b)
                    b -= a;
                else
                {
                    int diff = a - b;
                    a = b;
                    b = diff;
                }
                b >>= 1;
            } while (b != 0);

            stopWatch.Stop();
            time = stopWatch.Elapsed;
            return a << k;
        }

        public static int MethodSchteinaThreeArgum(int a, int b, int c, out TimeSpan time)
        {
            TimeSpan time1;
            int nodTwo = MethodSchteina(a, b, out time1);
            int nodThree = MethodSchteina(c, nodTwo, out time);
            time += time1;
            return nodThree;
        }

        public static int MethodSchteinaParamsArgum(out TimeSpan time, params int[] value)
        {
            int temp = value[0];
            int resNod = 0;
            TimeSpan tempTime, resTime = new TimeSpan(0, 0, 0);
            for (int i = 1; i < value.Length; i++)
            {
                resNod = MethodSchteina(temp, value[i], out tempTime);
                temp = resNod;
                resTime += tempTime;
            }
            time = resTime;
            return resNod;
        }
    }
}
