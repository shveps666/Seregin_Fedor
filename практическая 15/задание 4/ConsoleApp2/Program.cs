using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_Стиль2
{
    interface ICanAttack
    {
        void PerformAttack();
    }

    interface ICanHeal
    {
        void PerformHeal();
    }

    class Knight : ICanAttack
    {
        public void PerformAttack()
        {
            Console.WriteLine("воин нападает");
        }
    }

    class Sorcerer : ICanAttack, ICanHeal
    {
        public void PerformAttack()
        {
            Console.WriteLine("маг нападает");
        }

        public void PerformHeal()
        {
            Console.WriteLine("маг лечит");
        }
    }

    class Program
    {
        static void Main()
        {
            var units = new List<object>
            {
                new Knight(),
                new Sorcerer()
            };

            Console.WriteLine("=== Атакующие персонажи ===");
            units.ForEach(unit =>
            {
                if (unit is ICanAttack atk)
                    atk.PerformAttack();
            });

            Console.WriteLine("\n=== Исцеляющие персонажи ===");
            units.ForEach(unit =>
            {
                if (unit is ICanHeal heal)
                    heal.PerformHeal();
            });
        }
    }
}
