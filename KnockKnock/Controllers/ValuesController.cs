using System;
using System.Runtime.Caching;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    [RoutePrefix("api/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values/Token
        [Route("Token")]
        public string Get()
        {
            string key = "Token";
            CacheItem cacheItem = MemoryCache.Default.GetCacheItem(key);

            if (cacheItem != null)
            {
                string result = (string)cacheItem.Value;
                return result;
            }
            else
            {
                string result = TokenCalc();
                MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(6) });
                return result;
            }
        }
        // GET api/values/Fibonacci?n=5
        [Route("Fibonacci")]
        public long Get(long n)
        {
            string key = string.Format("TriangleType-{0}", n);
            CacheItem cacheItem = MemoryCache.Default.GetCacheItem(key);

            if (cacheItem != null)
            {
                long result = (long)cacheItem.Value;
                return result;
            }
            else
            {
                long result = FibonacciCalc(n);
                MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(6) });
                return result;
            }
        }
        // GET api/values/TriangleType?a=5&b=5&c=5
        [Route("TriangleType")]
        public string Get(int a, int b, int c)
        {
            string key = string.Format("TriangleType-{0}-{1}-{2}", a, b, c);
            CacheItem cacheItem = MemoryCache.Default.GetCacheItem(key);

            if (cacheItem != null)
            {
                string result = (string)cacheItem.Value;
                return result;
            }
            else
            {
                string result = TriangleTypeCalc(a, b, c);
                MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(6) });
                return result;
            }
        }
        // GET api/values/ReverseWords?sentence=taher mohamed abdelbaky
        [Route("ReverseWords")]
        public string Get(string sentence)
        { 
            string key = string.Format("ReverseWords-{0}", sentence);
            CacheItem cacheItem = MemoryCache.Default.GetCacheItem(key);

            if (cacheItem != null)
            {
                string result = (string)cacheItem.Value;
                return result;
            }
            else
            {
                string result = ReverseWordsCalc(sentence);
                MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(6) });
                return result;
            }
        }
        public long FibonacciCalc(long n)
        {
            double numerator = Math.Pow((1.0 + Math.Sqrt(5.0)), n) - Math.Pow((1.0 - Math.Sqrt(5.0)), n);
            double denominator = Math.Pow(2.0, n) * Math.Sqrt(5.0);
            double result = numerator / denominator;

            double roundedResult = Math.Round(result);

            return (long)roundedResult;
        }
        public string TokenCalc()
        {
            return "26d91d08-63b7-4171-a74c-90d9f9b648d5";
        }
        public string ReverseWordsCalc(string s)
        {
            if (s.Trim() == "")
            {
                return "";
            }
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
        public string TriangleTypeCalc(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isosceles";
            }
            else if (a != b && b != c && c != a)
            {
                return "Scalene";
            }
            else
            {
                return "Error";
            }
        }

        //#endregion
    }
}
