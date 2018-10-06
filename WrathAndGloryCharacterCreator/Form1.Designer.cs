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
            this.lblKeywords = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.txtResilience = new System.Windows.Forms.TextBox();
            this.txtSoak = new System.Windows.Forms.TextBox();
            this.txtShock = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtWounds = new System.Windows.Forms.TextBox();
            this.txtPassiveAwareness = new System.Windows.Forms.TextBox();
            this.txtCorruption = new System.Windows.Forms.TextBox();
            this.txtConviction = new System.Windows.Forms.TextBox();
            this.txtWealth = new System.Windows.Forms.TextBox();
            this.txtInfluence = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResolve = new System.Windows.Forms.TextBox();
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
            "Ministorum Priest",
            "Death Cult Assassin"});
            this.cmbArchetype.Location = new System.Drawing.Point(13, 207);
            this.cmbArchetype.Name = "cmbArchetype";
            this.cmbArchetype.Size = new System.Drawing.Size(154, 24);
            this.cmbArchetype.TabIndex = 9;
            this.cmbArchetype.SelectedIndexChanged += new System.EventHandler(this.cmbArchetype_SelectedIndexChanged);
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
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.Location = new System.Drawing.Point(366, 470);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(0, 17);
            this.lblKeywords.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 453);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Keywords:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(193, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Wounds";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(193, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Speed";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "Shock";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(193, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "Soak";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(193, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 30;
            this.label19.Text = "Resilience";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(193, 250);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 29;
            this.label20.Text = "Defense";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(304, 362);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 17);
            this.label21.TabIndex = 38;
            this.label21.Text = "Resolve";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(304, 306);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "Passive";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(304, 278);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 17);
            this.label23.TabIndex = 36;
            this.label23.Text = "Corruption";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(304, 250);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 35;
            this.label24.Text = "Conviction";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(412, 278);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 17);
            this.label25.TabIndex = 40;
            this.label25.Text = "Wealth";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(412, 250);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 17);
            this.label26.TabIndex = 39;
            this.label26.Text = "Influence";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(193, 233);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 17);
            this.label27.TabIndex = 41;
            this.label27.Text = "Combat";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(304, 233);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 17);
            this.label28.TabIndex = 42;
            this.label28.Text = "Mental";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(412, 233);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 17);
            this.label29.TabIndex = 43;
            this.label29.Text = "Social";
            // 
            // txtDefense
            // 
            this.txtDefense.Location = new System.Drawing.Point(274, 250);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.ReadOnly = true;
            this.txtDefense.Size = new System.Drawing.Size(24, 22);
            this.txtDefense.TabIndex = 44;
            this.txtDefense.Text = "1";
            // 
            // txtResilience
            // 
            this.txtResilience.Location = new System.Drawing.Point(274, 278);
            this.txtResilience.Name = "txtResilience";
            this.txtResilience.ReadOnly = true;
            this.txtResilience.Size = new System.Drawing.Size(24, 22);
            this.txtResilience.TabIndex = 45;
            this.txtResilience.Text = "1";
            // 
            // txtSoak
            // 
            this.txtSoak.Location = new System.Drawing.Point(274, 306);
            this.txtSoak.Name = "txtSoak";
            this.txtSoak.ReadOnly = true;
            this.txtSoak.Size = new System.Drawing.Size(24, 22);
            this.txtSoak.TabIndex = 46;
            this.txtSoak.Text = "1";
            // 
            // txtShock
            // 
            this.txtShock.Location = new System.Drawing.Point(274, 334);
            this.txtShock.Name = "txtShock";
            this.txtShock.ReadOnly = true;
            this.txtShock.Size = new System.Drawing.Size(24, 22);
            this.txtShock.TabIndex = 47;
            this.txtShock.Text = "1";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(274, 362);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(24, 22);
            this.txtSpeed.TabIndex = 48;
            this.txtSpeed.Text = "1";
            // 
            // txtWounds
            // 
            this.txtWounds.Location = new System.Drawing.Point(274, 390);
            this.txtWounds.Name = "txtWounds";
            this.txtWounds.ReadOnly = true;
            this.txtWounds.Size = new System.Drawing.Size(24, 22);
            this.txtWounds.TabIndex = 49;
            this.txtWounds.Text = "1";
            // 
            // txtPassiveAwareness
            // 
            this.txtPassiveAwareness.Location = new System.Drawing.Point(382, 313);
            this.txtPassiveAwareness.Name = "txtPassiveAwareness";
            this.txtPassiveAwareness.ReadOnly = true;
            this.txtPassiveAwareness.Size = new System.Drawing.Size(24, 22);
            this.txtPassiveAwareness.TabIndex = 52;
            this.txtPassiveAwareness.Text = "1";
            // 
            // txtCorruption
            // 
            this.txtCorruption.Location = new System.Drawing.Point(382, 278);
            this.txtCorruption.Name = "txtCorruption";
            this.txtCorruption.ReadOnly = true;
            this.txtCorruption.Size = new System.Drawing.Size(24, 22);
            this.txtCorruption.TabIndex = 51;
            this.txtCorruption.Text = "1";
            // 
            // txtConviction
            // 
            this.txtConviction.Location = new System.Drawing.Point(382, 250);
            this.txtConviction.Name = "txtConviction";
            this.txtConviction.ReadOnly = true;
            this.txtConviction.Size = new System.Drawing.Size(24, 22);
            this.txtConviction.TabIndex = 50;
            this.txtConviction.Text = "1";
            // 
            // txtWealth
            // 
            this.txtWealth.Location = new System.Drawing.Point(480, 278);
            this.txtWealth.Name = "txtWealth";
            this.txtWealth.ReadOnly = true;
            this.txtWealth.Size = new System.Drawing.Size(24, 22);
            this.txtWealth.TabIndex = 54;
            this.txtWealth.Text = "1";
            // 
            // txtInfluence
            // 
            this.txtInfluence.Location = new System.Drawing.Point(480, 250);
            this.txtInfluence.Name = "txtInfluence";
            this.txtInfluence.ReadOnly = true;
            this.txtInfluence.Size = new System.Drawing.Size(24, 22);
            this.txtInfluence.TabIndex = 53;
            this.txtInfluence.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Awareness";
            // 
            // txtResolve
            // 
            this.txtResolve.Location = new System.Drawing.Point(382, 362);
            this.txtResolve.Name = "txtResolve";
            this.txtResolve.ReadOnly = true;
            this.txtResolve.Size = new System.Drawing.Size(24, 22);
            this.txtResolve.TabIndex = 56;
            this.txtResolve.Text = "1";
            // 
            // WnGMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtResolve);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtWealth);
            this.Controls.Add(this.txtInfluence);
            this.Controls.Add(this.txtPassiveAwareness);
            this.Controls.Add(this.txtCorruption);
            this.Controls.Add(this.txtConviction);
            this.Controls.Add(this.txtWounds);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtShock);
            this.Controls.Add(this.txtSoak);
            this.Controls.Add(this.txtResilience);
            this.Controls.Add(this.txtDefense);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblKeywords);
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
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtDefense;
        private System.Windows.Forms.TextBox txtResilience;
        private System.Windows.Forms.TextBox txtSoak;
        private System.Windows.Forms.TextBox txtShock;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtWounds;
        private System.Windows.Forms.TextBox txtPassiveAwareness;
        private System.Windows.Forms.TextBox txtCorruption;
        private System.Windows.Forms.TextBox txtConviction;
        private System.Windows.Forms.TextBox txtWealth;
        private System.Windows.Forms.TextBox txtInfluence;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResolve;
    }
}

