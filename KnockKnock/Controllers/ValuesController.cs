﻿using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    [RoutePrefix("api/Values")]
    public class ValuesController : ApiController
    {
        [Route("Token")]
        public string Get()
        {
            //string key = "Token";
            //CacheItem cacheItem = MemoryCache.Default.GetCacheItem(key);

            //if (cacheItem != null)
            //{
            //    string result = (string)cacheItem.Value;
            //    return result;
            //}
            //else
            //{
            //string result = TokenCalc();
            //MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(6) });
            return "26d91d08-63b7-4171-a74c-90d9f9b648d5";
            //}
        }
        [Route("Fibonacci")]
        public async Task<long> Get(long n)
        {
            if (n == 0)
                return 0;
            if (n == -1 || n == 1 || n == 2)
                return 1;
            if (n == -2)
                return -1;
            long result = await FibonacciCalc(n);
            return result;
        }
        [Route("TriangleType")]
        public string Get(int a, int b, int c)
        {
            string result = TriangleTypeCalc(a, b, c);
            return result;
        }
        [Route("ReverseWords")]
        public string Get(string sentence)
        {
            string result = ReverseWordsCalc(sentence);
            return result;
        }

        #region code
        public Task<long> FibonacciCalc(long n)
        {
            try
            {
                double numerator = Math.Pow((1 + Math.Sqrt(5)), n) - Math.Pow((1 - Math.Sqrt(5)), n);
                double denominator = Math.Pow(2.0, n) * Math.Sqrt(5.0);
                double tempresult = numerator / denominator;
                double roundedResult = Math.Round(tempresult);
                double result = roundedResult;
                return Task.FromResult((long)result);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string TokenCalc()
        {
            return "26d91d08-63b7-4171-a74c-90d9f9b648d5";
        }
        public string ReverseWordsCalc(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Trim() == "")
            {
                return "";
            }
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                if (charArray.Length==1&& charArray[0].ToString()=="")
                {
                    charArray[0] = ' ';
                }
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
        public string TriangleTypeCalc(int a, int b, int c)
        {
            string result = "Error";
            try
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    result = "Error";
                    return result;
                }
                if (!((long)a + (long)b > (long)c && (long)b + (long)c > (long)a && (long)a + (long)c > (long)b))
                {
                    result = "Error";
                    return result;
                }
                if (a == b && b == c)
                {
                    result = "Equilateral";
                    return result;
                }
                if (a == b || a == c || b == c)
                {
                    result = "Isosceles";
                    return result;
                }
                if (a != b && b != c && c != a)
                {
                    result = "Scalene";
                    return result;
                }
            }
            catch
            {
                throw;
            }
            return result;
        }

        #endregion
    }
}

