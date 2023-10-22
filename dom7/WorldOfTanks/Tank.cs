using System;

namespace dom7
{
    public class Tank
    {
        private string tankName;
        private int ammunition;
        private int armor;
        private int mobility;

        public Tank(string name)
        {
            tankName = name;
            Random random = new Random();
            ammunition = random.Next(0, 101);
            armor = random.Next(0, 101);
            mobility = random.Next(0, 101);
        }

        public string GetTankParameters()
        {
            return $"{tankName}: Ammo={ammunition}, Armor={armor}, Mobility={mobility}";
        }

        public static bool operator ^(Tank tank1, Tank tank2)
        {
            int winCriteria = 0;

            if (tank1.ammunition > tank2.ammunition)
                winCriteria++;
            if (tank1.armor > tank2.armor)
                winCriteria++;
            if (tank1.mobility > tank2.mobility)
                winCriteria++;

            return winCriteria >= 2;
        }
    }
}
