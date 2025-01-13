using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    internal class Character
    {
        public enum Class
        {
            Barbarian = 1,
            Bard = 2,
            Cleric = 3,
            Druid = 4,
            Fighter = 5,
            Monk = 6,
            Paladin = 7,
            Ranger = 8,
            Rough = 9,
            Sorcerer = 10,
            Warlock = 11,
            Wizard = 12
        }
        [Flags]public enum Savings : uint // Saving Throws
        {
            Strength = 1,
            Dexterity = 2,
            Constitution = 4,
            Intelligence = 8,
            Wisdom = 16,
            Charisma = 32
        }
        [Flags]public enum SkillProfs: uint
        {
            Acrobatics = 1, // DEX
            AnimalHandling = 2, // WIS
            Arcana = 4, // INT
            Athletics = 8, // STR
            Deception = 16, // CHA
            History = 32, // INT
            Insight = 64, // WIS
            Intimidation = 128, // CHA
            Investigation = 256, // INT
            Medicine = 512, // WIS
            Nature = 1024, // CHA
            Perception = 2048, // INT 
            Performance = 4096, // WIS
            Persuation = 8192, // CHA
            Religion = 16384, // INT
            SleightOfHand = 32768, // DEX
            Stealth = 65536, // DEX
            Survival = 131072 // WIS
        }
        public int StatStr { get; set; }
        public int StatDex { get; set; }
        public int StatCon { get; set; }
        public int StatInt { get; set; }
        public int StatWis { get; set; }
        public int StatCha { get; set; }
        public int StatStrBonus { get; set; }
        public int StatDexBonus { get; set; }
        public int StatConBonus { get; set; }
        public int StatIntBonus { get; set; }
        public int StatWisBonus { get; set; }
        public int StatChaBonus { get; set; }
        public int ProfBonus { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int PassivWis { get; set; }
        public int AC { get; set; }
        public int Init { get; set; }
        public int Speed { get; set; }
        public int HpMax { get; set; }
        public int HpCurrent { get; set; }
        public int HpTemp { get; set; }
        public string HitDice { get; set; }
        public string Race { get; set; }
        public string CharBackground { get; set; }
        public string PlayerName { get; set; }
        public string CharName { get; set; }
        public string Alignment { get; set; }
        public int Inspiration { get; set; }
        public SkillProfs Skills { get; set; }
        public Savings SavingThrows { get; set; }
        public Class CharacterClass { get; set; }


        /*
        My Implimentaion

        private void LoadCharacter()
        {
            Character character = new Character();
            tbx_xp.Text = character.Xp.ToString();
            tbx_lvl.Text = character.Level.ToString();
            tbx_charName.Text = character.CharName.ToString();
            tbx_class.Text = character.CharacterClass.ToString();
            tbx_inspiration.Text = character.Inspiration.ToString();
            tbx_passive.Text = character.PassivWis.ToString();
            tbx_proficency.Text = character.ProfBonus.ToString();
            tbx_statStr.Text = character.StatStr.ToString();
            tbx_statDex.Text = character.StatDex.ToString();
            tbx_statCon.Text = character.StatCon.ToString();
            tbx_statInt.Text = character.StatInt.ToString();
            tbx_statWis.Text = character.StatWis.ToString();
            tbx_statCha.Text = character.StatCha.ToString();
            tbx_statStrBonus.Text = character.StatStrBonus.ToString();
            tbx_statDexBonus.Text = character.StatDexBonus.ToString();
            tbx_statConBonus.Text = character.StatConBonus.ToString();
            tbx_statIntBonus.Text = character.StatIntBonus.ToString();
            tbx_statWisBonus.Text = character.StatWisBonus.ToString();
            tbx_statChaBonus.Text = character.StatChaBonus.ToString();
            tbx_class.Text = character.CharacterClass.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Strength))
                tbx_saveStr.Text = (character.StatStrBonus + character.ProfBonus).ToString();
            else
                tbx_saveStr.Text = character.StatStrBonus.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Dexterity))
                tbx_saveDex.Text = (character.StatDexBonus + character.ProfBonus).ToString();
            else
                tbx_saveDex.Text = character.StatDexBonus.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Constitution))
                tbx_saveCon.Text = (character.StatConBonus + character.ProfBonus).ToString();
            else
                tbx_saveCon.Text = character.StatConBonus.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Intelligence))
                tbx_saveInt.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_saveInt.Text = character.StatIntBonus.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Wisdom))
                tbx_saveWis.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_saveWis.Text = character.StatWisBonus.ToString();
            if (character.SavingThrows.HasFlag(Character.Savings.Charisma))
                tbx_saveCha.Text = (character.StatChaBonus + character.ProfBonus).ToString();
            else
                tbx_saveCha.Text = character.StatChaBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillAcrobatics.Text = (character.StatDexBonus + character.ProfBonus).ToString();
            else
                tbx_skillAcrobatics.Text = character.StatDexBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillAnimal.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_skillAnimal.Text = character.StatWisBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillArca.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_skillArca.Text = character.StatIntBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillAthle.Text = (character.StatStrBonus + character.ProfBonus).ToString();
            else
                tbx_skillAthle.Text = character.StatStrBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillDecep.Text = (character.StatChaBonus + character.ProfBonus).ToString();
            else
                tbx_skillDecep.Text = character.StatChaBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillHis.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_skillHis.Text = character.StatIntBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillIns.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_skillIns.Text = character.StatWisBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillIntimi.Text = (character.StatChaBonus + character.ProfBonus).ToString();
            else
                tbx_skillIntimi.Text = character.StatChaBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillInves.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_skillInves.Text = character.StatIntBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillMedi.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_skillMedi.Text = character.StatWisBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillNatu.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_skillNatu.Text = character.StatIntBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillPerc.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_skillPerc.Text = character.StatWisBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillPerfo.Text = (character.StatChaBonus + character.ProfBonus).ToString();
            else
                tbx_skillPerfo.Text = character.StatChaBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillPersu.Text = (character.StatChaBonus + character.ProfBonus).ToString();
            else
                tbx_skillPersu.Text = character.StatChaBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillReli.Text = (character.StatIntBonus + character.ProfBonus).ToString();
            else
                tbx_skillReli.Text = character.StatIntBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillSleight.Text = (character.StatDexBonus + character.ProfBonus).ToString();
            else
                tbx_skillSleight.Text = character.StatDexBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillStealth.Text = (character.StatDexBonus + character.ProfBonus).ToString();
            else
                tbx_skillStealth.Text = character.StatDexBonus.ToString();
            if (character.Skills.HasFlag(Character.SkillProfs.Acrobatics))
                tbx_skillSurvi.Text = (character.StatWisBonus + character.ProfBonus).ToString();
            else
                tbx_skillSurvi.Text = character.StatWisBonus.ToString();
        }

         */
    }

}
