using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam
        {
            get => rendszam; set
            {
                if (string.IsNullOrEmpty(value)) { rendszam = "ISMERETLEN"; }
                else { rendszam = value; }
            }
        }

        public int Kor { get => kor; set => kor = Math.Clamp(value, 0, 50); }

        public int KilometerOra
        {
            get => kilometerOra; set
            {
                if (value <= 0) { kilometerOra = 0; }
                else { kilometerOra = value; }
            }
        }

        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = Math.Clamp(value, 0, 100); }

        public bool SzervizSzukseges { get => (bool)(KilometerOra >= 200000); }


        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
            Console.WriteLine("A jármű szervizelése megtörtént");
        }

    }
}
