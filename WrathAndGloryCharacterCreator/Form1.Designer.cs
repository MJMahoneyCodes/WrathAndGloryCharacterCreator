namespace WrathAndGloryCharacterCreator
{
    partial class WnGMainForm
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
            this.components = new System.ComponentModel.Container();
            this.lstChooseTier = new System.Windows.Forms.ListBox();
            this.lblAvailableBuildPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsedBuildPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArchetype = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.nudAgility = new System.Windows.Forms.NumericUpDown();
            this.nudToughness = new System.Windows.Forms.NumericUpDown();
            this.nudIntellect = new System.Windows.Forms.NumericUpDown();
            this.nudWillpower = new System.Windows.Forms.NumericUpDown();
            this.nudFellowship = new System.Windows.Forms.NumericUpDown();
            this.nudInitiative = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbValidation = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntellect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWillpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).BeginInit();
            this.SuspendLayout();
            // 
            // lstChooseTier
            // 
            this.lstChooseTier.FormattingEnabled = true;
            this.lstChooseTier.ItemHeight = 16;
            this.lstChooseTier.Items.AddRange(new object[] {
            "Tier 1",
            "Tier 2",
            "Tier 3",
            "Tier 4",
            "Tier 5"});
            this.lstChooseTier.Location = new System.Drawing.Point(15, 29);
            this.lstChooseTier.Name = "lstChooseTier";
            this.lstChooseTier.Size = new System.Drawing.Size(46, 84);
            this.lstChooseTier.TabIndex = 0;
            this.lstChooseTier.SelectedIndexChanged += new System.EventHandler(this.lstChooseTier_SelectedIndexChanged);
            // 
            // lblAvailableBuildPoints
            // 
            this.lblAvailableBuildPoints.AutoSize = true;
            this.lblAvailableBuildPoints.Location = new System.Drawing.Point(731, 38);
            this.lblAvailableBuildPoints.Name = "lblAvailableBuildPoints";
            this.lblAvailableBuildPoints.Size = new System.Drawing.Size(16, 17);
            this.lblAvailableBuildPoints.TabIndex = 1;
            this.lblAvailableBuildPoints.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maximum Build Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Used Build Points";
            // 
            // lblUsedBuildPoints
            // 
            this.lblUsedBuildPoints.AutoSize = true;
            this.lblUsedBuildPoints.Location = new System.Drawing.Point(731, 12);
            this.lblUsedBuildPoints.Name = "lblUsedBuildPoints";
            this.lblUsedBuildPoints.Size = new System.Drawing.Size(16, 17);
            this.lblUsedBuildPoints.TabIndex = 4;
            this.lblUsedBuildPoints.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Tier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Species";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Human",
            "Eldar",
            "Ork",
            "Adeptus Astartes",
            "Primaris Astartes"});
            this.cmbSpecies.Location = new System.Drawing.Point(15, 149);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(152, 24);
            this.cmbSpecies.TabIndex = 7;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Archetype";
            // 
            // cmbArchetype
            // 
            this.cmbArchetype.FormattingEnabled = true;
            this.cmbArchetype.Items.AddRange(new object[] {
            "Ministorum Priest"});
            this.cmbArchetype.Location = new System.Drawing.Point(13, 207);
            this.cmbArchetype.Name = "cmbArchetype";
            this.cmbArchetype.Size = new System.Drawing.Size(154, 24);
            this.cmbArchetype.TabIndex = 9;
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(112, 250);
            this.nudStrength.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(55, 22);
            this.nudStrength.TabIndex = 10;
            this.toolTip1.SetToolTip(this.nudStrength, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman");
            this.nudStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStrength.ValueChanged += new System.EventHandler(this.nudStrength_ValueChanged);
            // 
            // nudAgility
            // 
            this.nudAgility.Location = new System.Drawing.Point(112, 278);
            this.nudAgility.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAgility.Name = "nudAgility";
            this.nudAgility.Size = new System.Drawing.Size(55, 22);
            this.nudAgility.TabIndex = 11;
            this.toolTip1.SetToolTip(this.nudAgility, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudAgility.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAgility.ValueChanged += new System.EventHandler(this.nudAgility_ValueChanged);
            // 
            // nudToughness
            // 
            this.nudToughness.Location = new System.Drawing.Point(112, 306);
            this.nudToughness.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudToughness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToughness.Name = "nudToughness";
            this.nudToughness.Size = new System.Drawing.Size(55, 22);
            this.nudToughness.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nudToughness, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudToughness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToughness.ValueChanged += new System.EventHandler(this.nudToughness_ValueChanged);
            // 
            // nudIntellect
            // 
            this.nudIntellect.Location = new System.Drawing.Point(112, 334);
            this.nudIntellect.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudIntellect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntellect.Name = "nudIntellect";
            this.nudIntellect.Size = new System.Drawing.Size(55, 22);
            this.nudIntellect.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nudIntellect, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudIntellect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntellect.ValueChanged += new System.EventHandler(this.nudIntellect_ValueChanged);
            // 
            // nudWillpower
            // 
            this.nudWillpower.Location = new System.Drawing.Point(112, 362);
            this.nudWillpower.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudWillpower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWillpower.Name = "nudWillpower";
            this.nudWillpower.Size = new System.Drawing.Size(55, 22);
            this.nudWillpower.TabIndex = 14;
            this.toolTip1.SetToolTip(this.nudWillpower, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudWillpower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWillpower.ValueChanged += new System.EventHandler(this.nudWillpower_ValueChanged);
            // 
            // nudFellowship
            // 
            this.nudFellowship.Location = new System.Drawing.Point(112, 390);
            this.nudFellowship.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudFellowship.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFellowship.Name = "nudFellowship";
            this.nudFellowship.Size = new System.Drawing.Size(55, 22);
            this.nudFellowship.TabIndex = 15;
            this.toolTip1.SetToolTip(this.nudFellowship, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudFellowship.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFellowship.ValueChanged += new System.EventHandler(this.nudFellowship_ValueChanged);
            // 
            // nudInitiative
            // 
            this.nudInitiative.Location = new System.Drawing.Point(112, 418);
            this.nudInitiative.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudInitiative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitiative.Name = "nudInitiative";
            this.nudInitiative.Size = new System.Drawing.Size(55, 22);
            this.nudInitiative.TabIndex = 16;
            this.toolTip1.SetToolTip(this.nudInitiative, "Relative Human Values:\r\n1-2: Poor\r\n3: Average\r\n4-5: High Average\r\n6-7: Outstandin" +
        "g\r\n8: Exceptional\r\n9+: Superhuman\r\n");
            this.nudInitiative.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitiative.ValueChanged += new System.EventHandler(this.nudInitiative_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Agility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Toughness";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Intellect";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Willpower";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fellowship";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Initiative";
            // 
            // rtbValidation
            // 
            this.rtbValidation.Location = new System.Drawing.Point(15, 453);
            this.rtbValidation.Name = "rtbValidation";
            this.rtbValidation.Size = new System.Drawing.Size(336, 96);
            this.rtbValidation.TabIndex = 24;
            this.rtbValidation.Text = "Validation rules will appear here.";
            // 
            // WnGMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.rtbValidation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudInitiative);
            this.Controls.Add(this.nudFellowship);
            this.Controls.Add(this.nudWillpower);
            this.Controls.Add(this.nudIntellect);
            this.Controls.Add(this.nudToughness);
            this.Controls.Add(this.nudAgility);
            this.Controls.Add(this.nudStrength);
            this.Controls.Add(this.cmbArchetype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsedBuildPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvailableBuildPoints);
            this.Controls.Add(this.lstChooseTier);
            this.Name = "WnGMainForm";
            this.Text = "Wrath & Glory Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntellect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWillpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChooseTier;
        private System.Windows.Forms.Label lblAvailableBuildPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsedBuildPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArchetype;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.NumericUpDown nudAgility;
        private System.Windows.Forms.NumericUpDown nudToughness;
        private System.Windows.Forms.NumericUpDown nudIntellect;
        private System.Windows.Forms.NumericUpDown nudWillpower;
        private System.Windows.Forms.NumericUpDown nudFellowship;
        private System.Windows.Forms.NumericUpDown nudInitiative;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbValidation;
    }
}

