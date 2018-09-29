﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrathAndGloryCharacterCreator
{
    public partial class WnGMainForm : Form
    {
        int currentBuildPoints = 0;
        int availableBuildPoints = 0;
        int buildPointsFromSpecies = 0;
        int buildPointsFromStrength = 0;
        int buildPointsFromAgility = 0;
        int buildPointsFromToughness = 0;
        int buildPointsFromIntellect = 0;
        int buildPointsFromWillpower = 0;
        int buildPointsFromFellowship = 0;
        int buildPointsFromInitiative = 0;

        List<string> validationRules = new List<string>();

        string tooManyBuildPoints = "";

        public WnGMainForm()
        {
            InitializeComponent();
                        
        }

        private void lstChooseTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTier = lstChooseTier.SelectedItem.ToString();
            switch (selectedTier)
            {
                case "Tier 1":
                    availableBuildPoints = 100;
                    lblAvailableBuildPoints.Text = availableBuildPoints.ToString();
                    SetAttributeMaximumsFromTier(4);
                    break;
                case "Tier 2":
                    availableBuildPoints = 200;
                    lblAvailableBuildPoints.Text = availableBuildPoints.ToString();
                    SetAttributeMaximumsFromTier(6);
                    break;
                case "Tier 3":
                    availableBuildPoints = 300;
                    lblAvailableBuildPoints.Text = availableBuildPoints.ToString();
                    SetAttributeMaximumsFromTier(8);
                    break;
                case "Tier 4":
                    availableBuildPoints = 400;
                    lblAvailableBuildPoints.Text = availableBuildPoints.ToString();
                    SetAttributeMaximumsFromTier(10);
                    break;
                case "Tier 5":
                    availableBuildPoints = 500;
                    lblAvailableBuildPoints.Text = availableBuildPoints.ToString();
                    SetAttributeMaximumsFromTier(12);
                    break;
                default:
                    lblAvailableBuildPoints.Text = "0";
                    break;
            }
        }

        private void SetAttributeMaximumsFromTier(int maximum)
        {
            nudAgility.Maximum = maximum;
            nudFellowship.Maximum = maximum;
            nudInitiative.Maximum = maximum;
            nudIntellect.Maximum = maximum;
            nudStrength.Maximum = maximum;
            nudToughness.Maximum = maximum;
            nudWillpower.Maximum = maximum;
        }

        private void CalculateBuildPoints()
        {
            currentBuildPoints = buildPointsFromSpecies + 
                buildPointsFromStrength +
                buildPointsFromAgility +
                buildPointsFromToughness + 
                buildPointsFromIntellect +
                buildPointsFromWillpower + 
                buildPointsFromFellowship +
                buildPointsFromInitiative
                ;
            lblUsedBuildPoints.Text = currentBuildPoints.ToString();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecies = cmbSpecies.SelectedItem.ToString();
            switch (selectedSpecies)
            {
                case "Human":
                    buildPointsFromSpecies = 0;
                    break;
                case "Eldar":
                    buildPointsFromSpecies = 10;
                    break;
                case "Ork":
                    buildPointsFromSpecies = 10;
                    break;
                case "Adeptus Astartes":
                    buildPointsFromSpecies = 50;
                    break;
                case "Primaris Astartes":
                    buildPointsFromSpecies = 100;
                    break;
                default:
                    buildPointsFromSpecies = 0;
                    break;
            }

            CalculateBuildPoints();
        }

        private void CalculateAttributeCost(NumericUpDown attribute)
        {
            int value = Decimal.ToInt16(attribute.Value);
            switch (value)
            {
                case 1:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 0;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 0;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 0;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 0;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 0;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 0;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 0;
                            break;
                        default:
                            break;
                    }   
                    break;
                case 2:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 4;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 4;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 4;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 4;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 4;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 4;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 4;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 10;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 10;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 10;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 10;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 10;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 10;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 10;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 18;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 18;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 18;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 18;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 18;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 18;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 18;
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 33;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 33;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 33;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 33;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 33;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 33;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 33;
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 51;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 51;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 51;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 51;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 51;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 51;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 51;
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 72;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 72;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 72;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 72;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 72;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 72;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 72;
                            break;
                        default:
                            break;
                    }
                    break;
                case 8:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 104;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 104;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 104;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 104;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 104;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 104;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 104;
                            break;
                        default:
                            break;
                    }
                    break;
                case 9:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 140;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 140;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 140;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 140;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 140;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 140;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 140;
                            break;
                        default:
                            break;
                    }
                    break;
                case 10:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 180;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 180;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 180;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 180;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 180;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 180;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 180;
                            break;
                        default:
                            break;
                    }
                    break;
                case 11:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 235;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 235;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 235;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 235;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 235;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 235;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 235;
                            break;
                        default:
                            break;
                    }
                    break;
                case 12:
                    switch (attribute.Name.ToString())
                    {
                        case "nudStrength":
                            buildPointsFromStrength = 307;
                            break;
                        case "nudAgility":
                            buildPointsFromAgility = 307;
                            break;
                        case "nudToughness":
                            buildPointsFromToughness = 307;
                            break;
                        case "nudIntellect":
                            buildPointsFromIntellect = 307;
                            break;
                        case "nudWillpower":
                            buildPointsFromWillpower = 307;
                            break;
                        case "nudFellowship":
                            buildPointsFromFellowship = 307;
                            break;
                        case "nudInitiative":
                            buildPointsFromInitiative = 307;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            CalculateBuildPoints();
        }

        private void nudStrength_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudStrength);
            ValidateBuildPoints();
        }

        private void nudAgility_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudAgility);
            ValidateBuildPoints();
        }

        private void nudToughness_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudToughness);
            ValidateBuildPoints();
        }

        private void nudIntellect_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudIntellect);
            ValidateBuildPoints();
        }

        private void nudWillpower_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudWillpower);
            ValidateBuildPoints();
        }

        private void nudFellowship_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudFellowship);
            ValidateBuildPoints();
        }

        private void nudInitiative_ValueChanged(object sender, EventArgs e)
        {
            CalculateAttributeCost(nudInitiative);
            ValidateBuildPoints();
        }

        private void ValidateBuildPoints()
        {
            tooManyBuildPoints = "You have used too many build points.";
            if (currentBuildPoints > availableBuildPoints && !validationRules.Contains(tooManyBuildPoints))
            {
                validationRules.Add(tooManyBuildPoints);
                AddTexttoValidationBox();
            }
            if(currentBuildPoints < availableBuildPoints && validationRules.Contains(tooManyBuildPoints))
            {
                validationRules.Remove(tooManyBuildPoints);
                AddTexttoValidationBox();
            }
        }

        private void AddTexttoValidationBox()
        {
            rtbValidation.Text = "Validation rules will appear here.";
            for (int i = 0; i < validationRules.Count; i++)
            {
                rtbValidation.Text = validationRules[i].ToString();
            }
        }
    }
}