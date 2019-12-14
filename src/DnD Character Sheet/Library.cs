﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DnD_Character_Sheet;
using LC = DnD_Character_Sheet.Constants;

namespace DnD_Character_Sheet
{
    class Library
    {
        /// <summary>
        /// This holds all information read in from the character sheet
        /// Key: Character Name
        /// Value: New Dictionary
        ///     Key: Character Data
        ///     Value: Character Value
        /// </summary>
        public static Dictionary<string, Dictionary<string, string>> m_CharData = new Dictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// This contains all skills the current character is proficient in
        /// Key: Character Name
        /// Value: New Dictionary
        ///     Key: Character Data
        ///     Value: Character Value
        /// </summary>
        public static Dictionary<string, Dictionary<string, bool>> m_ProficientData = new Dictionary<string, Dictionary<string, bool>>();

        /// <summary>
        /// This holds the current characters name
        /// This is also the main Key used in dictionaries
        /// </summary>
        public static string m_CharacterName;

        /// <summary>
        /// This Holds all information on the current character
        /// </summary>
        public static MainCharacterInfo m_MainCharacterInfo = new MainCharacterInfo();

        /// <summary>
        /// This dictionary holds all information on each race
        /// Key: Race
        /// Value: New List<string>
        ///     Value: Subrace
        /// </summary>
        public static Dictionary<string, List<string>> m_RaceLibrary = new Dictionary<string, List<string>>();

        /// <summary>
        /// Is the character using the Player Hand Book
        /// </summary>
        public static Dictionary<string, bool> m_BookUtilization = new Dictionary<string, bool>();

        /// <summary>
        /// This dictionary holds all information on Armor from selected manuals
        /// Key: Armor Name
        /// Value: New Armor
        /// </summary>
        public static Dictionary<string, LC.Armor> m_ArmorLibrary = new Dictionary<string, LC.Armor>();

        /// <summary>
        /// This dictionary holds all information on Weapons from selected manuals
        /// Key: Weapon Name
        /// Value: New Weapon
        /// </summary>
        public static Dictionary<string, LC.Weapon> m_WeaponLibrary = new Dictionary<string, LC.Weapon>();

        public static bool m_CharacterLoaded = false;

        public static void ClearLibrary()
        {
            m_CharData.Clear();
            m_ProficientData.Clear();
            m_BookUtilization.Clear();
            m_ArmorLibrary.Clear();
            m_RaceLibrary.Clear();
            m_WeaponLibrary.Clear();
        }

        /// <summary>
        /// Update the skills for the main character
        /// </summary>
        /// <param name="skillName">Name of the Changed Skill</param>
        /// <param name="skillBonus">New value for the skill</param>
        /// <param name="check">If the skill has proficiency</param>
        public static void UpdateLibrary(string skillName, string skillBonus, bool check)
        {
            switch (skillName)
            {
                case (LC.Acrobatics):
                    {
                        m_MainCharacterInfo.Skills.Acrobatics = skillBonus;
                        m_MainCharacterInfo.Skills._Acrobatics = check;
                        break;
                    }
                case (LC.AnimalHandling_Spaced):
                    {
                        m_MainCharacterInfo.Skills.AnimalHandling = skillBonus;
                        m_MainCharacterInfo.Skills._AnimalHandling = check;
                        break;
                    }
                case (LC.Arcana):
                    {
                        m_MainCharacterInfo.Skills.Arcana = skillBonus;
                        m_MainCharacterInfo.Skills._Arcana = check;
                        break;
                    }
                case (LC.Athletics):
                    {
                        m_MainCharacterInfo.Skills.Athletics = skillBonus;
                        m_MainCharacterInfo.Skills._Athletics = check;
                        break;
                    }
                case (LC.Deception):
                    {
                        m_MainCharacterInfo.Skills.Deception = skillBonus;
                        m_MainCharacterInfo.Skills._Deception = check;
                        break;
                    }
                case (LC.History):
                    {
                        m_MainCharacterInfo.Skills.History = skillBonus;
                        m_MainCharacterInfo.Skills._History = check;
                        break;
                    }
                case (LC.Insight):
                    {
                        m_MainCharacterInfo.Skills.Insight = skillBonus;
                        m_MainCharacterInfo.Skills._Insight = check;
                        break;
                    }
                case (LC.Intimidation):
                    {
                        m_MainCharacterInfo.Skills.Intimidation = skillBonus;
                        m_MainCharacterInfo.Skills._Intimidation = check;
                        break;
                    }
                case (LC.Investigation):
                    {
                        m_MainCharacterInfo.Skills.Investigation = skillBonus;
                        m_MainCharacterInfo.Skills._Investigation = check;
                        break;
                    }
                case (LC.Medicine):
                    {
                        m_MainCharacterInfo.Skills.Medicine = skillBonus;
                        m_MainCharacterInfo.Skills._Medicine = check;
                        break;
                    }
                case (LC.Nature):
                    {
                        m_MainCharacterInfo.Skills.Nature = skillBonus;
                        m_MainCharacterInfo.Skills._Nature = check;
                        break;
                    }
                case (LC.Perception):
                    {
                        m_MainCharacterInfo.Skills.Perception = skillBonus;
                        m_MainCharacterInfo.Skills._Perception = check;
                        break;
                    }
                case (LC.Performance):
                    {
                        m_MainCharacterInfo.Skills.Performance = skillBonus;
                        m_MainCharacterInfo.Skills._Performance = check;
                        break;
                    }
                case (LC.Persuassion):
                    {
                        m_MainCharacterInfo.Skills.Persuassion = skillBonus;
                        m_MainCharacterInfo.Skills._Persuassion = check;
                        break;
                    }
                case (LC.Religion):
                    {
                        m_MainCharacterInfo.Skills.Religion = skillBonus;
                        m_MainCharacterInfo.Skills._Religion = check;
                        break;
                    }
                case (LC.SlightOfHand_Spaced):
                    {
                        m_MainCharacterInfo.Skills.SlightOfHand = skillBonus;
                        m_MainCharacterInfo.Skills._SlightOfHand = check;
                        break;
                    }
                case (LC.Stealth):
                    {
                        m_MainCharacterInfo.Skills.Stealth = skillBonus;
                        m_MainCharacterInfo.Skills._Stealth = check;
                        break;
                    }
                case (LC.Survival):
                    {
                        m_MainCharacterInfo.Skills.Survival = skillBonus;
                        m_MainCharacterInfo.Skills._Survival = check;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}