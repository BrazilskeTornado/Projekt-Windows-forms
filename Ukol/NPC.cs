using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol
{
    public enum Prace
    {
        Obchodnik,
        Nepritel,
        Obyvatel
    }

    public class NPC : HerniPostava
    {
        public Prace Prace { get; set; }
        public bool JeBoss { get; set; }

        public NPC(string jmeno, Prace prace, bool jeBoss) : base(jmeno)
        {
            Prace = prace;
            JeBoss = jeBoss;
        }

        public NPC(string jmeno, Prace prace) : this(jmeno, prace, false)
        {
        }

        public sealed override void ZmenaPozice(int novaPoziceX, int novaPoziceY)
        {
            base.ZmenaPozice(0, 0);
        }

        public override string ToString()
        {
            string bossInfo = JeBoss ? "BOSS" : "neBOSS";
            return $"{base.ToString()}, Práce: {Prace}, Síla: {bossInfo}";
        }
    }

}
