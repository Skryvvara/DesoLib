using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DESO
{
    public class FileHandler
    {
        public List<Dungeon> ReadFromFile(string path, string filename = "dungeons.xml")
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + filename))
            {
                CreateNewDungeonFile(path + filename);
            }

            using (var stream = File.OpenRead(path + filename))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
                return (List<Dungeon>) xmlSerializer.Deserialize((stream));
            }
        }

        public void WriteToFile(string path, List<Dungeon> list, string filename = "dungeons.xml")
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + filename))
            {
                CreateNewDungeonFile(path + filename);
                return;
            }

            var stream = File.Open((path + filename), FileMode.Create);
            var xmlSerializer = new XmlSerializer(typeof(List<Dungeon>));
            xmlSerializer.Serialize(stream, list);
            stream.Close();
        }

        public void ReCreateDungeonFile(string path, string filename = "dungeons.xml")
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + filename))
            {
                CreateNewDungeonFile(path + filename);
                return;
            }

            File.Delete(path + filename);
            CreateNewDungeonFile(path + filename);
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

        public List<Dungeon> GetFreshDungeonList()
        {
            List<Dungeon> createdDungeons = new List<Dungeon>
            {
                //Ebonheart Pact Group Dungeons
                new Dungeon("Pilzgrotte I", "Goblin Slayer", 0, 450, "Dreugh Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Spinnenkultistenkutte", "https://www.elderscrollsbote.de/set=218"),
                        new Set("Vipernbiss", "https://www.elderscrollsbote.de/set=245"),
                        new Set("Dreughkönigsschlächter", "https://www.elderscrollsbote.de/set=246"),
                        new Set("Kra'gh", "https://www.elderscrollsbote.de/set=173")
                    }),
                new Dungeon("Pilzgrotte II", "Arachnid slayer", 0, 200, "Obsidian Slayer", 0, 425,
                    new List<Set>
                    {
                        new Set("Spinnenkultistenkutte", "https://www.elderscrollsbote.de/set=218"),
                        new Set("Vipernbiss", "https://www.elderscrollsbote.de/set=245"),
                        new Set("Dreughkönigsschlächter", "https://www.elderscrollsbote.de/set=246"),
                        new Set("Mephalas Brut", "https://www.elderscrollsbote.de/set=32")
                    }),
                new Dungeon("Dunkelschattenkavernen I", "Kwama Slayer", 0, 300, "Pit Rat Slayer", 0, 175,
                    new List<Set>
                    {
                        new Set("Berührung des Netch", "https://www.elderscrollsbote.de/set=223"),
                        new Set("Stärke des Automaten", "https://www.elderscrollsbote.de/set=224"),
                        new Set("Rüstung der Wahrheit", "https://www.elderscrollsbote.de/set=249"),
                        new Set("Wachposten von Rkugamz", "https://www.elderscrollsbote.de/set=166")
                    }),
                new Dungeon("Dunkelschattenkavernen II", "Construct Slayer", 0, 800, "Kwama Slayer", 0, 200,
                    new List<Set>
                    {
                        new Set("Berührung des Netch", "https://www.elderscrollsbote.de/set=223"),
                        new Set("Stärke des Automaten", "https://www.elderscrollsbote.de/set=224"),
                        new Set("Rüstung der Wahrheit", "https://www.elderscrollsbote.de/set=249"),
                        new Set("Maschinenwächter", "https://www.elderscrollsbote.de/set=36")
                    }),
                new Dungeon("Arx Corinium", "Snake Slayer", 0, 175, "Lamia Slayer", 0, 400,
                    new List<Set>
                    {
                        new Set("Lied der Lamie", "https://www.elderscrollsbote.de/set=235"),
                        new Set("Unerschrockener Infiltrator", "https://www.elderscrollsbote.de/set=236"),
                        new Set("Versteinernder Blick", "https://www.elderscrollsbote.de/set=237"),
                        new Set("Sellistrix", "https://www.elderscrollsbote.de/set=174")
                    }),
                new Dungeon("Burg Grauenfrost", "Draugr Slayer", 0, 325, "Frozen Skeleton Slayer", 0, 350,
                    new List<Set>
                    {
                        new Set("Magickaschmiede", "https://www.elderscrollsbote.de/set=238"),
                        new Set("Schwerfälliger Draugr", "https://www.elderscrollsbote.de/set=239"),
                        new Set("Eisschmiede", "https://www.elderscrollsbote.de/set=251"),
                        new Set("Eisherz", "https://www.elderscrollsbote.de/set=170")
                    }),
                new Dungeon("Gesegnete Feuerprobe", "Durzog Slayer", 0, 150, "Gladiator Slayer", 0, 500,
                    new List<Set>
                    {
                        new Set("Seide des edlen Duellanten", "https://www.elderscrollsbote.de/set=254"),
                        new Set("Schwerttänzer", "https://www.elderscrollsbote.de/set=229"),
                        new Set("Nikulas' schwere Rüstung", "https://www.elderscrollsbote.de/set=255"),
                        new Set("Trollkönig", "https://www.elderscrollsbote.de/set=171")
                    }),



                //Daggerfall Covenant Group Dungeons
                new Dungeon("Spindeltiefen I", "Corrupted Slayer", 0, 350, "Spider Slayer", 0, 600,
                    new List<Set>
                    {
                        new Set("Gebetstuch", "https://www.elderscrollsbote.de/set=243"),
                        new Set("Höhlenforscher", "https://www.elderscrollsbote.de/set=217"),
                        new Set("Albtraumritter", "https://www.elderscrollsbote.de/set=244"),
                        new Set("Schwarmmutter", "https://www.elderscrollsbote.de/set=161")
                    }),
                new Dungeon("Spindeltiefen II", "Flesh Atronach Conquerer", 0, 65, "Thrall Slayer", 0, 220,
                    new List<Set>
                    {
                        new Set("Gebetstuch", "https://www.elderscrollsbote.de/set=243"),
                        new Set("Höhlenforscher", "https://www.elderscrollsbote.de/set=217"),
                        new Set("Albtraumritter", "https://www.elderscrollsbote.de/set=244"),
                        new Set("Blutbrut", "https://www.elderscrollsbote.de/set=33")
                    }),
                new Dungeon("Kanalisation von Wegesruh I", "Skeever Slayer", 0, 800, "Mercenary Slayer", 0, 500,
                    new List<Set>
                    {
                        new Set("Feldarzt", "https://www.elderscrollsbote.de/set=221"),
                        new Set("Zahnreihe", "https://www.elderscrollsbote.de/set=222"),
                        new Set("Rüstung des Feldwebels", "https://www.elderscrollsbote.de/set=248"),
                        new Set("Schleimkropf", "https://www.elderscrollsbote.de/set=162")
                    }),
                new Dungeon("Kanalisation von Wegesruh II", "Colossus Slayer", 0, 40, "Zombie Slayer", 0, 350,
                    new List<Set>
                    {
                        new Set("Feldarzt", "https://www.elderscrollsbote.de/set=221"),
                        new Set("Zahnreihe", "https://www.elderscrollsbote.de/set=222"),
                        new Set("Rüstung des Feldwebels", "https://www.elderscrollsbote.de/set=248"),
                        new Set("Geißelernter", "https://www.elderscrollsbote.de/set=35")
                    }),
                new Dungeon("Krypta der Herzen I", "Skeleton Slayer", 0, 400, "Crypt Zombie Slayer", 0, 400,
                    new List<Set>
                    {
                        new Set("Tuch des Lich", "https://www.elderscrollsbote.de/set=232"),
                        new Set("Leviathan", "https://www.elderscrollsbote.de/set=233"),
                        new Set("Ebenerzarsenal", "https://www.elderscrollsbote.de/set=234"),
                        new Set("Ilambris", "https://www.elderscrollsbote.de/set=169")
                    }),
                new Dungeon("Krypta der Herzen II", "Flesh Atronach Slayer", 0, 50, "Spiderkith Slayer", 0, 250,
                    new List<Set>
                    {
                        new Set("Tuch des Lich", "https://www.elderscrollsbote.de/set=232"),
                        new Set("Leviathan", "https://www.elderscrollsbote.de/set=233"),
                        new Set("Ebenerzarsenal", "https://www.elderscrollsbote.de/set=234"),
                        new Set("Nerien'eth", "https://www.elderscrollsbote.de/set=38")
                    }),
                new Dungeon("Volenfell", "Dwarven Construct Slayer", 0, 300, "Treasure Hunter Slayer", 0, 250,
                    new List<Set>
                    {
                        new Set("Schatzjäger", "https://www.elderscrollsbote.de/set=230"),
                        new Set("Glaubenskrieger ", "https://www.elderscrollsbote.de/set=250"),
                        new Set("Schuppen des Dünenbrechers", "https://www.elderscrollsbote.de/set=231"),
                        new Set("Bebenschuppe", "https://www.elderscrollsbote.de/set=163")
                    }),
                new Dungeon("Schwarzherz-Unterschlupf", "Harpy Slayer", 0, 400, "Pirate Slayer", 0, 500,
                    new List<Set>
                    {
                        new Set("Unerschrockener Entflechter", "https://www.elderscrollsbote.de/set=240"),
                        new Set("Lumpen des Knochenpiraten", "https://www.elderscrollsbote.de/set=241"),
                        new Set("Platten des Wanderritters", "https://www.elderscrollsbote.de/set=242"),
                        new Set("Piratenskelett", "https://www.elderscrollsbote.de/set=164")
                    }),



                //Aldmeri Dominion Group Dungeons
                new Dungeon("Verbannungszellen I", "Bonebreaker", 0, 350, "Daedra Slayer I", 0, 100,
                    new List<Set>
                    {
                        new Set("Heiligtum", "https://www.elderscrollsbote.de/set=214"),
                        new Set("Ausbrecher", "https://www.elderscrollsbote.de/set=215"),
                        new Set("Quälender", "https://www.elderscrollsbote.de/set=216"),
                        new Set("Schattenriss", "https://www.elderscrollsbote.de/set=165")
                    }),
                new Dungeon("Verbannungszellen II", "Rillis Dremora Slayer", 0, 300, "Bonebreaker II", 0, 120,
                    new List<Set>
                    {
                        new Set("Heiligtum", "https://www.elderscrollsbote.de/set=214"),
                        new Set("Ausbrecher", "https://www.elderscrollsbote.de/set=215"),
                        new Set("Quälender", "https://www.elderscrollsbote.de/set=216"),
                        new Set("Schlund des Infernalen", "https://www.elderscrollsbote.de/set=40")
                    }),
                new Dungeon("Eldengrund I", "Orc Slayer", 0, 400, "Alit Slayer", 0, 100,
                    new List<Set>
                    {
                        new Set("Lichtsprecher", "https://www.elderscrollsbote.de/set=219"),
                        new Set("Borkenhaut", "https://www.elderscrollsbote.de/set=247"),
                        new Set("Unerschrockenen-Bastion", "https://www.elderscrollsbote.de/set=220"),
                        new Set("Würgedorn", "https://www.elderscrollsbote.de/set=167")
                    }),
                new Dungeon("Eldengrund II", "Lurcher Slayer", 0, 60, "Banekin Slayer", 0, 140,
                    new List<Set>
                    {
                        new Set("Lichtsprecher", "https://www.elderscrollsbote.de/set=219"),
                        new Set("Borkenhaut", "https://www.elderscrollsbote.de/set=247"),
                        new Set("Unerschrockenen-Bastion", "https://www.elderscrollsbote.de/set=220"),
                        new Set("Bogdan die Nachtflamme", "https://www.elderscrollsbote.de/set=37")
                    }),
                new Dungeon("Stadt der Asche I", "Banekin Slayer", 0, 550, "Flame Atronach Slayer", 0, 60,
                    new List<Set>
                    {
                        new Set("Branntzauberweber", "https://www.elderscrollsbote.de/set=225"),
                        new Set("Trennflamme", "https://www.elderscrollsbote.de/set=226"),
                        new Set("Glutschild", "https://www.elderscrollsbote.de/set=227"),
                        new Set("Infernaler Wächter", "https://www.elderscrollsbote.de/set=168")
                    }),
                new Dungeon("Stadt der Asche II", "Flame Colossus Slayer", 0, 50, "Dremora Slayer", 0, 300,
                    new List<Set>
                    {
                        new Set("Branntzauberweber", "https://www.elderscrollsbote.de/set=225"),
                        new Set("Trennflamme", "https://www.elderscrollsbote.de/set=226"),
                        new Set("Glutschild", "https://www.elderscrollsbote.de/set=227"),
                        new Set("Valkyn Skoria", "https://www.elderscrollsbote.de/set=39")
                    }),
                new Dungeon("Orkaninsel", "Lamia Slayer", 0, 600, "Sea Viper Slayer", 0, 550,
                    new List<Set>
                    {
                        new Set("Überwältigende Woge", "https://www.elderscrollsbote.de/set=256"),
                        new Set("Sturmmeister", "https://www.elderscrollsbote.de/set=257"),
                        new Set("Rüttelnde Rüstung", "https://www.elderscrollsbote.de/set=258"),
                        new Set("Sturmfaust", "https://www.elderscrollsbote.de/set=175")
                    }),
                new Dungeon("Selene's Netz", "Bosmer Slayer", 0, 250, "Spider Slayer", 0, 250,
                    new List<Set>
                    {
                        new Set("Gewänder des Hexers", "https://www.elderscrollsbote.de/set=252"),
                        new Set("Hircines Schein", "https://www.elderscrollsbote.de/set=228"),
                        new Set("Duroks Fluch", "https://www.elderscrollsbote.de/set=253"),
                        new Set("Selene", "https://www.elderscrollsbote.de/set=176")
                    }),

                //Other & DLC Group Dungeons
                new Dungeon("Kammern des Wahnsinns", "Dremora Slayer", 0, 150, "Ferral Shriven Slayer", 0, 750,
                    new List<Set>
                    {
                        new Set("Garderobe des Wurms", "https://www.elderscrollsbote.de/set=259"),
                        new Set("Vorteil des Vergessens", "https://www.elderscrollsbote.de/set=260"),
                        new Set("Klapperkäfig", "https://www.elderscrollsbote.de/set=261"),
                        new Set("Grothdarr", "https://www.elderscrollsbote.de/set=172")
                    }),
                new Dungeon("Weißgoldturm", "Daedroth Slayer", 0, 50, "Horn Breaker", 0, 100,
                    new List<Set>
                    {
                        new Set("Magiekraftheilung", "https://www.elderscrollsbote.de/set=265"),
                        new Set("Essenzdieb", "https://www.elderscrollsbote.de/set=266"),
                        new Set("Male des Kaiserreichs", "https://www.elderscrollsbote.de/set=267"),
                        new Set("Molag Kena", "https://www.elderscrollsbote.de/set=44")
                    }),
                new Dungeon("Gefängnis der Kaiserstadt", "Mindshriven Slayer", 0, 300, "Watcher Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Verletzender Magier", "https://www.elderscrollsbote.de/set=262"),
                        new Set("Reingift", "https://www.elderscrollsbote.de/set=263"),
                        new Set("Auslaugende Rüstung", "https://www.elderscrollsbote.de/set=264"),
                        new Set("Hochwärter", "https://www.elderscrollsbote.de/set=34")
                    }),
                new Dungeon("Ruinen von Mazzatun", "Xit-Xaht Slayer", 0, 600, "Sludge-Slinger Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Bernsteinplasma", "https://www.elderscrollsbote.de/set=113"),
                        new Set("Heem-Jas' Vergeltung", "https://www.elderscrollsbote.de/set=114"),
                        new Set("Aspekt von Mazzatun", "https://www.elderscrollsbote.de/set=112"),
                        new Set("Mächtiger Chudan", "https://www.elderscrollsbote.de/set=111")
                    }),
                new Dungeon("Wiege der Schatten", "Iconoclast", 0, 50, "Spider Cult Slayer", 0, 600,
                    new List<Set>
                    {
                        new Set("Gespinst", "https://www.elderscrollsbote.de/set=116"),
                        new Set("Witwenmacher", "https://www.elderscrollsbote.de/set=117"),
                        new Set("Hand von Mephala", "https://www.elderscrollsbote.de/set=115"),
                        new Set("Velidreth", "https://www.elderscrollsbote.de/set=110")
                    }),
                new Dungeon("Falkenring", "Minotaur Tramplar Slayer", 0, 60, "Dreadhorn Mage Slayer", 0, 150,
                    new List<Set>
                    {
                        new Set("Draugrruhe", "https://www.elderscrollsbote.de/set=294"),
                        new Set("Säulen von Nirn", "https://www.elderscrollsbote.de/set=295"),
                        new Set("Eisenblut", "https://www.elderscrollsbote.de/set=293"),
                        new Set("Domihaus", "https://www.elderscrollsbote.de/set=300")
                    }),
                new Dungeon("Blutquellschmiede", "Dreadhorn Warrior Slayer", 0, 300, "Firehide Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Flammenblüte", "https://www.elderscrollsbote.de/set=297"),
                        new Set("Bluttrinker", "https://www.elderscrollsbote.de/set=298"),
                        new Set("Vettelgarten", "https://www.elderscrollsbote.de/set=296"),
                        new Set("Erdbluter", "https://www.elderscrollsbote.de/set=299")
                    }),
                new Dungeon("Hort der Schuppenruferin", "Ogre Slayer", 0, 50, "Veteran Cultist Slayer", 0, 120,
                    new List<Set>
                    {
                        new Set("Jorvulds Führung", "https://www.elderscrollsbote.de/set=320"),
                        new Set("Seuchenschleuder", "https://www.elderscrollsbote.de/set=322"),
                        new Set("Fluch von Doylemish", "https://www.elderscrollsbote.de/set=324"),
                        new Set("Zaan", "https://www.elderscrollsbote.de/set=326")
                    }),
                new Dungeon("Krallenhort", "Necromancer Slayer", 0, 350, "Skeleton Slayer", 0, 500,
                    new List<Set>
                    {
                        new Set("Caluurions Erbe", "https://www.elderscrollsbote.de/set=319"),
                        new Set("Ulfnors Gunst", "https://www.elderscrollsbote.de/set=323"),
                        new Set("Stärkungsprunk", "https://www.elderscrollsbote.de/set=321"),
                        new Set("Thurvokun", "https://www.elderscrollsbote.de/set=325")
                    }),
                new Dungeon("Marsch der Aufopferung", "Bloodscent Slayer", 0, 300, "Wispmother Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Hanus Mitgefühl", "https://www.elderscrollsbote.de/set=343"),
                        new Set("Blutmond", "https://www.elderscrollsbote.de/set=344"),
                        new Set("Zuflucht von Ursus", "https://www.elderscrollsbote.de/set=342"),
                        new Set("Balorgh", "https://www.elderscrollsbote.de/set=345")
                    }),
                new Dungeon("Mondjägerfeste", "Dire Wolf Slayer", 0, 200, "Hulking Werewolf Slayer", 0, 50,
                    new List<Set>
                    {
                        new Set("Mondjäger", "https://www.elderscrollsbote.de/set=347"),
                        new Set("Wilder Werwolf", "https://www.elderscrollsbote.de/set=348"),
                        new Set("Tenazität des Kerkermeisters", "https://www.elderscrollsbote.de/set=346"),
                        new Set("Vykosa", "https://www.elderscrollsbote.de/set=349")
                    }),

                //Trials
                new Dungeon("Ätherische Archiv", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Unfehlbare Magierin", "https://www.elderscrollsbote.de/set=107"),
                        new Set("Heilender Magier", "https://www.elderscrollsbote.de/set=268"),
                        new Set("Boshafte Schlange", "https://www.elderscrollsbote.de/set=106"),
                        new Set("Flinke Schlange", "https://www.elderscrollsbote.de/set=269"),
                        new Set("Ewiger Krieger", "https://www.elderscrollsbote.de/set=105"),
                        new Set("Verteidigender Krieger", "https://www.elderscrollsbote.de/set=270")
                    }, true, true, false, true),
                new Dungeon("Zitadelle von Hel Ra", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Unfehlbare Magierin", "https://www.elderscrollsbote.de/set=107"),
                        new Set("Zerstörerischer Magier", "https://www.elderscrollsbote.de/set=271"),
                        new Set("Boshafte Schlange", "https://www.elderscrollsbote.de/set=106"),
                        new Set("Giftschlange", "https://www.elderscrollsbote.de/set=272"),
                        new Set("Ewiger Krieger", "https://www.elderscrollsbote.de/set=105"),
                        new Set("Tobender Krieger", "https://www.elderscrollsbote.de/set=273")
                    }, true, true, false, true),
                new Dungeon("Sanctum Ophidia", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Unfehlbare Magierin", "https://www.elderscrollsbote.de/set=107"),
                        new Set("Weiser Magier", "https://www.elderscrollsbote.de/set=274"),
                        new Set("Boshafte Schlange", "https://www.elderscrollsbote.de/set=106"),
                        new Set("Doppelzüngige Schlange", "https://www.elderscrollsbote.de/set=275"),
                        new Set("Ewiger Krieger", "https://www.elderscrollsbote.de/set=105"),
                        new Set("Unsterblicher Krieger", "https://www.elderscrollsbote.de/set=276")
                    }, true, true, false, true),
                new Dungeon("Schlund von Lorkhaj", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Mondtänzer", "https://www.elderscrollsbote.de/set=82"),
                        new Set("Zwielichtgenesung", "https://www.elderscrollsbote.de/set=83"),
                        new Set("Brüllen von Alkosh", "https://www.elderscrollsbote.de/set=84"),
                        new Set("Mondbastion", "https://www.elderscrollsbote.de/set=85")
                    }, true),
                new Dungeon("Hallen der Fertigung", "", 1, 1, "", 1 , 1,
                    new List<Set>
                    {
                        new Set("Erfindergarde", "https://www.elderscrollsbote.de/set=285"),
                        new Set("Meisterarchitekt", "https://www.elderscrollsbote.de/set=286"),
                        new Set("Kriegsmaschine", "https://www.elderscrollsbote.de/set=287"),
                        new Set("Automatisierte Verteidigung", "https://www.elderscrollsbote.de/set=284")
                    }, true),
                new Dungeon("Anstalt Sanctorium", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Sanctorium", "https://www.elderscrollsbote.de/sets/?q=Anstalt%20Sanctorium"),
                        new Set("Sanctorium (Vollendet)", "https://www.elderscrollsbote.de/sets/?q=Anstalt%20Sanctorium"),
                        new Set("", ""),
                        new Set("", "")
                    }, true),
                new Dungeon("Wolkenruh", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Gewandung von Olorime", "https://www.elderscrollsbote.de/set=334"),
                        new Set("(P) Gewandung von Olorime", "https://www.elderscrollsbote.de/set=341"),
                        new Set("Mantel von Siroria", "https://www.elderscrollsbote.de/set=333"),
                        new Set("(P) Mantel von Siroria", "https://www.elderscrollsbote.de/set=340"),
                        new Set("Waffen von Relequen", "https://www.elderscrollsbote.de/set=332"),
                        new Set("(P) Waffen von Relequen", "https://www.elderscrollsbote.de/set=339"),
                        new Set("Ägis von Galenwe", "https://www.elderscrollsbote.de/set=331"),
                        new Set("(P) Ägis von Galenwe", "https://www.elderscrollsbote.de/set=338")
                    }, true),



                //Other Trials
                new Dungeon("Mahlstrom-Arena", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Mahlstrom", "https://www.elderscrollsbote.de/sets/?q=Maelstrom"),
                        new Set("", ""),
                        new Set("", ""),
                        new Set("", "")
                    }, true, false, true, false),
                new Dungeon("Drachenstern-Arena", "", 1, 1, "", 1, 1,
                    new List<Set>
                    {
                        new Set("Bräuche des Heilers", "https://www.elderscrollsbote.de/set=128"),
                        new Set("Zerstörungsbeherrschung", "https://www.elderscrollsbote.de/set=129"),
                        new Set("Schützensinn", "https://www.elderscrollsbote.de/set=130"),
                        new Set("Geschick des Fußsoldaten", "https://www.elderscrollsbote.de/set=127"),
                        new Set("des Meisters", "https://www.elderscrollsbote.de/sets/?q=des%20Meisters")
                    }, true, false, false, false)
            };

            return createdDungeons;
        }
    }
}