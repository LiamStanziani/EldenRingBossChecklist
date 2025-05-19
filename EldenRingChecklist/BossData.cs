using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class BossData
    {
        private static Dictionary<string, string[]> locationArrays;

        private static string[] limgrave;
        private static string[] weepingPeninsula;
        private static string[] LiurniaOfTheLakes;
        private static string[] caelid;

        /// <summary>
        /// Constructor to set the location arrays inside of the dictionary to match values
        /// </summary>
        static BossData() 
        {
            limgrave = new string[] { "Beastman of Farum Azula", "Bell Bearing Hunter", "Black Knife Assassin", "Bloodhound Knight Darriwil", "Crucible Knight", "Deathbird", "Demi-Human Chief", "Erdtree Burial Watchdog (Stormfoot Catacombs)", "Flying Dragon Agheel", "Godrick the Grafted", "Grafted Scion", "Grave Warden Duelist", "Guardian Golem", "Mad Pumpkin Head", "Margit, the Fell Omen", "Night's Cavalry", "Patches", "Soldier of Godrick", "Stonedigger Troll", "Tibia Mariner", "Tree Sentinel", "Ulcerated Tree Spirit" };
            weepingPeninsula = new string[] { "Ancient Hero of Zamor", "Cemetery Shade", "Deathbird", "Erdtree Avatar", "Erdtree Burial Watchdog (Impaler's Catacombs)", "Leonine Misbegotten", "Miranda the Blighted Bloom", "Night's Cavalry", "Runebear", "Scaly Misbegotten" };
            LiurniaOfTheLakes = new string[] { "Adan, Thief of Fire", "Alabaster Lord", "Alecto, Black Knife Ringleader", "Bell Bearing Hunter", "Black Knife Assassin", "Bloodhound Knight", "Bols, Carian Knight", "Cemetery Shade", "Cleanrot Knight", "Crystalian", "Crystalian Spear & Crystalian Staff (Duo)", "Death Rite Bird", "Deathbird", "Erdtree Avatar (Liurnia Northeast)", "Erdtree Avatar (Liurnia Southwest", "Erdtree Burial Watchdog", "Glintstone Dragon Adula", "Glintstone Dragon Smarag", "Magma Wyrm Makar", "Night's Cavalry (Liurnia North)", "Night's Cavalry (Liurnia South)", "Omenkiller", "Red Wolf of Radagon", "Rennala, Queen of the Full Moon", "Royal Knight Loretta", "Royal Revenant", "Spirit-Caller Snail", "Tibia Mariner" };
            caelid = new string[] { "Cemetery Shade", "Commander O'Neil", "Crucible Knight & Misbegotten Warrior", "Death Rite Bird", "Decaying Ekzykes", "Erdtree Burial Watchdog (Duo)", "Fallingstar Beast", "Frenzied Duelist", "Mad Pumpkin Heads", "Magma Wyrm", "Night's Cavalry (Caelid)", "Nox Swordstress & Nox Priest", "Putrid Avatar", "Starscourge Radahn" };

            locationArrays = new Dictionary<string, string[]> {
                { "Limgrave", limgrave },
                { "Weeping Peninsula", weepingPeninsula },
                { "Liurnia Of The Lakes", LiurniaOfTheLakes },
                { "Caelid", caelid }
            };
        }

        /// <summary>
        /// Gets all the boss information for a selected location and creates a list to pass back to project
        /// </summary>
        /// <param name="location">The map location for the bosses</param>
        /// <param name="templateButton">A template button that will be used to create the list of buttons</param>
        /// <returns></returns>
        public static List<Button> GetAllBossesInSelectedLocation(string location)
        {
            ButtonData buttonData = new ButtonData();

            List<Button> bossList = new List<Button>();

            string[] matchedArray;

            if (locationArrays.TryGetValue(location, out matchedArray)) 
            {
                for (int i = 0; i < matchedArray.Length; i++)
                {
                    Button tempButton = buttonData.CreateNewButton();
                    // Setting name to matched boss plus the location string (so that multiple of the same named
                    // bosses can exist at the same time)
                    tempButton.Name = location + " " + matchedArray[i];
                    tempButton.Text = matchedArray[i];
                    bossList.Add(tempButton);
                }
            }

            return bossList;
        }
    }
}

//Liurnia of the Lakes
//Caelid
//Dragonbarrow
//Altus Plateau
//Mt Gelmir
//Capital Outskirts
//Leyndell, Royal Capital
//Mountaintops of the Giants
//Crumbling Farum Azula
//Forbidden Lands
//Consecrated Snowfield
//Miquella's Haligtree
//Siofra River
//Ainsel River
//Nokron, Eternal City
//Deeproot Depths
//Lake of Rot
//Leyndell, Ashen Capital
//Elden Throne
//Gravesite Plain
//Scadu Atlus
//Rauh Base
//Cerulean Coast
//Charo's Hidden Grave
//Jagged Peak
//Abyssal Woods
//Scaduview
//Ancient Ruins of Rauh
//Enir-Ilim