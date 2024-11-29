using System;
using System.Collections.Generic;
using System.Linq;
namespace Final
{
    public class Class1
    {
        private static string _carInspectionName = "Автоинспекция г. Чита";
        private static string _chiefInspector = "Васильев Василий Иванович";
        private static List<string> _workers = new List<string>() { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        private static Random _random = new Random();


        public static string GetInspector()
        {
            return _chiefInspector;
        }

        public static string GetCarInspection()
        {
            return _carInspectionName;
        }

        public static bool SetInspector(string fullName)
        {
            if (_workers.Contains(fullName))
            {
                _chiefInspector = fullName;
                return true;
            }
            return false;
        }

        public static string GenerateNumber(char symbol, int code = 75)
        {
            int number = _random.Next(1000, 10000); //Генерируем 4-значное число
            return $"{symbol.ToString().ToUpper()}{number}_{code}";
        }

        public static List<string> GetWorker()
        {
            return _workers;
        }

        public static bool AddWorker(string fullName)
        {
            if (!_workers.Contains(fullName))
            {
                _workers.Add(fullName);
                return true;
            }
            return false;
        }
    }
}
