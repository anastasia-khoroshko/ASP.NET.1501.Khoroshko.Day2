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
        public static int MethodEvklida(out long time, int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            while (b != 0)
                b = a % (a = b);
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return a;
        }

        public static int MethodEvklidaThreeArgum(out long time, int a, int b, int c)
        {
            long time1;
            int nodTwo = MethodEvklida(out time1,a, b);
            int nodThree = MethodEvklida(out time,nodTwo, c);
            time += time1;
            return nodThree;
        }

        public static int MethodEvklidaParamsArgum(out long time, params int[] value)
        {
            int temp = value[0];
            int resNod = 0;
            long tempTime, resTime =0;
            for (int i = 1; i < value.Length; i++)
            {
                resNod = MethodEvklida(out tempTime,temp, value[i]);
                temp = resNod;
                resTime += tempTime;
            }
            time = resTime;
            return resNod;
        }

        public static int MethodSchteina(out long time,int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int k;
            if (a == 0 || b == 0)
            {
                stopWatch.Stop();
                time = stopWatch.ElapsedTicks;
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
            time = stopWatch.ElapsedTicks;
            return a << k;
        }

        public static int MethodSchteinaThreeArgum(out long time, int a, int b, int c)
        {
            long time1;
            int nodTwo = MethodSchteina(out time1,a, b);
            int nodThree = MethodSchteina(out time,c, nodTwo);
            time += time1;
            return nodThree;
        }

        public static int MethodSchteinaParamsArgum(out long time, params int[] value)
        {
            int temp = value[0];
            int resNod = 0;
            long tempTime, resTime = 0;
            for (int i = 1; i < value.Length; i++)
            {
                resNod = MethodSchteina(out tempTime,temp, value[i]);
                temp = resNod;
                resTime += tempTime;
            }
            time = resTime;
            return resNod;
        }
    }
}
