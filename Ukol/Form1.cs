using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void Main()
        {
            // hráč
            Hrac hrac = new Hrac("Hráč 1", "Kouzelník", Oblicej.VelkyNos, Vlasy.Drdol, BarvaVlasu.Kashtanova);
            Console.WriteLine("Hráč:");
            Console.WriteLine(hrac);

            // NPCs
            NPC npc1 = new NPC("Obchodník Bob", Prace.Obchodnik, false);
            Console.WriteLine("\nNPC 1:");
            Console.WriteLine(npc1);

            NPC npc2 = new NPC("Nepřítel X", Prace.Nepritel, true);
            Console.WriteLine("\nNPC 2:");
            Console.WriteLine(npc2);
        }
    }
}
