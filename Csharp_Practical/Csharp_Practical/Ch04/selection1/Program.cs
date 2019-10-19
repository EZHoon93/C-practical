﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ch0401 {
//    class Program {
//        static void Main(string[] args) {
//        }
//    }

//    class SampleCode  {

//        public void Idiom01() {
//            var age = 25;
//            Console.WriteLine(age);
//        }

//        public void Idiom02() {
//            int age;
//            age = 25;
//            Console.WriteLine(age);
//        }

//        public void Idiom03() {
//            var langs = new string[] { "C#", "VB", "C++", };
//            var nums = new List<int> { 10, 20, 30, 40, };

//            foreach (var lang in langs)
//                Console.WriteLine(lang);

//            foreach (var n in nums)
//                Console.WriteLine(n);
//        }

//        public void Idiom04() {
//            string[] langs = new string[3];
//            langs[0] = "C#";
//            langs[1] = "VB";
//            langs[2] = "C++";
//            List<int> nums = new List<int>();
//            nums.Add(10);
//            nums.Add(20);
//            nums.Add(30);
//            nums.Add(40);

//            foreach (var lang in langs)
//                Console.WriteLine(lang);

//            foreach (var n in nums)
//                Console.WriteLine(n);

//        }

//        public void Idiom05() {
//            var dict = new Dictionary<string, string>() {
//                { "kr", "한국어" },
//                { "en", "영어" },
//                { "es", "스페인어" },
//                { "de", "독일어" },
//            };

//            foreach (var item in dict)
//                Console.WriteLine($"{item.Key} {item.Value}");
//        }


//        public void Idiom06() {
//            var dict = new Dictionary<string, string>() {
//                ["kr"] = "한국어",
//                ["en"] = "영어",
//                ["es"] = "스페인어",
//                ["de"] = "독일어",
//            };

//            foreach (var item in dict)
//                Console.WriteLine($"{item.Key} {item.Value}");
//        }

//        public void Idiom07() {
//            var dict = new Dictionary<string, string>();
//            dict["ko"] = "한국어";
//            dict["en"] = "영어";
//            dict["es"] = "스페인어";
//            dict["de"] = "독일어";

//            foreach (var item in dict)
//                Console.WriteLine($"{item.Key} {item.Value}");
//        }

//        public void Idiom08() {
//            var person = new Person {
//                Name = "홍길동",
//                Birthday = new DateTime(1995, 11, 23),
//                PhoneNumber = "012-3456-7890",
//            };

//            Console.WriteLine($"{person.Name} {person.Birthday} {person.PhoneNumber}");
//        }

//        public void Idiom09() {
//            Person person = new Person();
//            person.Name = "홍길동";
//            person.Birthday = new DateTime(1995, 11, 23);
//            person.PhoneNumber = "012-3456-7890";

//            Console.WriteLine($"{person.Name} {person.Birthday} {person.PhoneNumber}");
//        }

//    }

//}
