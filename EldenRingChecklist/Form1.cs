using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EldenRingChecklist
{
    public partial class EldenRingChecklist : Form
    {
        private readonly Color unCheckedColour = Color.AntiqueWhite;
        private readonly Color checkedColour = Color.SpringGreen;

        public List<string> checkedOffList;

        private List<Button> bossButtonList;

        private int bossCounter;

        private bool checkedOffBoss;

        private bool hideCheckedOffBosses;

        public EldenRingChecklist()
        {
            InitializeComponent();

            checkedOffList = new List<string>();
            bossButtonList = new List<Button>();
            bossCounter = 0;
            checkedOffBoss = false;
            hideCheckedOffBosses = false;
        }

        private void EldenRingChecklist_Load(object sender, EventArgs e)
        {
            checkedOffList = UpdateData.LoadBossData();

            ButtonHelper.SetAllCheckedButtons(this, BossesFlowLayoutPanel, checkedColour);
            // start location combo box at limgrave selection
            //LocationComboBox.CurrentItem
        }

        private void EldenRingChecklist_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateData.SaveBossData(checkedOffList);
        }

        public void Boss_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!checkedOffBoss) 
            {
                ButtonHelper.SetClickedButton(btn, checkedColour);

                checkedOffList.Add(btn.Name);
                bossCounter++;
                BossCount.Text = bossCounter.ToString();
                checkedOffBoss = true;
            }
            else 
            {
                ButtonHelper.SetClickedButton(btn, unCheckedColour);

                checkedOffList.Remove(btn.Name);
                bossCounter--;
                BossCount.Text = bossCounter.ToString();
                checkedOffBoss = false;
            }
        }

        private void ResetCheckedBosses_Click(object sender, EventArgs e)
        {
            ButtonHelper.SetAllCheckedButtons(this, BossesFlowLayoutPanel, unCheckedColour);

            checkedOffList.Clear();
            bossCounter = 0;
            BossCount.Text = bossCounter.ToString();
            checkedOffBoss = false;
        }

        private void HideAllCheckedBosses_CheckedChanged(object sender, EventArgs e)
        {
            if (!hideCheckedOffBosses) 
            {
                ButtonHelper.ToggleCheckedButtonStates(this, BossesFlowLayoutPanel, true);

                hideCheckedOffBosses = true;
            }
            else 
            {
                ButtonHelper.ToggleCheckedButtonStates(this, BossesFlowLayoutPanel, false);

                hideCheckedOffBosses = false;
            }
        }

        private void BossNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            ButtonHelper.SearchForButton(BossesFlowLayoutPanel, textBox);
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            bossButtonList = BossData.GetAllBossesInSelectedLocation(comboBox.Text);

            BossesFlowLayoutPanel.Controls.Clear();

            for (int i = 0; i < bossButtonList.Count; i++)
            {
                BossesFlowLayoutPanel.Controls.Add(bossButtonList[i]);
            }
        }
    }
}
