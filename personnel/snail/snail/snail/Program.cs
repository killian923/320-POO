using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;

            Snail snail = new Snail();
            //Snail snail = new Snail("  ____@_ö", " _______", 300 ,30);


            for (i = 0; i < snail._life; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(snail._formLife);
                Thread.Sleep(snail._speed);
            }
            if (i == snail._life)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(snail._formDead);
            }
            Console.Read();
        }
    }
    class Snail
    {
        public string _formLife;
        public string _formDead;
        public int _speed;
        public int _life;

        public Snail()
        {
            this._formLife = "  __@_ö";
            this._formDead = "  _____";
            this._speed = 250;
            this._life = 21;
        }
        public Snail(string form, string formDead, int speed, int life)
        {
            _formLife = form;
            _formDead = formDead;
            _speed = speed;
            _life = life;
        }

    }
}