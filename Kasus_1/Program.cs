using System;

namespace Kasus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerAxe axe = new PlayerAxe();
            PlayerSword sword = new PlayerSword();
            PlayerBow bow = new PlayerBow();
            PlayerGrimoire grimoire = new PlayerGrimoire();
            PlayerWand wand = new PlayerWand();
            PlayerShield shield = new PlayerShield();
            NPC npc = new NPC();
            MonsterGoblin goblin = new MonsterGoblin();
            MonsterOrc orc = new MonsterOrc();
            MonsterSlime slime = new MonsterSlime();
            MonsterNaga naga = new MonsterNaga();
            MonsterGolem golem = new MonsterGolem();
            MonsterCerberus cerberus = new MonsterCerberus();

            goblin.SatuBarNyawa();
            orc.SatuBarNyawa();
            slime.SatuBarNyawa();
            naga.LimaBarNyawa();
            golem.LimaBarNyawa();
            cerberus.LimaBarNyawa();

            goblin.Berjalan();
            orc.Berjalan();
            slime.Berjalan();
            naga.Terbang();
            golem.Berjalan();
            cerberus.Berjalan();

            goblin.Menyerang();
            orc.Menyerang();
            slime.Menyerang();
            naga.Menyerang();
            golem.Menyerang();
            cerberus.Menyerang();

            goblin.KillPlayer();
            orc.KillPlayer();
            slime.KillPlayer();
            naga.KillPlayer("Dragon Icy Breath");
            golem.KillPlayer("Poison Spore");
            cerberus.KillPlayer("Laser Black Hole");

            goblin.Gugur();
            orc.Gugur();
            slime.Gugur();
            naga.Gugur();
            golem.Gugur();
            cerberus.Gugur();



        }
    }
}
