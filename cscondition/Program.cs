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
        }
    }
}
