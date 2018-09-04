using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DESO
{
    public class FileHandler
    {
        public List<Dungeon> ReadFromFile(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + "/dungeons.xml"))
            {
                CreateNewDungeonFile(path + "/dungeons.xml");
            }

            using (var stream = File.OpenRead(path + "/dungeons.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
                return (List<Dungeon>) xmlSerializer.Deserialize((stream));
            }
        }

        public void WriteToFile(string path, List<Dungeon> list)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + "/dungeons.xml"))
            {
                CreateNewDungeonFile(path + "/dungeons.xml");
                return;
            }

            using (var stream = File.OpenWrite(path + "/dungeons.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
                xmlSerializer.Serialize(stream, list);
                stream.Close();
            }
        }

        private void CreateNewDungeonFile(string path)
        {
            using (FileStream stream = File.OpenWrite(path))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
                xmlSerializer.Serialize(stream, GetFreshDungeonList());
                stream.Close();
            }
        }

        private List<Dungeon> GetFreshDungeonList()
        {
            List<Dungeon> createdDungeons = new List<Dungeon>
            {
                //Ebonheart Pact Group Dungeons
                new Dungeon("Pilzgrotte I", "Goblin Slayer", 0, 450, "Dreugh Slayer", 0, 50),
                new Dungeon("Fungal Grotto II", "Arachnid slayer", 0, 200, "Obsidian Slayer", 0, 425),
                new Dungeon("Darkshade Caverns I", "Kwama Slayer", 0, 300, "Pit Rat Slayer", 0, 175),
                new Dungeon("Darkshade Caverns II", "Construct Slayer", 0, 800, "Kwama Slayer", 0, 200),
                new Dungeon("Arx Corinium", "Snake Slayer", 0, 175, "Lamia Slayer", 0, 400),
                new Dungeon("Direfrost Keep", "Draugr Slayer", 0, 325, "Frozen Skeleton Slayer", 0, 350),
                new Dungeon("Blessed Curcible", "Durzog Slayer", 0, 150, "Gladiator Slayer", 0, 500),

                //Daggerfall Covenant Group Dungeons
                new Dungeon("Spindleclutch I", "Corrupted Slayer", 0, 350, "Spider Slayer", 0, 600),
                new Dungeon("Spindleclutch II", "Flesh Atronach Conquerer", 0, 65, "Thrall Slayer", 0, 220),
                new Dungeon("Wayrest Sewers I", "Skeever Slayer", 0, 800, "Mercenary Slayer", 0, 500),
                new Dungeon("Wayrest Sewers II", "Colossus Slayer", 0, 40, "Zombie Slayer", 0, 350),
                new Dungeon("Crypt of Hearts", "Skeleton Slayer", 0, 400, "Crypt Zombie Slayer", 0, 400),
                new Dungeon("Volenfell", "Dwarven Construct Slayer", 0, 300, "Treasure Hunter Slayer", 0, 250),
                new Dungeon("Blackheart Haven", "Harpy Slayer", 0, 400, "Pirate Slayer", 0, 500),

                //Aldmeri Dominion Group Dungeons
                new Dungeon("Banished Cells I", "Bonebreaker", 0, 350, "Daedra Slayer I", 0, 100),
                new Dungeon("Banished Celss II", "Rillis Dremora Slayer", 0, 300, "Bonebreaker II", 0, 120),
                new Dungeon("Elden Hollow I", "Orc Slayer", 0, 400, "Alit Slayer", 0, 100),
                new Dungeon("Elden Hollow II", "Lurcher Slayer", 0, 60, "Banekin Slayer", 0, 140),
                new Dungeon("City of Ash I", "Banekin Slayer", 0, 550, "Flame Atronach Slayer", 0, 60),
                new Dungeon("City of Ash II", "Flame Colossus Slayer", 0, 50, "Dremora Slayer", 0, 300),
                new Dungeon("Tempest Island", "Lamia Slayer", 0, 600, "Sea Viper Slayer", 0, 550),
                new Dungeon("Selene’s Web", "Bosmer Slayer", 0, 250, "Spider Slayer", 0, 250),

                //Other & DLC Group Dungeons
                new Dungeon("Vaults of Madness", "Dremora Slayer", 0, 150, "Ferral Shriven Slayer", 0, 750),
                new Dungeon("White-Gold Tower", "Daedroth Slayer", 0, 50, "Horn Breaker", 0, 100),
                new Dungeon("Imperial City Prison", "Mindshriven Slayer", 0, 300, "Watcher Slayer", 0, 50),
                new Dungeon("Ruins of Mazzatun", "Xit-Xaht Slayer", 0, 600, "Sludge-Slinger Slayer", 0, 50),
                new Dungeon("Cradle of Shadows", "Iconoclast", 0, 50, "Spider Cult Slayer", 0, 600),
                new Dungeon("Falkreath Hold", "Minotaur Tramplar Slayer", 0, 60, "Dreadhorn Mage Slayer", 0, 150),
                new Dungeon("Bloodroot Forge", "Dreadhorn Warrior Slayer", 0, 300, "Firehide Slayer", 0, 50),
                new Dungeon("Scalecaller Peak", "Ogre Slayer", 0, 50, "Veteran Cultist Slayer", 0, 120),
                new Dungeon("Fang Lair", "Necromancer Slayer", 0, 350, "Skeleton Slayer", 0, 500)
            };

            return createdDungeons;
        }
    }
}