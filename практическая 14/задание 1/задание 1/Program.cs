using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка...");
        }
    }
    public class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("бам-бам!");
        }
    }
    public class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("бум-бум!");
        }
    }

    class Program
    {
        static void Main()
        {
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var instrument in band)
            {
                instrument.Play();
            }
        }
    }
}
