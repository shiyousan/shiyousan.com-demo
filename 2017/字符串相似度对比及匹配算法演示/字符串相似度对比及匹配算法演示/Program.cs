using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串相似度对比及匹配算法演示
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("start-----");
            //string str1 = "男人应该买保险！为什么？没有为什么，谁让你那么重要呢！";
            //string str1 = "刀客到也非恒道也，名可明夜非哼鸣也，为什么？";
            string str1 = "男人必须一定肯定要买保险！为什么？没有为什么，谁让你那么重要呢！";
            string str2 = "男人就得买保险！为什么？没有为什么，谁让你那么重要呢！";
            string str3 = "what your name?";
            string str4 = "who your name?";

            //String.Compare("","",)
            //var result  =FuzzyString.ComparisonMetrics.LevenshteinDistance("1234", "123");
            

            int result = 0;
            //result =FuzzyString.ComparisonMetrics.LevenshteinDistance(str3, str4);
            //Console.WriteLine(result);
            
            Console.WriteLine(CalculatePercent(str1, str2));
            Console.WriteLine(CalculatePercent(str3, str4));
            //Console.WriteLine(MinimumEditDistance.Levenshtein.CalculateDistance(str3, str4, 1));
            //Console.WriteLine(MinimumEditDistance.Levenshtein.CalculateDistance("1234", "123", 1));





            Console.WriteLine("字符串1 {0}", str1);
            Console.WriteLine("字符串2 {0}", str2);

            Console.WriteLine("相似度 {0} %", LevenshteinDistance.Instance.LevenshteinDistancePercent(str1, str2) * 100);


            Console.WriteLine("字符串1 {0}", str3);
            Console.WriteLine("字符串2 {0}", str4);

            Console.WriteLine("相似度 {0} %", LevenshteinDistance.Instance.LevenshteinDistancePercent(str3, str4) * 100);


            Console.WriteLine("done-----");
            Console.ReadKey();
        }

        /// <summary>
        /// 计算字符串相似度
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static decimal CalculatePercent(string str1, string str2)
        {
            int maxLength = str1.Length > str2.Length ? str1.Length : str2.Length;
            int subLength = MinimumEditDistance.Levenshtein.CalculateDistance(str1, str2, 1);
            //return 1 - (decimal)val / maxLenth;
            return 1 - (decimal)subLength / maxLength;
        }
       
    }
}
