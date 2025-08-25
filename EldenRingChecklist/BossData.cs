using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class BossData
    {
        private static Dictionary<string, string[]> locationArrays;

        /// <summary>
        /// Constructor to set the location arrays inside of the dictionary to match values
        /// </summary>
        static BossData() 
        {
            //locationArrays = JsonSerializer.Deserialize<Dictionary<string, string[]>>(json);
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