using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            // 짝수 홀수 구하기
            Console.Write("숫자 입력: ");
            var input = int.Parse(Console.ReadLine());
            if(input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else
            {
                Console.WriteLine("홀수입니다!");
            }
            Console.WriteLine();

            // 현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year + "년");
            Console.WriteLine(DateTime.Now.Month + "월");
            Console.WriteLine(DateTime.Now.Day + "일");
            Console.WriteLine(DateTime.Now.Hour + "시");
            Console.WriteLine(DateTime.Now.Minute + "분");
            Console.WriteLine(DateTime.Now.Second + "초");

        }
    }
}
