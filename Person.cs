﻿using System;

namespace Practice02
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime? _dateOfBirth;
        private readonly string[] _westernSigns = { "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Saggitarius", "Capricorn" };
        private readonly string[] _chineseSigns = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _dateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _dateOfBirth = null;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _email = null;
        }

        public bool IsAdult
        {
            get
            {
                var today = DateTime.Today;
                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (_dateOfBirth?.Year * 100 + _dateOfBirth?.Month) * 100 + _dateOfBirth?.Day;
                return (a - b) / 10000 >= 18;
            }
        }

        public string SunSign
        {
            get
            {
                int day = _dateOfBirth?.Day ?? DateTime.Today.DayOfYear;
                int month = _dateOfBirth?.Month ?? DateTime.Today.Month;
                //Not used variable

                if (month == 1 || month == 4)
                    return day >= 20 ? _westernSigns[month - 1] : (month == 1 ? _westernSigns[_westernSigns.Length - 1] : _westernSigns[month - 2]);
                if (month == 2)
                    return day >= 19 ? _westernSigns[month - 1] : _westernSigns[month - 2];

                if (month == 3 || month == 5 || month == 6)
                    return day >= 21 ? _westernSigns[month - 1] : _westernSigns[month - 2];

                if (month == 7 || month == 8 || month == 9 || month == 10)
                    return day >= 23 ? _westernSigns[month - 1] : _westernSigns[month - 2];

                return day >= 22 ? _westernSigns[month - 1] : _westernSigns[month - 2];
            }
        }

        public string ChineseSign
        {
            get
            {
                var date = _dateOfBirth?.Year ?? DateTime.Today.Year;
                return _chineseSigns[(date - 5) % 12];
            }
        }

        public bool IsBirthday
        {
            get
            {
                return _dateOfBirth?.DayOfYear == DateTime.Today.DayOfYear;
            }
        }
    }
}
