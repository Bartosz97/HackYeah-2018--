using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Models;

namespace HackYeah_2018_.LuckyPointsGenerator
{
    public class PointGenerator
    {
        private const float MinLongi = 15.426517f;
        private const float MinLati = 51.123867f;
        private const float MaxLongi = 22.546244f;
        private const float MaxLati = 54.090532f;

        public class Ticket
        {
            public float _longi;
            public float _lati;
            public User _user;
            private readonly Random random = new System.Random();

            public Ticket(float _minLongi, float _minLati, float _maxLongi, float _maxLati)
            {
                this._longi = (float)(random.NextDouble() * (_maxLongi - _minLongi)) + _minLongi;
                this._lati = (float)(random.NextDouble() * (_maxLati - _minLati)) + _minLati;

                this._user = new User();
                this._user.Id = random.Next(100, 10000);
                this._user.Number = random.Next(111111, 666666);
          //      this._user.Name = RandomString(8);
            }

            public Ticket()
            {
                this._longi = -1;
                this._lati = -1;

                this._user = new User();
                this._user.Id = random.Next(100, 10000);
                this._user.Number = random.Next(111111, 666666);
                this._user.Name = "BlankUser";
            }

            //public void WriteTicket()
            //{
            //    Console.WriteLine("ID: " + _user.Id + " Number: "
            //        + _user.Number + " Name: " + _user.Name
            //        + " Longi: N*" + _longi + " Lati: E*" + _lati);
            //}

            //public string RandomString(int length)
            //{
            //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //    return new string(Enumerable.Repeat(chars, length)
            //      .Select(s => s[random.Next(s.Length)]).ToArray());
            //}
        }

        private List<Ticket> _luckyPoint;
        private List<Ticket> _players;

        public PointGenerator()
        {
            _players = new List<Ticket>();
            _luckyPoint = new List<Ticket>();
        }

        public List<Ticket> GenerateLuckyPoint(int value)
        {
            for (int i = 0; i < value; i++)
            {
                _luckyPoint.Add(new Ticket(MinLongi, MinLati, MaxLongi, MaxLati));
            }
            return _luckyPoint;
        }


        //public List<Ticket> GeneratePlayers(int value)
        //{
        //    for (int i = 0; i < value; i++)
        //    {
        //        _players.Add(new Ticket(MinLongi, MinLati, MaxLongi, MaxLati));
        //    }
        //    return _players;
        //}

        //public void WritePlayers()
        //{
        //    int i = 0;

        //    foreach (var iterator in _players)
        //    {
        //        Console.Write("Player " + (++i));
        //        iterator.WriteTicket();
        //    }
        //}

        //public void WriteLuckyPoints()
        //{
        //    int i = 0;

        //    foreach (var iterator in _luckyPoint)
        //    {
        //        Console.WriteLine("Point " + (++i) + ": " + iterator._longi + "*N, " + iterator._lati + "*E");
        //    }
        //}


        internal class PointFinder
        {
            public Ticket FindWinner(Ticket luckyPoint, List<Ticket> tickets)
            {
                double bestDistance = double.MaxValue;
                var winningUser = new Ticket();
                double tmpDistance;
                foreach (var ticket in tickets)
                {
                    tmpDistance = AbsolutDistance(ticket, luckyPoint);
                    Console.WriteLine("Dystans do luckyPointa: " + tmpDistance + " ID: " + ticket._user.Id);
                    if (tmpDistance < bestDistance)
                    {
                        bestDistance = tmpDistance;
                        winningUser = ticket;
                    }
                }
                return winningUser;
            }

            private double AbsolutDistance(Ticket ticket, Ticket luckyPoint)
            {
                return Math.Sqrt(Math.Pow(luckyPoint._lati - ticket._lati, 2)
                    + Math.Pow(luckyPoint._longi - ticket._longi, 2));
            }
        }

        //internal class Program
        //{
        //    private static void Main(string[] args)
        //    {
        //        Console.WriteLine("Hello World!");

        //        var generator = new PointGenerator();
        //        var _tickets = generator.GeneratePlayers(10);
        //        var _luckyPoints = generator.GenerateLuckyPoint(1);
        //      //  generator.WritePlayers();
        //    //    generator.WriteLuckyPoints();

        //        var pointFinder = new PointFinder();
        //        var winner = new Ticket();
        //        foreach (var luckyPoint in _luckyPoints)
        //        {
        //            winner = pointFinder.FindWinner(luckyPoint, _tickets);
        //            Console.WriteLine("ID zwyciezcy: " + winner._user.Id);
        //        }

        //        Console.ReadKey();
        //    }
        //}

    }
}
