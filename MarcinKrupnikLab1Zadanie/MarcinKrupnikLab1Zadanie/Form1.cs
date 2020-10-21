using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinKrupnikLab1Zadanie
{
  
    
    public partial class FormMain : Form
    {
        // dopisanie bazowych wartości i utworzenie zmiennych
        int numberTime = 0;
        int numberTimeMin = 0;
        int numberPeople = 0;
        int numberMiner = 0;
        int numberIron = 0;
        int numberMarsShip = 0;
        int numberMars = 0;
        int numberJupiterShip = 0;
        int numberJupiter = 0;
        int numberSaturnShip = 0;
        int numberSaturn = 0;
        int numberUranusShip = 0;
        int numberUranus = 0;
        
        public FormMain()
        {
            InitializeComponent();
            // dodanie bazowych kolorów w tła
            buttonMiner.BackColor = Color.Red;
            buttonPeople.BackColor = Color.LightGreen;
            buttonMars.BackColor = Color.Red;
            buttonJupiter.BackColor = Color.Red;
            buttonSaturn.BackColor = Color.Red;
            buttonUranus.BackColor = Color.Red;
            buttonPortal.BackColor = Color.Red;
            labelDestination.BackColor = Color.LightBlue;
        }
        /// <summary>
        /// przycisk do tworzenia ludzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPeople_Click(object sender, EventArgs e)
        {
            // bazowe czynność jaką ma wykonywać przycisk
            numberPeople++;
            labelPeople.Text = numberPeople.ToString();
            // rozpoczęcie timera do czasu gry
            timerTime.Start();
            timerTime.Interval = 1000;
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 10)
            {
                buttonMiner.BackColor = Color.LightGreen;
            }
            else
            {
                buttonMiner.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// przycisk do tworzenia górników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMiner_Click(object sender, EventArgs e)
        {
            if (numberPeople >= 10)
            {
                // wynajęcie ludzi do kopania
                numberPeople -= 10;
                numberMiner++;
                // zmiana w label ilości ludzi od pracy
                labelMiner.Text = numberMiner.ToString();
                labelPeople.Text = numberPeople.ToString();
                // dodatek kolorystyczny aby było wiadome które przyciki można użyć
                if (numberPeople < 10)
                    buttonMiner.BackColor = Color.Red; 


            }
            // uruchomienie timera od żelaza
            if (numberMiner == 1)
            {
                timerIron.Start();
            }
            // nadanie odpowiedniej wartości timerowi
            if (numberMiner > 0)
            {
                timerIron.Interval = 100 / numberMiner * 10;
            }
            
                

        }
        
        /// <summary>
        /// timer do żelaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerIron_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberIron++;
            labelIron.Text = numberIron.ToString();
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 30 && numberIron >= 30)
            {
                buttonMars.BackColor = Color.LightGreen;
            }
            else
            {
                buttonMars.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// przycisk do tworzenia statku na Marsa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMars_Click(object sender, EventArgs e)
        {
            // bazowa czynność przycisku
            if (numberPeople >= 30 && numberIron >= 30)
            {
                // redukcja surowców na statek
                numberPeople -= 30;
                numberIron -= 30;
                numberMarsShip++;
                // zmiana w label ilości surowców
                labelPeople.Text = numberPeople.ToString();
                labelIron.Text = numberIron.ToString();
                labelMarsShip.Text = numberMarsShip.ToString();
                // dodatek kolorystyczny aby było wiadome które przyciki można użyć
                if (numberPeople < 30 && numberIron < 30)
                    buttonMars.BackColor = Color.Red;
            }
            // uruchomienie timera do marsa 
            if (numberMarsShip == 1)
            {
                timerMars.Start();
            }
            // nadanie odpowiedniej wartości do timera
            if (numberMarsShip > 0)
            {
                timerMars.Interval = 100 / numberMarsShip * 10;
            }
            
        }
        /// <summary>
        /// timer Marsa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMars_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberMars++;
            labelMars.Text = numberMars.ToString();
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 20 && numberIron >= 100 && numberMars >= 50)
            
                {
                    buttonJupiter.BackColor = Color.LightGreen;
                }
            else
                {
                    buttonJupiter.BackColor = Color.Red;
                }
            
        }
        /// <summary>
        /// przycisk do tworzenia statku na Jowisz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJupiter_Click(object sender, EventArgs e)
        {
            // bazowa czynność przycisku
            if (numberPeople >= 20 && numberIron >= 100 && numberMars >= 50)
            {
                // redukcja surowców na statek
                numberPeople -= 20;
                numberIron -= 100;
                numberMars -= 50;
                numberJupiterShip++;
                // zmiana w label ilości surowców
                labelPeople.Text = numberPeople.ToString();
                labelIron.Text = numberIron.ToString();
                labelMars.Text = numberMars.ToString();
                labelJupiterShip.Text = numberJupiterShip.ToString();
                // dodatek kolorystyczny aby było wiadome które przyciki można użyć
                if (numberPeople < 20 && numberIron < 100 && numberMars < 50)
                    buttonJupiter.BackColor = Color.Red;

            }
            // uruchomienie timera od jowisza
            if (numberJupiterShip == 1)
            {
                timerJupiter.Start();
            }
            // nadanie odpowiedniej wartości do timera
            if (numberJupiterShip > 0)
            {
                timerJupiter.Interval = 100 / numberJupiterShip * 10;
            }

        }
        /// <summary>
        /// timer na jowisz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerJupiter_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberJupiter++;
            labelJupiter.Text = numberJupiter.ToString();
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 10 && numberIron >= 100 && numberMars >= 50 && numberJupiter >= 50)
            {
                buttonSaturn.BackColor = Color.LightGreen;
            }
            else
            {
                buttonSaturn.BackColor = Color.Red;
            }
        }
        /// <summary>
        ///  przycisk do tworzenia statku na Uran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUranus_Click(object sender, EventArgs e)
        {
            // bazowa czynność przycisku
            if (numberPeople >= 100  && numberMars >= 30 && numberJupiter >= 10 && numberSaturn >= 90)
            {
                // redukcja surowców na statek
                numberPeople -= 100;
                numberMars -= 30;
                numberJupiter -= 10;
                numberSaturn -= 90;
                numberUranusShip++;
                // zmiana w label ilości surowców
                labelPeople.Text = numberPeople.ToString();
                labelMars.Text = numberMars.ToString();
                labelSaturn.Text = numberSaturn.ToString();
                labelUranus.Text = numberUranus.ToString();
                labelUranusShip.Text = numberUranusShip.ToString();
                // dodatek kolorystyczny aby było wiadome które przyciki można użyć
                if (numberPeople < 100 && numberMars < 30 && numberJupiter < 10 && numberSaturn < 90)
                    buttonUranus.BackColor = Color.Red;

            }
            // uruchomienie timera od uranu
            if (numberUranusShip == 1)
            {
                timerUranus.Start();
            }
            // nadanie odpowiedniej wartości do timera
            if (numberUranusShip > 0)
            {
                timerUranus.Interval = 100 / numberUranusShip * 10;
            }
            
        }
        /// <summary>
        /// timer na uran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUranus_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberUranus++;
            labelUranus.Text = numberUranus.ToString();
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 100 && numberIron >= 100 && numberMars >= 100 && numberJupiter >= 100 && numberUranus >= 100 && numberSaturn >= 100 )
                buttonPortal.BackColor = Color.LightGreen;
        }
        /// <summary>
        /// timer na saturn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSaturn_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera 
            numberSaturn++;
            labelSaturn.Text = numberSaturn.ToString();
            // dodatek kolorystyczny aby było wiadome które przyciki można użyć
            if (numberPeople >= 100 && numberMars >= 30 && numberJupiter >= 10 && numberSaturn >= 90)
            {
                buttonUranus.BackColor = Color.LightGreen;
            }
            else
            {
                buttonUranus.BackColor = Color.Red;
            }

        }
        /// <summary>
        /// przycisk do tworzenia statku na Saturn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaturn_Click(object sender, EventArgs e)
        {
            // bazowa czynność aplikacji
            if (numberPeople >= 10 && numberIron >= 100 && numberMars >= 50 && numberJupiter >= 50)
            {
                // redukcja surowców na statek
                numberPeople -= 10;
                numberIron -= 100;
                numberMars -= 50;
                numberJupiter -= 50;
                numberSaturnShip++;
                // zmiana w label ilości surowców
                labelPeople.Text = numberPeople.ToString();
                labelIron.Text = numberIron.ToString();
                labelMars.Text = numberMars.ToString();
                labelSaturn.Text = numberSaturn.ToString();
                labelSaturnShip.Text = numberSaturnShip.ToString();
                // dodatek kolorystyczny aby było wiadome które przyciki można użyć
                if (numberPeople < 10 && numberIron < 100 && numberMars < 50 && numberJupiter < 50)
                    buttonSaturn.BackColor = Color.Red;

            }
            if (numberSaturnShip == 1)
            {
                timerSaturn.Start();
            }
            if (numberSaturnShip > 0)
            {
                timerSaturn.Interval = 100 / numberSaturnShip * 10;
            }
            
        }
        /// <summary>
        /// timer do czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            // bazowa czynność timera
            numberTime++;
            // zamiana sekund na minuty
            if (numberTime % 60 == 0)
            {
                numberTime -= 60;
                numberTimeMin++;
                labelTimeMin.Text = numberTimeMin.ToString();
                labelMin.Text = "min";
            }
            labelTime.Text = numberTime.ToString(); 
            // wydarzenie które się zdaży po minucie gry
            if(numberTimeMin == 1 && numberTime == 0)
            {
               // zmiana koloru label i wyświetlenie napisu o wydarzeniu
                labelOne.BackColor = Color.Red;
                labelOne.Text = "Now is time when people are protest. ";
                labelOneNext.BackColor = Color.Red;
                labelOneNext.Text = "If u have more than 30 people, they are escaped";
                // bazowe działanie wydarzenia
                if (numberPeople >= 30)
                    numberPeople -= 30;
            }
            // dzieki temu zniknie nam tekst pierwszego wydarzenia
            if(numberTimeMin == 1 && numberTime == 15)
            {
                labelOne.Text = "";
                labelOneNext.Text = "";
            }
            // wydarzenie które się zdaży po drugiej minucie gry
            if (numberTimeMin == 2 && numberTime == 0)
            {
                // zmiana koloru label i wyświetlenie napisu o wydarzeniu
                labelTwo.BackColor = Color.Green;
                labelTwo.Text = "Wow you invent new technology on Mars ";
                labelTwoNext.BackColor = Color.Green;
                labelTwoNext.Text = "Now you got 500 of this raw material";
                // bazowe działanie wydarzenia
                numberMars += 500;
            }
            // dzieki temu zniknie nam tekst drugiego wydarzenia
            if(numberTimeMin == 2 && numberTime == 15)
            {
                labelTwo.Text = "";
                labelTwoNext.Text = "";
            }
            // wydarzenie które się zdaży po trzeciej minucie gry
            if (numberTimeMin == 3 && numberTime == 0)
            {
                // zmiana koloru label i wyświetlenie napisu o wydarzeniu
                labelTwo.BackColor = Color.Red;
                labelTwo.Text = "Aliens attacked your Saturnship's";
                labelTwoNext.BackColor = Color.Red;
                labelTwoNext.Text = " and stole your saturn";
                // bazowe działanie wydarzenia
                numberSaturn = 0;
                numberSaturnShip = 0;
            }
            // dzięki temu zniknie nam tekst trzeciego wydarzenia
            if (numberTimeMin == 3 && numberTime == 15)
            {
                labelTwo.Text = "";
                labelTwoNext.Text = "";
            }
        }
        /// <summary>
        /// przycisk do tworzenia Portalu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPortal_Click(object sender, EventArgs e)
        {
            if (numberPeople >= 100 && numberIron >= 100 && numberMars >= 100 && numberJupiter >= 100 && numberUranus >= 100 && numberSaturn >= 100)
            {
                // zatrzymanie timerów
                timerTime.Stop();
                timerIron.Stop();
                timerMars.Stop();
                timerJupiter.Stop();
                timerSaturn.Stop();
                timerUranus.Stop();
                // zmiana na fajny kolorek i dodanie label kończącego gre
                labelEnd.BackColor = Color.Gold;
                labelEnd.Text = "Congratulation. You end the game in:" ;
                labelEndNext.BackColor = Color.Gold;
                labelEndNext.Text = numberTimeMin + " min " + numberTime + " sec";
            }

        }

    }
}
 