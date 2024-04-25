namespace loppuprojekti
{
    internal class goblin : enemy
    {
        gobo_armor gobo_armor = new gobo_armor();
        wood_sword wood_sword = new wood_sword();

        public goblin()
        {
            hp = 15f;
            dmg = 2.5f;
            levels = 4;
            drops = new List<Equipment>
            {
                gobo_armor,
                wood_sword
            };
        }
    }
}