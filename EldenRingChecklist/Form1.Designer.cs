namespace EldenRingChecklist
{
    partial class EldenRingChecklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EldenRingChecklist));
            this.PlaceholderButton = new System.Windows.Forms.Button();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.GroupBoxTools = new System.Windows.Forms.GroupBox();
            this.BossNameLabel = new System.Windows.Forms.Label();
            this.BossNameTextBox = new System.Windows.Forms.TextBox();
            this.BossCount = new System.Windows.Forms.Label();
            this.BossCountMax = new System.Windows.Forms.Label();
            this.BossCounterLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ResetCheckedBosses = new System.Windows.Forms.Button();
            this.BossesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.LocationsLabel = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.Label();
            this.GroupBoxTools.SuspendLayout();
            this.BossesFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceholderButton
            // 
            this.PlaceholderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceholderButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceholderButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.PlaceholderButton.Location = new System.Drawing.Point(3, 3);
            this.PlaceholderButton.Name = "PlaceholderButton";
            this.PlaceholderButton.Size = new System.Drawing.Size(170, 140);
            this.PlaceholderButton.TabIndex = 0;
            this.PlaceholderButton.Text = "Placeholder";
            this.PlaceholderButton.UseVisualStyleBackColor = true;
            this.PlaceholderButton.Click += new System.EventHandler(this.Boss_Clicked);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(1025, 9);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(28, 655);
            this.ScrollBar.TabIndex = 1;
            // 
            // GroupBoxTools
            // 
            this.GroupBoxTools.Controls.Add(this.BossNameLabel);
            this.GroupBoxTools.Controls.Add(this.BossNameTextBox);
            this.GroupBoxTools.Controls.Add(this.BossCount);
            this.GroupBoxTools.Controls.Add(this.BossCounterLabel);
            this.GroupBoxTools.Controls.Add(this.checkBox1);
            this.GroupBoxTools.Controls.Add(this.ResetCheckedBosses);
            this.GroupBoxTools.Controls.Add(this.Division);
            this.GroupBoxTools.Controls.Add(this.BossCountMax);
            this.GroupBoxTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxTools.Location = new System.Drawing.Point(12, 3);
            this.GroupBoxTools.Name = "GroupBoxTools";
            this.GroupBoxTools.Size = new System.Drawing.Size(1000, 111);
            this.GroupBoxTools.TabIndex = 6;
            this.GroupBoxTools.TabStop = false;
            // 
            // BossNameLabel
            // 
            this.BossNameLabel.AutoSize = true;
            this.BossNameLabel.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.BossNameLabel.Location = new System.Drawing.Point(295, 45);
            this.BossNameLabel.Name = "BossNameLabel";
            this.BossNameLabel.Size = new System.Drawing.Size(127, 28);
            this.BossNameLabel.TabIndex = 9;
            this.BossNameLabel.Text = "Boss name:";
            // 
            // BossNameTextBox
            // 
            this.BossNameTextBox.Location = new System.Drawing.Point(428, 50);
            this.BossNameTextBox.Name = "BossNameTextBox";
            this.BossNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.BossNameTextBox.TabIndex = 8;
            this.BossNameTextBox.TextChanged += new System.EventHandler(this.BossNameTextBox_TextChanged);
            // 
            // BossCount
            // 
            this.BossCount.AutoSize = true;
            this.BossCount.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.BossCount.Location = new System.Drawing.Point(164, 44);
            this.BossCount.Margin = new System.Windows.Forms.Padding(0);
            this.BossCount.Name = "BossCount";
            this.BossCount.Size = new System.Drawing.Size(25, 28);
            this.BossCount.TabIndex = 7;
            this.BossCount.Text = "0";
            // 
            // BossCountMax
            // 
            this.BossCountMax.AutoSize = true;
            this.BossCountMax.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.BossCountMax.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.BossCountMax.Location = new System.Drawing.Point(164, 80);
            this.BossCountMax.Margin = new System.Windows.Forms.Padding(0);
            this.BossCountMax.Name = "BossCountMax";
            this.BossCountMax.Size = new System.Drawing.Size(44, 28);
            this.BossCountMax.TabIndex = 6;
            this.BossCountMax.Text = "211";
            this.BossCountMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BossCounterLabel
            // 
            this.BossCounterLabel.AutoSize = true;
            this.BossCounterLabel.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.BossCounterLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.BossCounterLabel.Location = new System.Drawing.Point(3, 63);
            this.BossCounterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BossCounterLabel.Name = "BossCounterLabel";
            this.BossCounterLabel.Size = new System.Drawing.Size(156, 28);
            this.BossCounterLabel.TabIndex = 5;
            this.BossCounterLabel.Text = "Boss counter: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.checkBox1.Location = new System.Drawing.Point(19, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(238, 32);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Hide checked bosses";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.HideAllCheckedBosses_CheckedChanged);
            // 
            // ResetCheckedBosses
            // 
            this.ResetCheckedBosses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetCheckedBosses.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCheckedBosses.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ResetCheckedBosses.Location = new System.Drawing.Point(659, 21);
            this.ResetCheckedBosses.Name = "ResetCheckedBosses";
            this.ResetCheckedBosses.Size = new System.Drawing.Size(325, 70);
            this.ResetCheckedBosses.TabIndex = 3;
            this.ResetCheckedBosses.Text = "Reset checked bosses";
            this.ResetCheckedBosses.UseVisualStyleBackColor = true;
            this.ResetCheckedBosses.Click += new System.EventHandler(this.ResetCheckedBosses_Click);
            // 
            // BossesFlowLayoutPanel
            // 
            this.BossesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BossesFlowLayoutPanel.Controls.Add(this.PlaceholderButton);
            this.BossesFlowLayoutPanel.Location = new System.Drawing.Point(12, 156);
            this.BossesFlowLayoutPanel.Name = "BossesFlowLayoutPanel";
            this.BossesFlowLayoutPanel.Size = new System.Drawing.Size(1000, 508);
            this.BossesFlowLayoutPanel.TabIndex = 7;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.DimGray;
            this.LocationComboBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold);
            this.LocationComboBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Limgrave",
            "Weeping Peninsula",
            "Liurnia of the Lakes",
            "Caelid",
            "Dragonbarrow",
            "Altus Plateau",
            "Mt Gelmir",
            "Capital Outskirts",
            "Leyndell, Royal Capital",
            "Mountaintops of the Giants",
            "Crumbling Farum Azula",
            "Forbidden Lands",
            "Consecrated Snowfield",
            "Miquella\'s Haligtree",
            "Siofra River",
            "Ainsel River",
            "Nokron, Eternal City",
            "Deeproot Depths",
            "Lake of Rot",
            "Leyndell, Ashen Capital",
            "Elden Throne",
            "Gravesite Plain",
            "Scadu Atlus",
            "Rauh Base",
            "Cerulean Coast",
            "Charo\'s Hidden Grave",
            "Jagged Peak",
            "Abyssal Woods",
            "Scaduview",
            "Ancient Ruins of Rauh",
            "Enir-Ilim"});
            this.LocationComboBox.Location = new System.Drawing.Point(140, 120);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(872, 31);
            this.LocationComboBox.TabIndex = 1;
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            // 
            // LocationsLabel
            // 
            this.LocationsLabel.AutoSize = true;
            this.LocationsLabel.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.LocationsLabel.Location = new System.Drawing.Point(7, 120);
            this.LocationsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LocationsLabel.Name = "LocationsLabel";
            this.LocationsLabel.Size = new System.Drawing.Size(108, 28);
            this.LocationsLabel.TabIndex = 8;
            this.LocationsLabel.Text = "Location:";
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Bold);
            this.Division.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Division.Location = new System.Drawing.Point(164, 56);
            this.Division.Margin = new System.Windows.Forms.Padding(0);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(45, 28);
            this.Division.TabIndex = 10;
            this.Division.Text = "___";
            this.Division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EldenRingChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.LocationsLabel);
            this.Controls.Add(this.BossesFlowLayoutPanel);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.GroupBoxTools);
            this.Controls.Add(this.ScrollBar);
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EldenRingChecklist";
            this.Text = "Elden Ring Checklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EldenRingChecklist_FormClosing);
            this.Load += new System.EventHandler(this.EldenRingChecklist_Load);
            this.GroupBoxTools.ResumeLayout(false);
            this.GroupBoxTools.PerformLayout();
            this.BossesFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlaceholderButton;
        private System.Windows.Forms.VScrollBar ScrollBar;
        private System.Windows.Forms.GroupBox GroupBoxTools;
        private System.Windows.Forms.Button ResetCheckedBosses;
        private System.Windows.Forms.Label BossCounterLabel;
        private System.Windows.Forms.Label BossCountMax;
        private System.Windows.Forms.Label BossCount;
        private System.Windows.Forms.Label BossNameLabel;
        private System.Windows.Forms.TextBox BossNameTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label LocationsLabel;
        private System.Windows.Forms.FlowLayoutPanel BossesFlowLayoutPanel;
        private System.Windows.Forms.Label Division;
    }
}

