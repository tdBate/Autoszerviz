using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("Jármű felvétele sikeres");
        }

        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
                else { Console.WriteLine($"A {jarmu.Rendszam} szervizelése jelenleg nem szükséges."); }
            }
        }
    }
}
