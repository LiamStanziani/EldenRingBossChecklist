using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class ButtonData
    {
        /// <summary>
        /// Set new button template date that will be used for every instantiated button
        /// </summary>
        /// <returns></returns>
        public Button CreateNewButton() 
        { 
            Button button = new Button();
            button.Name = "PlaceHolderButton";
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Sitka Small", 13.8f, FontStyle.Underline);
            button.ForeColor = Color.AntiqueWhite;
            button.Location = new Point(2, 2);
            button.Margin = new Padding(2, 2, 2, 2);
            button.Size = new Size(128, 114);
            button.Text = "Placeholder";
            button.UseVisualStyleBackColor = true;
            return button;
        }
    }
}
