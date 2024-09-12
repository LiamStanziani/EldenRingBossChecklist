using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class BossData
    {
        private static Dictionary<string, string[]> locationArrays;

        private static string[] limgrave;
        //private static string[] weepingPeninsula;
        //private static string[] etc....

        static BossData() 
        {
            limgrave = new string[] { "Beastman of Farum Azula", "Bell Bearing Hunter" };

            locationArrays = new Dictionary<string, string[]> { { "Limgrave", limgrave } };
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
                    //tempButton.Name = i.ToString();
                    tempButton.Text = matchedArray[i];
                    bossList.Add(tempButton);
                }
            }

            return bossList;
        }
    }
}

//Limgrave
//Weeping Peninsula
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