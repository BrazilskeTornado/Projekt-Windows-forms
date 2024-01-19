using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol
{
    public class HerniPostava
    {
        private string jmeno;
        private int level;
        private int poziceX;
        private int poziceY;

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
            level = 1;
            poziceX = 0;
            poziceY = 0;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Příliš dlouhé jméno!");
                }
                else
                {
                    jmeno = value;
                }
            }
        }

        public int PoziceX
        {
            get { return poziceX; }
        }

        public int PoziceY
        {
            get { return poziceY; }
        }

        public void ZmenaPozice(int novaPoziceX, int novaPoziceY)
        {
            poziceX = novaPoziceX;
            poziceY = novaPoziceY;
        }

        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Level: {level}, Pozice X: {poziceX}, Pozice Y: {poziceY}";
        }
    }
}
