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

            var stream = File.Open((path + "/dungeons.xml"), FileMode.Create);
            var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
            xmlSerializer.Serialize(stream, list);
            stream.Close();
        }

        public void ReCreateDungeonFile(string path)
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

            File.Delete(path + "/dungeons.xml");
            CreateNewDungeonFile(path + "/dungeons.xml");
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
                new Dungeon("Pilzgrotte II", "Arachnid slayer", 0, 200, "Obsidian Slayer", 0, 425),
                new Dungeon("Dunkelschattenkavernen I", "Kwama Slayer", 0, 300, "Pit Rat Slayer", 0, 175),
                new Dungeon("Dunkelschattenkavernen II", "Construct Slayer", 0, 800, "Kwama Slayer", 0, 200),
                new Dungeon("Arx Corinium", "Snake Slayer", 0, 175, "Lamia Slayer", 0, 400),
                new Dungeon("Burg Grauenfrost", "Draugr Slayer", 0, 325, "Frozen Skeleton Slayer", 0, 350),
                new Dungeon("Gesegnete Feuerprobe", "Durzog Slayer", 0, 150, "Gladiator Slayer", 0, 500),

                //Daggerfall Covenant Group Dungeons
                new Dungeon("Spindeltiefen I", "Corrupted Slayer", 0, 350, "Spider Slayer", 0, 600),
                new Dungeon("Spindeltiefen II", "Flesh Atronach Conquerer", 0, 65, "Thrall Slayer", 0, 220),
                new Dungeon("Kanalisation von Wegesruh I", "Skeever Slayer", 0, 800, "Mercenary Slayer", 0, 500),
                new Dungeon("Kanalisation von Wegesruh II", "Colossus Slayer", 0, 40, "Zombie Slayer", 0, 350),
                new Dungeon("Krypta der Herzen", "Skeleton Slayer", 0, 400, "Crypt Zombie Slayer", 0, 400),
                new Dungeon("Volenfell", "Dwarven Construct Slayer", 0, 300, "Treasure Hunter Slayer", 0, 250),
                new Dungeon("Schwarzherz-Unterschlupf", "Harpy Slayer", 0, 400, "Pirate Slayer", 0, 500),

                //Aldmeri Dominion Group Dungeons
                new Dungeon("Verbannungszellen I", "Bonebreaker", 0, 350, "Daedra Slayer I", 0, 100),
                new Dungeon("Verbannungszellen II", "Rillis Dremora Slayer", 0, 300, "Bonebreaker II", 0, 120),
                new Dungeon("Eldengrund I", "Orc Slayer", 0, 400, "Alit Slayer", 0, 100),
                new Dungeon("Eldengrund II", "Lurcher Slayer", 0, 60, "Banekin Slayer", 0, 140),
                new Dungeon("Stadt der Asche I", "Banekin Slayer", 0, 550, "Flame Atronach Slayer", 0, 60),
                new Dungeon("Stadt der Asche II", "Flame Colossus Slayer", 0, 50, "Dremora Slayer", 0, 300),
                new Dungeon("Orkaninsel", "Lamia Slayer", 0, 600, "Sea Viper Slayer", 0, 550),
                new Dungeon("Selene's Netz", "Bosmer Slayer", 0, 250, "Spider Slayer", 0, 250),

                //Other & DLC Group Dungeons
                new Dungeon("Kammern des Wahnsinns", "Dremora Slayer", 0, 150, "Ferral Shriven Slayer", 0, 750),
                new Dungeon("Weiß-Gold Turm", "Daedroth Slayer", 0, 50, "Horn Breaker", 0, 100),
                new Dungeon("Gefängnis der Kaiserstadt", "Mindshriven Slayer", 0, 300, "Watcher Slayer", 0, 50),
                new Dungeon("Ruinen von Mazzatun", "Xit-Xaht Slayer", 0, 600, "Sludge-Slinger Slayer", 0, 50),
                new Dungeon("Wiege der Schatten", "Iconoclast", 0, 50, "Spider Cult Slayer", 0, 600),
                new Dungeon("Falkenring", "Minotaur Tramplar Slayer", 0, 60, "Dreadhorn Mage Slayer", 0, 150),
                new Dungeon("Blutquellschmiede", "Dreadhorn Warrior Slayer", 0, 300, "Firehide Slayer", 0, 50),
                new Dungeon("Hort der Schuppenruferin", "Ogre Slayer", 0, 50, "Veteran Cultist Slayer", 0, 120),
                new Dungeon("Krallenhort", "Necromancer Slayer", 0, 350, "Skeleton Slayer", 0, 500),
                new Dungeon("Marsch der Aufopferung", "Bloodscent Slayer", 0, 300, "Wispmother Slayer", 0, 50),
                new Dungeon("Mondjägerfeste", "Dire Wolf Slayer", 0, 200, "Hulking Werewolf Slayer", 0, 50),

                //Trials
                new Dungeon("Aetherisches Archiv", "", 1, 1, "", 1, 1, false, false, false, false, true),
                new Dungeon("Zitadelle von Hel-Ra", "", 1, 1, "", 1, 1, false, false, false, false, true),
                new Dungeon("Sanctum Ophidia", "", 1, 1, "", 1, 1, false, false, false, false, true)
            };

            return createdDungeons;
        }
    }
}