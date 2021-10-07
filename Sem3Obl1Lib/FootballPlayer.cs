using System;

namespace Sem3Obl1Lib
{
    public class FootballPlayer
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private int _price { get; set; }
        private int _shirtNumber { get; set; }

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {

            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 4 ) throw new ArgumentException();
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (1 > value || value > 100) throw new ArgumentException();
                _shirtNumber = value;
            }
        }
    }
}
