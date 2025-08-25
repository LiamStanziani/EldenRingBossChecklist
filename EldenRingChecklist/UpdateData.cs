using System.Collections.Generic;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class UpdateData
    {
        /// <summary>
        /// Loads the boss data list from a preset JSON file on load
        /// </summary>
        /// <returns>string of button names to update the colour of the checked bosses</returns>
        public static List<string> LoadBossData()
        {
            List<string> bossList = new List<string>();

            // pull the data from the text file, match the currently
            // loaded text line with the button names (nested for loop)
            // to find if the button is checked off, if so add that
            // button to the list made in the method

            return bossList;
        }

        /// <summary>
        /// Saves the boss data to a JSON file on exit 
        /// of the application
        /// </summary>
        public static void SaveBossData(List<string> bossList)
        {
            // add all list to text file, one index of list per line
            // overite old version to avoid conflicts with duplicate
            // list values
        }

        /// <summary>
        /// Clears the entire JSON boss checked file
        /// </summary>
        public static void ClearAllBossData()
        {
            // remove all lines from data JSON file
        }
    }
}
