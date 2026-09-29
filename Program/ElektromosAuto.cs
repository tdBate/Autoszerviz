using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumlatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            UzemanyagSzint = 0;
            AkkumulatorSzint = akkumlatorSzint;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel, {AkkumulatorSzint} % töltöttséggel.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            AkkumulatorSzint += 20;
            Console.WriteLine("A jármű szervizelése megtörtént");
        }

        public int AkkumulatorSzint { get => akkumulatorSzint; set => akkumulatorSzint = Math.Clamp(value, 0, 100); }
    }
}
