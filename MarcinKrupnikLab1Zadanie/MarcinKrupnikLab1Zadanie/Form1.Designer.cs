namespace MarcinKrupnikLab1Zadanie
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonPeople = new System.Windows.Forms.Button();
            this.labelPeople = new System.Windows.Forms.Label();
            this.buttonMiner = new System.Windows.Forms.Button();
            this.labelMiner = new System.Windows.Forms.Label();
            this.timerIron = new System.Windows.Forms.Timer(this.components);
            this.labelIron = new System.Windows.Forms.Label();
            this.buttonMars = new System.Windows.Forms.Button();
            this.labelMarsShip = new System.Windows.Forms.Label();
            this.timerMars = new System.Windows.Forms.Timer(this.components);
            this.labelMars = new System.Windows.Forms.Label();
            this.labelInfoMiners = new System.Windows.Forms.Label();
            this.labelInfoIron = new System.Windows.Forms.Label();
            this.labelInfoMarsShip = new System.Windows.Forms.Label();
            this.labelInfoMars = new System.Windows.Forms.Label();
            this.buttonJupiter = new System.Windows.Forms.Button();
            this.labelJupiterShip = new System.Windows.Forms.Label();
            this.labelJupiter = new System.Windows.Forms.Label();
            this.timerJupiter = new System.Windows.Forms.Timer(this.components);
            this.labelInfoJupiterShip = new System.Windows.Forms.Label();
            this.labelInfoJupiter = new System.Windows.Forms.Label();
            this.buttonSaturn = new System.Windows.Forms.Button();
            this.labelSaturnShip = new System.Windows.Forms.Label();
            this.labelSaturn = new System.Windows.Forms.Label();
            this.timerSaturn = new System.Windows.Forms.Timer(this.components);
            this.labelInfoSaturnShip = new System.Windows.Forms.Label();
            this.labelInfoSaturn = new System.Windows.Forms.Label();
            this.buttonUranus = new System.Windows.Forms.Button();
            this.timerUranus = new System.Windows.Forms.Timer(this.components);
            this.labelUranusShip = new System.Windows.Forms.Label();
            this.labelUranus = new System.Windows.Forms.Label();
            this.labelInfoUranusShip = new System.Windows.Forms.Label();
            this.labelInfoUranus = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTimeMin = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeInfo = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelCostMiner = new System.Windows.Forms.Label();
            this.labelCostMarsShip = new System.Windows.Forms.Label();
            this.labelCostJupitership = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPortal = new System.Windows.Forms.Button();
            this.labelPortal = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.labelOneNext = new System.Windows.Forms.Label();
            this.labelTwoNext = new System.Windows.Forms.Label();
            this.labelThreeNext = new System.Windows.Forms.Label();
            this.labelEndNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPeople
            // 
            this.buttonPeople.Location = new System.Drawing.Point(86, 84);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(75, 23);
            this.buttonPeople.TabIndex = 0;
            this.buttonPeople.Text = "People";
            this.buttonPeople.UseVisualStyleBackColor = true;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Location = new System.Drawing.Point(118, 117);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(13, 13);
            this.labelPeople.TabIndex = 1;
            this.labelPeople.Text = "0";
            // 
            // buttonMiner
            // 
            this.buttonMiner.Location = new System.Drawing.Point(329, 12);
            this.buttonMiner.Name = "buttonMiner";
            this.buttonMiner.Size = new System.Drawing.Size(92, 23);
            this.buttonMiner.TabIndex = 2;
            this.buttonMiner.Text = "Buy miners";
            this.buttonMiner.UseVisualStyleBackColor = true;
            this.buttonMiner.Click += new System.EventHandler(this.buttonMiner_Click);
            // 
            // labelMiner
            // 
            this.labelMiner.AutoSize = true;
            this.labelMiner.Location = new System.Drawing.Point(498, 38);
            this.labelMiner.Name = "labelMiner";
            this.labelMiner.Size = new System.Drawing.Size(13, 13);
            this.labelMiner.TabIndex = 3;
            this.labelMiner.Text = "0";
            // 
            // timerIron
            // 
            this.timerIron.Tick += new System.EventHandler(this.timerIron_Tick);
            // 
            // labelIron
            // 
            this.labelIron.AutoSize = true;
            this.labelIron.Location = new System.Drawing.Point(645, 38);
            this.labelIron.Name = "labelIron";
            this.labelIron.Size = new System.Drawing.Size(13, 13);
            this.labelIron.TabIndex = 5;
            this.labelIron.Text = "0";
            // 
            // buttonMars
            // 
            this.buttonMars.Location = new System.Drawing.Point(329, 66);
            this.buttonMars.Name = "buttonMars";
            this.buttonMars.Size = new System.Drawing.Size(92, 23);
            this.buttonMars.TabIndex = 6;
            this.buttonMars.Text = "Buy MarsShip";
            this.buttonMars.UseVisualStyleBackColor = true;
            this.buttonMars.Click += new System.EventHandler(this.buttonMars_Click);
            // 
            // labelMarsShip
            // 
            this.labelMarsShip.AutoSize = true;
            this.labelMarsShip.Location = new System.Drawing.Point(498, 94);
            this.labelMarsShip.Name = "labelMarsShip";
            this.labelMarsShip.Size = new System.Drawing.Size(13, 13);
            this.labelMarsShip.TabIndex = 7;
            this.labelMarsShip.Text = "0";
            // 
            // timerMars
            // 
            this.timerMars.Tick += new System.EventHandler(this.timerMars_Tick);
            // 
            // labelMars
            // 
            this.labelMars.AutoSize = true;
            this.labelMars.Location = new System.Drawing.Point(645, 94);
            this.labelMars.Name = "labelMars";
            this.labelMars.Size = new System.Drawing.Size(13, 13);
            this.labelMars.TabIndex = 8;
            this.labelMars.Text = "0";
            // 
            // labelInfoMiners
            // 
            this.labelInfoMiners.AutoSize = true;
            this.labelInfoMiners.Location = new System.Drawing.Point(450, 17);
            this.labelInfoMiners.Name = "labelInfoMiners";
            this.labelInfoMiners.Size = new System.Drawing.Size(88, 13);
            this.labelInfoMiners.TabIndex = 9;
            this.labelInfoMiners.Text = "Amount of miners";
            // 
            // labelInfoIron
            // 
            this.labelInfoIron.AutoSize = true;
            this.labelInfoIron.Location = new System.Drawing.Point(592, 17);
            this.labelInfoIron.Name = "labelInfoIron";
            this.labelInfoIron.Size = new System.Drawing.Size(75, 13);
            this.labelInfoIron.TabIndex = 10;
            this.labelInfoIron.Text = "Amount of iron";
            // 
            // labelInfoMarsShip
            // 
            this.labelInfoMarsShip.AutoSize = true;
            this.labelInfoMarsShip.Location = new System.Drawing.Point(450, 76);
            this.labelInfoMarsShip.Name = "labelInfoMarsShip";
            this.labelInfoMarsShip.Size = new System.Drawing.Size(109, 13);
            this.labelInfoMarsShip.TabIndex = 11;
            this.labelInfoMarsShip.Text = "Amount of MarsShip\'s";
            // 
            // labelInfoMars
            // 
            this.labelInfoMars.AutoSize = true;
            this.labelInfoMars.Location = new System.Drawing.Point(592, 76);
            this.labelInfoMars.Name = "labelInfoMars";
            this.labelInfoMars.Size = new System.Drawing.Size(81, 13);
            this.labelInfoMars.TabIndex = 12;
            this.labelInfoMars.Text = "Amount of Mars";
            // 
            // buttonJupiter
            // 
            this.buttonJupiter.Location = new System.Drawing.Point(329, 117);
            this.buttonJupiter.Name = "buttonJupiter";
            this.buttonJupiter.Size = new System.Drawing.Size(92, 23);
            this.buttonJupiter.TabIndex = 13;
            this.buttonJupiter.Text = "Buy JupiterShip";
            this.buttonJupiter.UseVisualStyleBackColor = true;
            this.buttonJupiter.Click += new System.EventHandler(this.buttonJupiter_Click);
            // 
            // labelJupiterShip
            // 
            this.labelJupiterShip.AutoSize = true;
            this.labelJupiterShip.Location = new System.Drawing.Point(498, 143);
            this.labelJupiterShip.Name = "labelJupiterShip";
            this.labelJupiterShip.Size = new System.Drawing.Size(13, 13);
            this.labelJupiterShip.TabIndex = 14;
            this.labelJupiterShip.Text = "0";
            // 
            // labelJupiter
            // 
            this.labelJupiter.AutoSize = true;
            this.labelJupiter.Location = new System.Drawing.Point(645, 143);
            this.labelJupiter.Name = "labelJupiter";
            this.labelJupiter.Size = new System.Drawing.Size(13, 13);
            this.labelJupiter.TabIndex = 15;
            this.labelJupiter.Text = "0";
            // 
            // timerJupiter
            // 
            this.timerJupiter.Tick += new System.EventHandler(this.timerJupiter_Tick);
            // 
            // labelInfoJupiterShip
            // 
            this.labelInfoJupiterShip.AutoSize = true;
            this.labelInfoJupiterShip.Location = new System.Drawing.Point(450, 120);
            this.labelInfoJupiterShip.Name = "labelInfoJupiterShip";
            this.labelInfoJupiterShip.Size = new System.Drawing.Size(117, 13);
            this.labelInfoJupiterShip.TabIndex = 16;
            this.labelInfoJupiterShip.Text = "Amount of JupiterShip\'s";
            // 
            // labelInfoJupiter
            // 
            this.labelInfoJupiter.AutoSize = true;
            this.labelInfoJupiter.Location = new System.Drawing.Point(592, 120);
            this.labelInfoJupiter.Name = "labelInfoJupiter";
            this.labelInfoJupiter.Size = new System.Drawing.Size(89, 13);
            this.labelInfoJupiter.TabIndex = 17;
            this.labelInfoJupiter.Text = "Amount of Jupiter";
            // 
            // buttonSaturn
            // 
            this.buttonSaturn.Location = new System.Drawing.Point(329, 164);
            this.buttonSaturn.Name = "buttonSaturn";
            this.buttonSaturn.Size = new System.Drawing.Size(92, 23);
            this.buttonSaturn.TabIndex = 18;
            this.buttonSaturn.Text = "Buy SaturnShip";
            this.buttonSaturn.UseVisualStyleBackColor = true;
            this.buttonSaturn.Click += new System.EventHandler(this.buttonSaturn_Click);
            // 
            // labelSaturnShip
            // 
            this.labelSaturnShip.AutoSize = true;
            this.labelSaturnShip.Location = new System.Drawing.Point(498, 190);
            this.labelSaturnShip.Name = "labelSaturnShip";
            this.labelSaturnShip.Size = new System.Drawing.Size(13, 13);
            this.labelSaturnShip.TabIndex = 19;
            this.labelSaturnShip.Text = "0";
            // 
            // labelSaturn
            // 
            this.labelSaturn.AutoSize = true;
            this.labelSaturn.Location = new System.Drawing.Point(645, 190);
            this.labelSaturn.Name = "labelSaturn";
            this.labelSaturn.Size = new System.Drawing.Size(13, 13);
            this.labelSaturn.TabIndex = 20;
            this.labelSaturn.Text = "0";
            // 
            // timerSaturn
            // 
            this.timerSaturn.Tick += new System.EventHandler(this.timerSaturn_Tick);
            // 
            // labelInfoSaturnShip
            // 
            this.labelInfoSaturnShip.AutoSize = true;
            this.labelInfoSaturnShip.Location = new System.Drawing.Point(450, 169);
            this.labelInfoSaturnShip.Name = "labelInfoSaturnShip";
            this.labelInfoSaturnShip.Size = new System.Drawing.Size(117, 13);
            this.labelInfoSaturnShip.TabIndex = 21;
            this.labelInfoSaturnShip.Text = "Amount of SaturnShip\'s";
            // 
            // labelInfoSaturn
            // 
            this.labelInfoSaturn.AutoSize = true;
            this.labelInfoSaturn.Location = new System.Drawing.Point(592, 169);
            this.labelInfoSaturn.Name = "labelInfoSaturn";
            this.labelInfoSaturn.Size = new System.Drawing.Size(89, 13);
            this.labelInfoSaturn.TabIndex = 22;
            this.labelInfoSaturn.Text = "Amount of Saturn";
            // 
            // buttonUranus
            // 
            this.buttonUranus.Location = new System.Drawing.Point(329, 214);
            this.buttonUranus.Name = "buttonUranus";
            this.buttonUranus.Size = new System.Drawing.Size(92, 23);
            this.buttonUranus.TabIndex = 23;
            this.buttonUranus.Text = "Buy UranusShip";
            this.buttonUranus.UseVisualStyleBackColor = true;
            this.buttonUranus.Click += new System.EventHandler(this.buttonUranus_Click);
            // 
            // timerUranus
            // 
            this.timerUranus.Tick += new System.EventHandler(this.timerUranus_Tick);
            // 
            // labelUranusShip
            // 
            this.labelUranusShip.AutoSize = true;
            this.labelUranusShip.Location = new System.Drawing.Point(498, 240);
            this.labelUranusShip.Name = "labelUranusShip";
            this.labelUranusShip.Size = new System.Drawing.Size(13, 13);
            this.labelUranusShip.TabIndex = 24;
            this.labelUranusShip.Text = "0";
            // 
            // labelUranus
            // 
            this.labelUranus.AutoSize = true;
            this.labelUranus.Location = new System.Drawing.Point(645, 240);
            this.labelUranus.Name = "labelUranus";
            this.labelUranus.Size = new System.Drawing.Size(13, 13);
            this.labelUranus.TabIndex = 25;
            this.labelUranus.Text = "0";
            // 
            // labelInfoUranusShip
            // 
            this.labelInfoUranusShip.AutoSize = true;
            this.labelInfoUranusShip.Location = new System.Drawing.Point(450, 219);
            this.labelInfoUranusShip.Name = "labelInfoUranusShip";
            this.labelInfoUranusShip.Size = new System.Drawing.Size(120, 13);
            this.labelInfoUranusShip.TabIndex = 26;
            this.labelInfoUranusShip.Text = "Amount of UranusShip\'s";
            // 
            // labelInfoUranus
            // 
            this.labelInfoUranus.AutoSize = true;
            this.labelInfoUranus.Location = new System.Drawing.Point(593, 219);
            this.labelInfoUranus.Name = "labelInfoUranus";
            this.labelInfoUranus.Size = new System.Drawing.Size(120, 13);
            this.labelInfoUranus.TabIndex = 27;
            this.labelInfoUranus.Text = "Amount of UranusShip\'s";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelTimeMin
            // 
            this.labelTimeMin.AutoSize = true;
            this.labelTimeMin.Location = new System.Drawing.Point(100, 18);
            this.labelTimeMin.Name = "labelTimeMin";
            this.labelTimeMin.Size = new System.Drawing.Size(0, 13);
            this.labelTimeMin.TabIndex = 28;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(163, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 29;
            this.labelTime.Text = "0";
            // 
            // labelTimeInfo
            // 
            this.labelTimeInfo.AutoSize = true;
            this.labelTimeInfo.Location = new System.Drawing.Point(12, 18);
            this.labelTimeInfo.Name = "labelTimeInfo";
            this.labelTimeInfo.Size = new System.Drawing.Size(58, 13);
            this.labelTimeInfo.TabIndex = 30;
            this.labelTimeInfo.Text = "Your Time:";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(182, 18);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(24, 13);
            this.labelSec.TabIndex = 31;
            this.labelSec.Text = "sec";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(131, 18);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 13);
            this.labelMin.TabIndex = 32;
            // 
            // labelCostMiner
            // 
            this.labelCostMiner.AutoSize = true;
            this.labelCostMiner.Location = new System.Drawing.Point(339, 38);
            this.labelCostMiner.Name = "labelCostMiner";
            this.labelCostMiner.Size = new System.Drawing.Size(82, 13);
            this.labelCostMiner.TabIndex = 33;
            this.labelCostMiner.Text = "Cost: 10 People";
            // 
            // labelCostMarsShip
            // 
            this.labelCostMarsShip.AutoSize = true;
            this.labelCostMarsShip.Location = new System.Drawing.Point(300, 94);
            this.labelCostMarsShip.Name = "labelCostMarsShip";
            this.labelCostMarsShip.Size = new System.Drawing.Size(121, 13);
            this.labelCostMarsShip.TabIndex = 34;
            this.labelCostMarsShip.Text = "Cost: 30 People, 30 Iron";
            // 
            // labelCostJupitership
            // 
            this.labelCostJupitership.AutoSize = true;
            this.labelCostJupitership.Location = new System.Drawing.Point(250, 143);
            this.labelCostJupitership.Name = "labelCostJupitership";
            this.labelCostJupitership.Size = new System.Drawing.Size(171, 13);
            this.labelCostJupitership.TabIndex = 35;
            this.labelCostJupitership.Text = "Cost: 20 People, 100 Iron, 50 Mars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cost: 10 People,100 Iron, 50 Mars, 50 Jupiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cost: 100 People, 30 Mars, 10 Jupiter, 90 Saturn";
            // 
            // buttonPortal
            // 
            this.buttonPortal.Location = new System.Drawing.Point(56, 185);
            this.buttonPortal.Name = "buttonPortal";
            this.buttonPortal.Size = new System.Drawing.Size(75, 23);
            this.buttonPortal.TabIndex = 38;
            this.buttonPortal.Text = "Buy Portal";
            this.buttonPortal.UseVisualStyleBackColor = true;
            this.buttonPortal.Click += new System.EventHandler(this.buttonPortal_Click);
            // 
            // labelPortal
            // 
            this.labelPortal.AutoSize = true;
            this.labelPortal.Location = new System.Drawing.Point(54, 219);
            this.labelPortal.Name = "labelPortal";
            this.labelPortal.Size = new System.Drawing.Size(77, 13);
            this.labelPortal.TabIndex = 39;
            this.labelPortal.Text = "Cost: 100 of all";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(716, 18);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(179, 65);
            this.labelDestination.TabIndex = 40;
            this.labelDestination.Text = "Destination:\r\nOne you need to do is make a Portal\r\n to get out from this game. \r\n" +
    "( in best time)\r\nGet luck!!!\r\n";
            this.labelDestination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(716, 168);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(0, 13);
            this.labelEnd.TabIndex = 41;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(713, 92);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(0, 13);
            this.labelOne.TabIndex = 42;
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(687, 127);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(0, 13);
            this.labelTwo.TabIndex = 43;
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Location = new System.Drawing.Point(707, 89);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(0, 13);
            this.labelThree.TabIndex = 44;
            // 
            // labelOneNext
            // 
            this.labelOneNext.AutoSize = true;
            this.labelOneNext.Location = new System.Drawing.Point(681, 107);
            this.labelOneNext.Name = "labelOneNext";
            this.labelOneNext.Size = new System.Drawing.Size(0, 13);
            this.labelOneNext.TabIndex = 45;
            // 
            // labelTwoNext
            // 
            this.labelTwoNext.AutoSize = true;
            this.labelTwoNext.Location = new System.Drawing.Point(716, 142);
            this.labelTwoNext.Name = "labelTwoNext";
            this.labelTwoNext.Size = new System.Drawing.Size(0, 13);
            this.labelTwoNext.TabIndex = 46;
            // 
            // labelThreeNext
            // 
            this.labelThreeNext.AutoSize = true;
            this.labelThreeNext.Location = new System.Drawing.Point(707, 101);
            this.labelThreeNext.Name = "labelThreeNext";
            this.labelThreeNext.Size = new System.Drawing.Size(0, 13);
            this.labelThreeNext.TabIndex = 47;
            // 
            // labelEndNext
            // 
            this.labelEndNext.AutoSize = true;
            this.labelEndNext.Location = new System.Drawing.Point(716, 190);
            this.labelEndNext.Name = "labelEndNext";
            this.labelEndNext.Size = new System.Drawing.Size(0, 13);
            this.labelEndNext.TabIndex = 48;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarcinKrupnikLab1Zadanie.Properties.Resources.MyImage;
            this.ClientSize = new System.Drawing.Size(907, 262);
            this.Controls.Add(this.labelEndNext);
            this.Controls.Add(this.labelThreeNext);
            this.Controls.Add(this.labelTwoNext);
            this.Controls.Add(this.labelOneNext);
            this.Controls.Add(this.labelThree);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelPortal);
            this.Controls.Add(this.buttonPortal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCostJupitership);
            this.Controls.Add(this.labelCostMarsShip);
            this.Controls.Add(this.labelCostMiner);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelTimeInfo);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTimeMin);
            this.Controls.Add(this.labelInfoUranus);
            this.Controls.Add(this.labelInfoUranusShip);
            this.Controls.Add(this.labelUranus);
            this.Controls.Add(this.labelUranusShip);
            this.Controls.Add(this.buttonUranus);
            this.Controls.Add(this.labelInfoSaturn);
            this.Controls.Add(this.labelInfoSaturnShip);
            this.Controls.Add(this.labelSaturn);
            this.Controls.Add(this.labelSaturnShip);
            this.Controls.Add(this.buttonSaturn);
            this.Controls.Add(this.labelInfoJupiter);
            this.Controls.Add(this.labelInfoJupiterShip);
            this.Controls.Add(this.labelJupiter);
            this.Controls.Add(this.labelJupiterShip);
            this.Controls.Add(this.buttonJupiter);
            this.Controls.Add(this.labelInfoMars);
            this.Controls.Add(this.labelInfoMarsShip);
            this.Controls.Add(this.labelInfoIron);
            this.Controls.Add(this.labelInfoMiners);
            this.Controls.Add(this.labelMars);
            this.Controls.Add(this.labelMarsShip);
            this.Controls.Add(this.buttonMars);
            this.Controls.Add(this.labelIron);
            this.Controls.Add(this.labelMiner);
            this.Controls.Add(this.buttonMiner);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.buttonPeople);
            this.Name = "FormMain";
            this.Text = "Click Into The Space  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPeople;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Button buttonMiner;
        private System.Windows.Forms.Label labelMiner;
        private System.Windows.Forms.Timer timerIron;
        private System.Windows.Forms.Label labelIron;
        private System.Windows.Forms.Button buttonMars;
        private System.Windows.Forms.Label labelMarsShip;
        private System.Windows.Forms.Timer timerMars;
        private System.Windows.Forms.Label labelMars;
        private System.Windows.Forms.Label labelInfoMiners;
        private System.Windows.Forms.Label labelInfoIron;
        private System.Windows.Forms.Label labelInfoMarsShip;
        private System.Windows.Forms.Label labelInfoMars;
        private System.Windows.Forms.Button buttonJupiter;
        private System.Windows.Forms.Label labelJupiterShip;
        private System.Windows.Forms.Label labelJupiter;
        private System.Windows.Forms.Timer timerJupiter;
        private System.Windows.Forms.Label labelInfoJupiterShip;
        private System.Windows.Forms.Label labelInfoJupiter;
        private System.Windows.Forms.Button buttonSaturn;
        private System.Windows.Forms.Label labelSaturnShip;
        private System.Windows.Forms.Label labelSaturn;
        private System.Windows.Forms.Timer timerSaturn;
        private System.Windows.Forms.Label labelInfoSaturnShip;
        private System.Windows.Forms.Label labelInfoSaturn;
        private System.Windows.Forms.Button buttonUranus;
        private System.Windows.Forms.Timer timerUranus;
        private System.Windows.Forms.Label labelUranusShip;
        private System.Windows.Forms.Label labelUranus;
        private System.Windows.Forms.Label labelInfoUranusShip;
        private System.Windows.Forms.Label labelInfoUranus;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelTimeMin;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeInfo;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelCostMiner;
        private System.Windows.Forms.Label labelCostMarsShip;
        private System.Windows.Forms.Label labelCostJupitership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPortal;
        private System.Windows.Forms.Label labelPortal;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.Label labelOneNext;
        private System.Windows.Forms.Label labelTwoNext;
        private System.Windows.Forms.Label labelThreeNext;
        private System.Windows.Forms.Label labelEndNext;
    }
}

