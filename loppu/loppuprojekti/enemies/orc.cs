namespace loppuprojekti
{
    internal class orc : enemy
    {
        iron_armor iron_armor = new iron_armor();
        iron_sword iron_sword = new iron_sword();

        public orc()
        {
            hp = 50f;
            dmg = 7.5f;
            levels = 8;
            drops = new List<Equipment>
            {
                iron_armor,
                iron_sword
            };
        }
    }
}
