using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    internal class ButtonHelper
    {
        /// <summary>
        /// Sets all checked boss buttons to be set to the checked color in the form after loading
        /// </summary>
        /// <param name="form">The form class</param>
        /// <param name="panel">The flow layout panel that contains the boss buttons</param>
        /// <param name="color">The color the boss buttons will be changed to</param>
        public static void SetAllCheckedButtons(EldenRingChecklist form, FlowLayoutPanel panel, Color color) 
        {
            foreach (Button btn in panel.Controls.OfType<Button>())
            {
                for (int i = 0; i < form.checkedOffList.Count; i++)
                {
                    if (!btn.Visible && btn.FlatAppearance.BorderColor != color)
                    {
                        btn.Show();
                    }

                    if (btn.Name == form.checkedOffList[i])
                    {
                        btn.FlatAppearance.BorderColor = color;
                    }
                }
            }
        }

        /// <summary>
        /// Shows or hides all of the checked buttons
        /// </summary>
        /// <param name="form">The form class</param>
        /// <param name="panel">The flow layout panel that contains the boss buttons</param>
        /// <param name="hidden">The visible state that the buttons should be</param>
        public static void ToggleCheckedButtonStates(EldenRingChecklist form, FlowLayoutPanel panel, bool hidden) 
        {
            foreach (Button btn in panel.Controls.OfType<Button>())
            {
                for (int i = 0; i < form.checkedOffList.Count; i++)
                {
                    Console.WriteLine(btn.Name);
                    Console.WriteLine(form.checkedOffList[i]);

                    if (btn.Name == form.checkedOffList[i])
                    {
                        if (hidden)
                        {
                            btn.Hide();
                        }
                        else
                        {
                            btn.Show();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Searches for the buttons text and matches it to the text in a text box
        /// </summary>
        /// <param name="panel">The panel that contains the buttons</param>
        /// <param name="textBox">The textbox that contains the search text</param>
        public static void SearchForButton(FlowLayoutPanel panel, TextBox textBox) 
        {
            foreach (Button btn in panel.Controls.OfType<Button>())
            {
                // if button is not visible and checked off bosses is true, i need to make sure that
                // the button doesn't show here
                if (btn.Text.ToLower().Contains(textBox.Text.ToLower()))
                {
                    btn.Show();
                }
                else
                {
                    btn.Hide();
                }
            }
        }

        /// <summary>
        /// Sets the color of a clicked button
        /// </summary>
        /// <param name="btn">The button that will change color</param>
        /// <param name="color">The color the button will change to</param>
        public static void SetClickedButton(Button btn, Color color) 
        {
            btn.FlatAppearance.BorderColor = color;
        }
    }
}
