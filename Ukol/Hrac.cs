using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol
{
        public enum Oblicej
        {
            VelkyNos,
            Ushoplesk,
            Makeup
        }

        public enum Vlasy
        {
            Drdol,
            Culik,
            Pleska
        }

        public enum BarvaVlasu
        {
            Kashtanova,
            Blond,
            Cervena
        }

        public class Hrac : HerniPostava
        {
            private string specializace;
            private Oblicej oblicej;
            private Vlasy vlasy;
            private BarvaVlasu barvaVlasu;
            public int XP { get; private set; }

            public Hrac(string jmeno, string specializace, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvaVlasu) : base(jmeno)
            {
                Specializace = specializace;
                this.oblicej = oblicej;
                this.vlasy = vlasy;
                this.barvaVlasu = barvaVlasu;
                XP = 0;
            }

            public string Specializace
            {
                get { return specializace; }
                set
                {
                    string[] povoleneSpecializace = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                    if (Array.Exists(povoleneSpecializace, s => s.Equals(value, StringComparison.OrdinalIgnoreCase)))
                    {
                        specializace = value;
                    }
                    else
                    {
                        Console.WriteLine("Neplatná specializace!");
                    }
                }
            }

            public void PridatXP(int pridaneXP)
            {
                XP += pridaneXP;
                int prahXP = 100 * Level;
                while (XP >= prahXP)
                {
                    Level++;
                    XP -= prahXP;
                    prahXP = 100 * Level;
                }
            }

            public override string ToString()
            {
                return base.ToString() +
                    $", Specializace: {Specializace}, Obličej: {oblicej}, Vlasy: {vlasy}, Barva vlasů: {barvaVlasu}, XP: {XP}";
            }
        }
    }