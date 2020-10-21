using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MarcinKrupnikLab2Zadanie
{
    public partial class LeaveTheDungeon : Form
    {
        Champion champion;
        Weapon weapon;
        Potion potion;
        Monster monster;
        Blessing blessing;
        Addict addict;
        //utworzenie intów
        int drawChamp = 0;
        int drawChampEnemy = 0;
        int drawWeapon = 0;
        int drawWeaponEnemy = 0;
        int drawPotion = 0;
        int drawMonster = 0;
        int drawMonsterEnemy = 0;
        int drawPotionEnemy = 0;
        int drawBlessing = 0;
        int drawBlessingEnemy = 0;
        int numberTime = 0;
        int numberTimeMin = 0;
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        int oneEnemy = 0;
        int twoEnemy = 0;
        int threeEnemy = 0;
        int fourEnemy = 0;
        int fiveEnemy = 0;
        int score = 0;
        int scoreEnemy = 0;

        public LeaveTheDungeon()
        {
            InitializeComponent();
        }
        /// <summary>
        /// utworzenie messagebox na start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveTheDungeon_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("It is card game for 2 people. You need to draw 5 cards. Scores of cards are the sum on theirs specs. When u click check u will got point if you will have better cards");
        }
        /// <summary>
        /// utworzenie przycisków do losowania kart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (drawChamp == 0)
            {   
                // losowanie karty
                Random draw = new Random();
                drawChamp = draw.Next(1, 4);
                if (drawChamp == 1)
                {
                    string champ = "Edgar";
                    champion = new Edgar();
                    // pokazanie karty na ekranie
                    buttonDraw.Text = champ.ToString();
                    labelHp.Text = champion.GetHp().ToString();
                    labelAtc.Text = champion.GetAtc().ToString();
                    labelArm.Text = champion.GetArm().ToString();
                    drawChamp = 4;


                }
                if (drawChamp == 2)
                {
                    string champ = "Elise";
                    champion = new Elise();
                    buttonDraw.Text = champ.ToString();
                    labelHp.Text = champion.GetHp().ToString();
                    labelAtc.Text = champion.GetAtc().ToString();
                    labelArm.Text = champion.GetArm().ToString();
                    drawChamp = 4;
                }
                if (drawChamp == 3)
                {
                    string champ = "Edmund";
                    buttonDraw.Text = champ.ToString();
                    champion = new Edmund();
                    labelHp.Text = champion.GetHp().ToString();
                    labelAtc.Text = champion.GetAtc().ToString();
                    labelArm.Text = champion.GetArm().ToString();
                    drawChamp = 4;
                }

            }
        }

        /// <summary>
        /// utworzenie timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnd_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberTime++;
            // zamiana sekund na minuty
            if (numberTime % 60 == 0)
            {
                numberTime -= 60;
                numberTimeMin++;
                labelTimeMin.Text = numberTimeMin.ToString();
                labelTimeMin.Text = "min";
                labelMin.Text = numberTimeMin.ToString();
            }
            labelTime.Text = numberTime.ToString();
            // zdarzenia czasowe
            if (numberTimeMin == 1 && numberTime == 0)
            {
                addict = new AddictOne();
                MessageBox.Show(addict.Addictive());
            }
            if (numberTimeMin == 2 && numberTime == 0)
            {
                addict = new AddictTwo();
                MessageBox.Show(addict.Addictive());
            }
            if (numberTimeMin == 3 && numberTime == 0)
            {
                addict = new AddictThree();
                MessageBox.Show(addict.Addictive());
            }
        }
        /// <summary>
        /// utworzenie radiobuttona  do włączania czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonTimerOn_CheckedChanged(object sender, EventArgs e)
        {
            timerEnd.Start();
            timerEnd.Interval = 1000;
        }
        /// <summary>
        /// utworzenie radiobuttona do wyłączania czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonTimerOff_CheckedChanged(object sender, EventArgs e)
        {
            timerEnd.Stop();
        }
        /// <summary>
        /// utworzenie wszystkich przycisków do losowania kart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawEnemy_Click(object sender, EventArgs e)
        {
            if (drawChampEnemy == 0)
            {
                Random draw = new Random();
                drawChampEnemy = draw.Next(1, 4);
                if (drawChampEnemy == 1)
                {
                    string champ = "Edgar";
                    champion = new Edgar();
                    buttonDrawEnemy.Text = champ.ToString();
                    labelHpEnemy.Text = champion.GetHp().ToString();
                    labelAtcEnemy.Text = champion.GetAtc().ToString();
                    labelArmEnemy.Text = champion.GetArm().ToString();
                    drawChampEnemy = 4;


                }
                if (drawChampEnemy == 2)
                {
                    string champ = "Elise";
                    champion = new Elise();
                    buttonDrawEnemy.Text = champ.ToString();
                    labelHpEnemy.Text = champion.GetHp().ToString();
                    labelAtcEnemy.Text = champion.GetAtc().ToString();
                    labelArmEnemy.Text = champion.GetArm().ToString();
                    drawChampEnemy = 4;
                }
                if (drawChampEnemy == 3)
                {
                    string champ = "Edmund";
                    buttonDrawEnemy.Text = champ.ToString();
                    champion = new Edmund();
                    labelHpEnemy.Text = champion.GetHp().ToString();
                    labelAtcEnemy.Text = champion.GetAtc().ToString();
                    labelArmEnemy.Text = champion.GetArm().ToString();
                    drawChampEnemy = 4;
                }

            }
        }

       

        private void buttonDrawWeapon_Click(object sender, EventArgs e)
        {
            if (drawWeapon == 0)
            {
                Random draw = new Random();
                drawWeapon = draw.Next(1, 4);
                if (drawWeapon == 1)
                {
                    string wea = "Bow";
                    weapon = new Bow();
                    buttonDrawWeapon.Text = wea.ToString();
                    labelStrength.Text = weapon.GetStrength().ToString();
                    labelAtcW.Text = weapon.GetAtc().ToString();
                    labelRange.Text = weapon.GetRange().ToString();
                    drawWeapon = 4;


                }
                if (drawWeapon == 2)
                {
                    string wea = "Axe";
                    weapon = new Axe();
                    buttonDrawWeapon.Text = wea.ToString();
                    labelStrength.Text = weapon.GetStrength().ToString();
                    labelAtcW.Text = weapon.GetAtc().ToString();
                    labelRange.Text = weapon.GetRange().ToString();
                    drawWeapon = 4;
                }
                if (drawWeapon == 3)
                {
                    string wea = "Sword";
                    buttonDrawWeapon.Text = wea.ToString();
                    weapon = new Sword();
                    labelStrength.Text = weapon.GetStrength().ToString();
                    labelAtcW.Text = weapon.GetAtc().ToString();
                    labelRange.Text = weapon.GetStrength().ToString();
                    drawWeapon = 4;
                }

            }
        }
        private void buttonDrawWeaponEnemy_Click(object sender, EventArgs e)
        {
            if (drawWeaponEnemy == 0)
            {
                Random draw = new Random();
                drawWeaponEnemy = draw.Next(1, 4);
                if (drawWeaponEnemy == 1)
                {
                    string wea = "Bow";
                    weapon = new Bow();
                    buttonDrawWeaponEnemy.Text = wea.ToString();
                    labelStrengthEnemy.Text = weapon.GetStrength().ToString();
                    labelAtcWEnemy.Text = weapon.GetAtc().ToString();
                    labelRangeEnemy.Text = weapon.GetRange().ToString();
                    drawWeaponEnemy = 4;


                }
                if (drawWeaponEnemy == 2)
                {
                    string wea = "Axe";
                    weapon = new Axe();
                    buttonDrawWeaponEnemy.Text = wea.ToString();
                    labelStrengthEnemy.Text = weapon.GetStrength().ToString();
                    labelAtcWEnemy.Text = weapon.GetAtc().ToString();
                    labelRangeEnemy.Text = weapon.GetRange().ToString();
                    drawWeaponEnemy = 4;
                }
                if (drawWeaponEnemy == 3)
                {
                    string wea = "Sword";
                    buttonDrawWeaponEnemy.Text = wea.ToString();
                    weapon = new Sword();
                    labelStrengthEnemy.Text = weapon.GetStrength().ToString();
                    labelAtcWEnemy.Text = weapon.GetAtc().ToString();
                    labelRangeEnemy.Text = weapon.GetStrength().ToString();
                    drawWeaponEnemy = 4;
                }

            }
        }

        private void buttonDrawPotion_Click(object sender, EventArgs e)
        {
            if (drawPotion == 0)
            {
                Random draw = new Random();
                drawPotion = draw.Next(1, 4);
                if (drawPotion == 1)
                {
                    string pot = "Mana Potion";
                    potion = new PotionMana();
                    buttonDrawPotion.Text = pot.ToString();
                    labelHpP.Text = potion.GetHp().ToString();
                    labelMana.Text = potion.GetMana().ToString();
                    labelPower.Text = potion.GetPower().ToString();
                    drawPotion = 4;


                }
                if (drawPotion == 2)
                {
                    string pot = "Hp Potion";
                    potion = new PotionHp();
                    buttonDrawPotion.Text = pot.ToString();
                    labelHpP.Text = potion.GetHp().ToString();
                    labelMana.Text = potion.GetMana().ToString();
                    labelPower.Text = potion.GetPower().ToString();
                    drawPotion = 4;
                }
                if (drawPotion == 3)
                {
                    string pot = "Power Potion";
                    buttonDrawPotion.Text = pot.ToString();
                    potion = new PotionPower();
                    labelHpP.Text = potion.GetHp().ToString();
                    labelMana.Text = potion.GetMana().ToString();
                    labelPower.Text = potion.GetPower().ToString();
                    drawPotion = 4;
                }


            }
        }

        private void buttonDrawPotionEnemy_Click(object sender, EventArgs e)
        {
            if (drawPotionEnemy == 0)
            {
                Random draw = new Random();
                drawPotionEnemy = draw.Next(1, 4);
                if (drawPotionEnemy == 1)
                {
                    string pot = "Mana Potion";
                    potion = new PotionMana();
                    buttonDrawPotionEnemy.Text = pot.ToString();
                    labelHpPEnemy.Text = potion.GetHp().ToString();
                    labelManaEnemy.Text = potion.GetMana().ToString();
                    labelPowerEnemy.Text = potion.GetPower().ToString();
                    drawPotionEnemy = 4;


                }
                if (drawPotionEnemy == 2)
                {
                    string pot = "Hp Potion";
                    potion = new PotionHp();
                    buttonDrawPotionEnemy.Text = pot.ToString();
                    labelHpPEnemy.Text = potion.GetHp().ToString();
                    labelManaEnemy.Text = potion.GetMana().ToString();
                    labelPowerEnemy.Text = potion.GetPower().ToString();
                    drawPotionEnemy = 4;
                }
                if (drawPotionEnemy == 3)
                {
                    string pot = "Power Potion";
                    buttonDrawPotionEnemy.Text = pot.ToString();
                    potion = new PotionPower();
                    labelHpPEnemy.Text = potion.GetHp().ToString();
                    labelManaEnemy.Text = potion.GetMana().ToString();
                    labelPowerEnemy.Text = potion.GetPower().ToString();
                    drawPotionEnemy = 4;
                }

            }
        }

        private void buttonDrawMonster_Click(object sender, EventArgs e)
        {
            if (drawMonster == 0)
            {
                Random draw = new Random();
                drawMonster = draw.Next(1, 4);
                if (drawMonster == 1)
                {
                    string mon = "Skeleton";
                    monster = new Skeleton();
                    buttonDrawMonster.Text = mon.ToString();
                    labelHpM.Text = monster.GetHp().ToString();
                    labelAtcM.Text = monster.GetAtc().ToString();
                    labelArmM.Text = monster.GetArm().ToString();
                    drawMonster = 4;


                }
                if (drawMonster == 2)
                {
                    string mon = "Zombie";
                    monster = new Zombie();
                    buttonDrawMonster.Text = mon.ToString();
                    labelHpM.Text = monster.GetHp().ToString();
                    labelAtcM.Text = monster.GetAtc().ToString();
                    labelArmM.Text = monster.GetArm().ToString();
                    drawMonster = 4;
                }
                if (drawMonster == 3)
                {
                    string mon = "Slime";
                    buttonDrawMonster.Text = mon.ToString();
                    monster = new Slime();
                    labelHpM.Text = monster.GetHp().ToString();
                    labelAtcM.Text = monster.GetAtc().ToString();
                    labelArmM.Text = monster.GetArm().ToString();
                    drawMonster = 4;
                }

            }



        }

        private void buttonDrawMonsterEnemy_Click(object sender, EventArgs e)
        {
            if (drawMonsterEnemy == 0)
            {
                Random draw = new Random();
                drawMonsterEnemy = draw.Next(1, 4);
                if (drawMonsterEnemy == 1)
                {
                    string mon = "Skeleton";
                    monster = new Skeleton();
                    buttonDrawMonsterEnemy.Text = mon.ToString();
                    labelHpMEnemy.Text = monster.GetHp().ToString();
                    labelAtcMEnemy.Text = monster.GetAtc().ToString();
                    labelArmMEnemy.Text = monster.GetArm().ToString();
                    drawMonsterEnemy = 4;


                }
                if (drawMonsterEnemy == 2)
                {
                    string mon = "Zombie";
                    monster = new Zombie();
                    buttonDrawMonsterEnemy.Text = mon.ToString();
                    labelHpMEnemy.Text = monster.GetHp().ToString();
                    labelAtcMEnemy.Text = monster.GetAtc().ToString();
                    labelArmMEnemy.Text = monster.GetArm().ToString();
                    drawMonsterEnemy = 4;
                }
                if (drawMonsterEnemy == 3)
                {
                    string mon = "Slime";
                    buttonDrawMonsterEnemy.Text = mon.ToString();
                    monster = new Slime();
                    labelHpMEnemy.Text = monster.GetHp().ToString();
                    labelAtcMEnemy.Text = monster.GetAtc().ToString();
                    labelArmMEnemy.Text = monster.GetArm().ToString();
                    drawMonsterEnemy = 4;
                }

            }



        }

        private void buttonDrawBlessing_Click(object sender, EventArgs e)
        {
            if (drawBlessing == 0)
            {
                Random draw = new Random();
                drawBlessing = draw.Next(1, 4);
                if (drawBlessing == 1)
                {
                    string ble = "Janusz Pira-Midke";
                    blessing = new Janusz();
                    buttonDrawBlessing.Text = ble.ToString();
                    labelRig.Text = blessing.GetRig().ToString();
                    labelPro.Text = blessing.GetPro().ToString();
                    labelDiv.Text = blessing.GetDiv().ToString();
                    drawBlessing = 4;


                }
                if (drawBlessing == 2)
                {
                    string ble = "Zeus";
                    blessing = new Zeus();
                    buttonDrawBlessing.Text = ble.ToString();
                    labelRig.Text = blessing.GetRig().ToString();
                    labelPro.Text = blessing.GetPro().ToString();
                    labelDiv.Text = blessing.GetDiv().ToString();
                    drawBlessing = 4;
                }
                if (drawBlessing == 3)
                {
                    string ble = "Hades";
                    buttonDrawBlessing.Text = ble.ToString();
                    blessing = new Hades();
                    labelRig.Text = blessing.GetRig().ToString();
                    labelPro.Text = blessing.GetPro().ToString();
                    labelDiv.Text = blessing.GetDiv().ToString();
                    drawBlessing = 4;
                }

            }



        }

        private void buttonDrawBlessingEnemy_Click(object sender, EventArgs e)
        {
            if (drawBlessingEnemy == 0)
            {
                Random draw = new Random();
                drawBlessingEnemy = draw.Next(1, 4);
                if (drawBlessingEnemy == 1)
                {
                    string ble = "Janusz Pira-Midke";
                    blessing = new Janusz();
                    buttonDrawBlessingEnemy.Text = ble.ToString();
                    labelRigEnemy.Text = blessing.GetRig().ToString();
                    labelProEnemy.Text = blessing.GetPro().ToString();
                    labelDivEnemy.Text = blessing.GetDiv().ToString();
                    drawBlessingEnemy = 4;


                }
                if (drawBlessingEnemy == 2)
                {
                    string ble = "Zeus";
                    blessing = new Zeus();
                    buttonDrawBlessingEnemy.Text = ble.ToString();
                    labelRigEnemy.Text = blessing.GetRig().ToString();
                    labelProEnemy.Text = blessing.GetPro().ToString();
                    labelDivEnemy.Text = blessing.GetDiv().ToString();
                    drawBlessingEnemy = 4;
                }
                if (drawBlessingEnemy == 3)
                {
                    string ble = "Hades";
                    buttonDrawBlessingEnemy.Text = ble.ToString();
                    blessing = new Hades();
                    labelRigEnemy.Text = blessing.GetRig().ToString();
                    labelProEnemy.Text = blessing.GetPro().ToString();
                    labelDivEnemy.Text = blessing.GetDiv().ToString();
                    drawBlessingEnemy = 4;
                }

            }
        }
        /// <summary>
        ///  utworzenie przycisku od podliczania punktów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // sprawdzanie kto dostał punkty za dane karty
            if (int.Parse(labelHpEnemy.Text) + int.Parse(labelAtcEnemy.Text) + int.Parse(labelArmEnemy.Text) > int.Parse(labelHp.Text) + int.Parse(labelAtc.Text) + int.Parse(labelArm.Text))
            {
                oneEnemy++;
            }
            else if (int.Parse(labelHpEnemy.Text) + int.Parse(labelAtcEnemy.Text) + int.Parse(labelArmEnemy.Text) == int.Parse(labelHp.Text) + int.Parse(labelAtc.Text) + int.Parse(labelArm.Text))
                one = 0;
            else one++;

            if (int.Parse(labelStrengthEnemy.Text) + int.Parse(labelAtcWEnemy.Text) + int.Parse(labelRangeEnemy.Text) > int.Parse(labelStrength.Text) + int.Parse(labelAtcW.Text) + int.Parse(labelRange.Text))
            {
                twoEnemy++;
            }
            else if (int.Parse(labelStrengthEnemy.Text) + int.Parse(labelAtcWEnemy.Text) + int.Parse(labelRangeEnemy.Text) == int.Parse(labelStrength.Text) + int.Parse(labelAtcW.Text) + int.Parse(labelRange.Text))
                two = 0;
            else
                two++;

            if (int.Parse(labelHpPEnemy.Text) + int.Parse(labelManaEnemy.Text) + int.Parse(labelPowerEnemy.Text) > int.Parse(labelHpP.Text) + int.Parse(labelMana.Text) + int.Parse(labelPower.Text))
            {
                threeEnemy++;
            }
            else if (int.Parse(labelHpPEnemy.Text) + int.Parse(labelManaEnemy.Text) + int.Parse(labelPowerEnemy.Text) == int.Parse(labelHpP.Text) + int.Parse(labelMana.Text) + int.Parse(labelPower.Text))
                three = 0; 
            else
                three++;

            if (int.Parse(labelHpMEnemy.Text) + int.Parse(labelAtcMEnemy.Text) + int.Parse(labelArmMEnemy.Text) > int.Parse(labelHpM.Text) + int.Parse(labelAtcM.Text) + int.Parse(labelArmM.Text))
            {
                fourEnemy++;
            }
            else if (int.Parse(labelHpMEnemy.Text) + int.Parse(labelAtcMEnemy.Text) + int.Parse(labelArmMEnemy.Text) == int.Parse(labelHpM.Text) + int.Parse(labelAtcM.Text) + int.Parse(labelArmM.Text))
                four = 0;
            else
                four++;

            if (int.Parse(labelRigEnemy.Text) + int.Parse(labelProEnemy.Text) + int.Parse(labelDivEnemy.Text) > int.Parse(labelRig.Text) + int.Parse(labelPro.Text) + int.Parse(labelDiv.Text))
            {
                fiveEnemy++;
            }
            else if (int.Parse(labelRigEnemy.Text) + int.Parse(labelProEnemy.Text) + int.Parse(labelDivEnemy.Text) == int.Parse(labelRig.Text) + int.Parse(labelPro.Text) + int.Parse(labelDiv.Text))
                five = 0;
            else
                five++;

            //zliczenie punktów
            if (one + two + three + four + five < oneEnemy + twoEnemy + threeEnemy + fourEnemy + fiveEnemy)
            {
                scoreEnemy++;
                labelScoreEnemy.Text = scoreEnemy.ToString();
                
            }
            if (one + two + three + four + five > oneEnemy + twoEnemy + threeEnemy + fourEnemy + fiveEnemy)
            {
                //dodanie punkta
                score++;
                labelScore.Text = score.ToString();
                
            }
            else
            {
               
            }
            //reset kart
            drawChamp = 0;
            drawChampEnemy = 0;
            drawWeapon = 0;
            drawWeaponEnemy = 0;
            drawPotion = 0;
            drawMonster = 0;
            drawMonsterEnemy = 0;
            drawPotionEnemy = 0;
            drawBlessing = 0;
            drawBlessingEnemy = 0;
            numberTime = 0;
            numberTimeMin = 0;
            one = 0;
            two = 0;
            three = 0;
            four = 0;
            five = 0;
            oneEnemy = 0;
            twoEnemy = 0;
            threeEnemy = 0;
            fourEnemy = 0;
            fiveEnemy = 0;
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"Save.txt"))
            {

                sw.WriteLine(score);
                
            }
            using (StreamWriter swE = new StreamWriter(@"SaveEnemy.txt"))
            {

                swE.WriteLine(scoreEnemy);

            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"Save.txt"))
            {
                
                    score = int.Parse(sr.ReadLine());
                    labelScore.Text = score.ToString();
                    
            }
            using (StreamReader srE = new StreamReader(@"Save.txt"))
            {

                scoreEnemy = int.Parse(srE.ReadLine());
                labelScoreEnemy.Text = scoreEnemy.ToString();

            }
        }
    }
}    
