namespace MarcinKrupnikLab2Zadanie
{
    partial class LeaveTheDungeon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveTheDungeon));
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelHp = new System.Windows.Forms.Label();
            this.labelAtc = new System.Windows.Forms.Label();
            this.labelAtcInfo = new System.Windows.Forms.Label();
            this.labelHpInfo = new System.Windows.Forms.Label();
            this.labelArm = new System.Windows.Forms.Label();
            this.labelArmInfo = new System.Windows.Forms.Label();
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonTimerOn = new System.Windows.Forms.RadioButton();
            this.radioButtonTimerOff = new System.Windows.Forms.RadioButton();
            this.buttonDrawEnemy = new System.Windows.Forms.Button();
            this.labelArmEnemyInfo = new System.Windows.Forms.Label();
            this.labelHpEnemyInfo = new System.Windows.Forms.Label();
            this.labelAtcEnemyInfo = new System.Windows.Forms.Label();
            this.labelArmEnemy = new System.Windows.Forms.Label();
            this.labelAtcEnemy = new System.Windows.Forms.Label();
            this.labelHpEnemy = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelRangeEnemyInfo = new System.Windows.Forms.Label();
            this.labelRangeEnemy = new System.Windows.Forms.Label();
            this.labelStrengthEnemyInfo = new System.Windows.Forms.Label();
            this.labelAtcWEnemyInfo = new System.Windows.Forms.Label();
            this.labelAtcWEnemy = new System.Windows.Forms.Label();
            this.labelStrengthEnemy = new System.Windows.Forms.Label();
            this.buttonDrawWeaponEnemy = new System.Windows.Forms.Button();
            this.labelRangeInfo = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelStrengthInfo = new System.Windows.Forms.Label();
            this.labelAtcWInfo = new System.Windows.Forms.Label();
            this.labelAtcW = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.buttonDrawWeapon = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelHpPInfo = new System.Windows.Forms.Label();
            this.labelManaInfo = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelHpP = new System.Windows.Forms.Label();
            this.buttonDrawPotion = new System.Windows.Forms.Button();
            this.labelPowerEnemyInfo = new System.Windows.Forms.Label();
            this.labelPowerEnemy = new System.Windows.Forms.Label();
            this.labelHpPEnemyInfo = new System.Windows.Forms.Label();
            this.labelManaEnemyInfo = new System.Windows.Forms.Label();
            this.labelManaEnemy = new System.Windows.Forms.Label();
            this.labelHpPEnemy = new System.Windows.Forms.Label();
            this.buttonDrawPotionEnemy = new System.Windows.Forms.Button();
            this.labelArmMInfo = new System.Windows.Forms.Label();
            this.labelArmM = new System.Windows.Forms.Label();
            this.labelHpMInfo = new System.Windows.Forms.Label();
            this.labelAtcMInfo = new System.Windows.Forms.Label();
            this.labelAtcM = new System.Windows.Forms.Label();
            this.labelHpM = new System.Windows.Forms.Label();
            this.buttonDrawMonster = new System.Windows.Forms.Button();
            this.labelArmMEnemyInfo = new System.Windows.Forms.Label();
            this.labelArmMEnemy = new System.Windows.Forms.Label();
            this.labelHpMEnemyInfo = new System.Windows.Forms.Label();
            this.labelAtcMEnemyInfo = new System.Windows.Forms.Label();
            this.labelAtcMEnemy = new System.Windows.Forms.Label();
            this.labelHpMEnemy = new System.Windows.Forms.Label();
            this.buttonDrawMonsterEnemy = new System.Windows.Forms.Button();
            this.labelDivEnemyInfo = new System.Windows.Forms.Label();
            this.labelDivEnemy = new System.Windows.Forms.Label();
            this.labelRigEnemyInfo = new System.Windows.Forms.Label();
            this.labelProEnemyInfo = new System.Windows.Forms.Label();
            this.labelProEnemy = new System.Windows.Forms.Label();
            this.labelRigEnemy = new System.Windows.Forms.Label();
            this.buttonDrawBlessingEnemy = new System.Windows.Forms.Button();
            this.labelDivInfo = new System.Windows.Forms.Label();
            this.labelDiv = new System.Windows.Forms.Label();
            this.labelRigInfo = new System.Windows.Forms.Label();
            this.labelProInfo = new System.Windows.Forms.Label();
            this.labelPro = new System.Windows.Forms.Label();
            this.labelRig = new System.Windows.Forms.Label();
            this.buttonDrawBlessing = new System.Windows.Forms.Button();
            this.labelTimeMin = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreEnemy = new System.Windows.Forms.Label();
            this.labelScoreInfo = new System.Windows.Forms.Label();
            this.labelScoreEnemyInfo = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackColor = System.Drawing.Color.Purple;
            this.buttonDraw.Location = new System.Drawing.Point(158, 189);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(118, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw Champion Card";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(227, 215);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(13, 13);
            this.labelHp.TabIndex = 1;
            this.labelHp.Text = "0";
            // 
            // labelAtc
            // 
            this.labelAtc.AutoSize = true;
            this.labelAtc.Location = new System.Drawing.Point(227, 228);
            this.labelAtc.Name = "labelAtc";
            this.labelAtc.Size = new System.Drawing.Size(13, 13);
            this.labelAtc.TabIndex = 2;
            this.labelAtc.Text = "0";
            // 
            // labelAtcInfo
            // 
            this.labelAtcInfo.AutoSize = true;
            this.labelAtcInfo.Location = new System.Drawing.Point(186, 228);
            this.labelAtcInfo.Name = "labelAtcInfo";
            this.labelAtcInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcInfo.TabIndex = 3;
            this.labelAtcInfo.Text = "Atack";
            // 
            // labelHpInfo
            // 
            this.labelHpInfo.AutoSize = true;
            this.labelHpInfo.Location = new System.Drawing.Point(186, 215);
            this.labelHpInfo.Name = "labelHpInfo";
            this.labelHpInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpInfo.TabIndex = 4;
            this.labelHpInfo.Text = "Hp";
            // 
            // labelArm
            // 
            this.labelArm.AutoSize = true;
            this.labelArm.Location = new System.Drawing.Point(227, 241);
            this.labelArm.Name = "labelArm";
            this.labelArm.Size = new System.Drawing.Size(13, 13);
            this.labelArm.TabIndex = 5;
            this.labelArm.Text = "0";
            // 
            // labelArmInfo
            // 
            this.labelArmInfo.AutoSize = true;
            this.labelArmInfo.Location = new System.Drawing.Point(186, 241);
            this.labelArmInfo.Name = "labelArmInfo";
            this.labelArmInfo.Size = new System.Drawing.Size(34, 13);
            this.labelArmInfo.TabIndex = 6;
            this.labelArmInfo.Text = "Armor";
            // 
            // timerEnd
            // 
            this.timerEnd.Tick += new System.EventHandler(this.timerEnd_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(802, 35);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(751, 35);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 13);
            this.labelMin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "sec";
            // 
            // radioButtonTimerOn
            // 
            this.radioButtonTimerOn.AutoSize = true;
            this.radioButtonTimerOn.Location = new System.Drawing.Point(779, 64);
            this.radioButtonTimerOn.Name = "radioButtonTimerOn";
            this.radioButtonTimerOn.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTimerOn.TabIndex = 12;
            this.radioButtonTimerOn.TabStop = true;
            this.radioButtonTimerOn.UseVisualStyleBackColor = true;
            this.radioButtonTimerOn.CheckedChanged += new System.EventHandler(this.radioButtonTimerOn_CheckedChanged);
            // 
            // radioButtonTimerOff
            // 
            this.radioButtonTimerOff.AutoSize = true;
            this.radioButtonTimerOff.Location = new System.Drawing.Point(824, 64);
            this.radioButtonTimerOff.Name = "radioButtonTimerOff";
            this.radioButtonTimerOff.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTimerOff.TabIndex = 13;
            this.radioButtonTimerOff.TabStop = true;
            this.radioButtonTimerOff.UseVisualStyleBackColor = true;
            this.radioButtonTimerOff.CheckedChanged += new System.EventHandler(this.radioButtonTimerOff_CheckedChanged);
            // 
            // buttonDrawEnemy
            // 
            this.buttonDrawEnemy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDrawEnemy.Location = new System.Drawing.Point(158, 302);
            this.buttonDrawEnemy.Name = "buttonDrawEnemy";
            this.buttonDrawEnemy.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawEnemy.TabIndex = 14;
            this.buttonDrawEnemy.Text = "Draw Champion Card";
            this.buttonDrawEnemy.UseVisualStyleBackColor = false;
            this.buttonDrawEnemy.Click += new System.EventHandler(this.buttonDrawEnemy_Click);
            // 
            // labelArmEnemyInfo
            // 
            this.labelArmEnemyInfo.AutoSize = true;
            this.labelArmEnemyInfo.Location = new System.Drawing.Point(185, 354);
            this.labelArmEnemyInfo.Name = "labelArmEnemyInfo";
            this.labelArmEnemyInfo.Size = new System.Drawing.Size(34, 13);
            this.labelArmEnemyInfo.TabIndex = 17;
            this.labelArmEnemyInfo.Text = "Armor";
            // 
            // labelHpEnemyInfo
            // 
            this.labelHpEnemyInfo.AutoSize = true;
            this.labelHpEnemyInfo.Location = new System.Drawing.Point(185, 328);
            this.labelHpEnemyInfo.Name = "labelHpEnemyInfo";
            this.labelHpEnemyInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpEnemyInfo.TabIndex = 16;
            this.labelHpEnemyInfo.Text = "Hp";
            // 
            // labelAtcEnemyInfo
            // 
            this.labelAtcEnemyInfo.AutoSize = true;
            this.labelAtcEnemyInfo.Location = new System.Drawing.Point(185, 341);
            this.labelAtcEnemyInfo.Name = "labelAtcEnemyInfo";
            this.labelAtcEnemyInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcEnemyInfo.TabIndex = 15;
            this.labelAtcEnemyInfo.Text = "Atack";
            // 
            // labelArmEnemy
            // 
            this.labelArmEnemy.AutoSize = true;
            this.labelArmEnemy.Location = new System.Drawing.Point(226, 354);
            this.labelArmEnemy.Name = "labelArmEnemy";
            this.labelArmEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelArmEnemy.TabIndex = 20;
            this.labelArmEnemy.Text = "0";
            // 
            // labelAtcEnemy
            // 
            this.labelAtcEnemy.AutoSize = true;
            this.labelAtcEnemy.Location = new System.Drawing.Point(226, 341);
            this.labelAtcEnemy.Name = "labelAtcEnemy";
            this.labelAtcEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelAtcEnemy.TabIndex = 19;
            this.labelAtcEnemy.Text = "0";
            // 
            // labelHpEnemy
            // 
            this.labelHpEnemy.AutoSize = true;
            this.labelHpEnemy.Location = new System.Drawing.Point(226, 328);
            this.labelHpEnemy.Name = "labelHpEnemy";
            this.labelHpEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelHpEnemy.TabIndex = 18;
            this.labelHpEnemy.Text = "0";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(761, 258);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 21;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelRangeEnemyInfo
            // 
            this.labelRangeEnemyInfo.AutoSize = true;
            this.labelRangeEnemyInfo.Location = new System.Drawing.Point(310, 354);
            this.labelRangeEnemyInfo.Name = "labelRangeEnemyInfo";
            this.labelRangeEnemyInfo.Size = new System.Drawing.Size(39, 13);
            this.labelRangeEnemyInfo.TabIndex = 28;
            this.labelRangeEnemyInfo.Text = "Range";
            // 
            // labelRangeEnemy
            // 
            this.labelRangeEnemy.AutoSize = true;
            this.labelRangeEnemy.Location = new System.Drawing.Point(351, 354);
            this.labelRangeEnemy.Name = "labelRangeEnemy";
            this.labelRangeEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelRangeEnemy.TabIndex = 27;
            this.labelRangeEnemy.Text = "0";
            // 
            // labelStrengthEnemyInfo
            // 
            this.labelStrengthEnemyInfo.AutoSize = true;
            this.labelStrengthEnemyInfo.Location = new System.Drawing.Point(302, 328);
            this.labelStrengthEnemyInfo.Name = "labelStrengthEnemyInfo";
            this.labelStrengthEnemyInfo.Size = new System.Drawing.Size(47, 13);
            this.labelStrengthEnemyInfo.TabIndex = 26;
            this.labelStrengthEnemyInfo.Text = "Strength";
            // 
            // labelAtcWEnemyInfo
            // 
            this.labelAtcWEnemyInfo.AutoSize = true;
            this.labelAtcWEnemyInfo.Location = new System.Drawing.Point(310, 341);
            this.labelAtcWEnemyInfo.Name = "labelAtcWEnemyInfo";
            this.labelAtcWEnemyInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcWEnemyInfo.TabIndex = 25;
            this.labelAtcWEnemyInfo.Text = "Atack";
            // 
            // labelAtcWEnemy
            // 
            this.labelAtcWEnemy.AutoSize = true;
            this.labelAtcWEnemy.Location = new System.Drawing.Point(351, 341);
            this.labelAtcWEnemy.Name = "labelAtcWEnemy";
            this.labelAtcWEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelAtcWEnemy.TabIndex = 24;
            this.labelAtcWEnemy.Text = "0";
            // 
            // labelStrengthEnemy
            // 
            this.labelStrengthEnemy.AutoSize = true;
            this.labelStrengthEnemy.Location = new System.Drawing.Point(351, 328);
            this.labelStrengthEnemy.Name = "labelStrengthEnemy";
            this.labelStrengthEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelStrengthEnemy.TabIndex = 23;
            this.labelStrengthEnemy.Text = "0";
            // 
            // buttonDrawWeaponEnemy
            // 
            this.buttonDrawWeaponEnemy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDrawWeaponEnemy.Location = new System.Drawing.Point(282, 302);
            this.buttonDrawWeaponEnemy.Name = "buttonDrawWeaponEnemy";
            this.buttonDrawWeaponEnemy.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawWeaponEnemy.TabIndex = 22;
            this.buttonDrawWeaponEnemy.Text = "Draw Weapon Card";
            this.buttonDrawWeaponEnemy.UseVisualStyleBackColor = false;
            this.buttonDrawWeaponEnemy.Click += new System.EventHandler(this.buttonDrawWeaponEnemy_Click);
            // 
            // labelRangeInfo
            // 
            this.labelRangeInfo.AutoSize = true;
            this.labelRangeInfo.Location = new System.Drawing.Point(310, 241);
            this.labelRangeInfo.Name = "labelRangeInfo";
            this.labelRangeInfo.Size = new System.Drawing.Size(39, 13);
            this.labelRangeInfo.TabIndex = 35;
            this.labelRangeInfo.Text = "Range";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(351, 241);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(13, 13);
            this.labelRange.TabIndex = 34;
            this.labelRange.Text = "0";
            // 
            // labelStrengthInfo
            // 
            this.labelStrengthInfo.AutoSize = true;
            this.labelStrengthInfo.Location = new System.Drawing.Point(297, 215);
            this.labelStrengthInfo.Name = "labelStrengthInfo";
            this.labelStrengthInfo.Size = new System.Drawing.Size(47, 13);
            this.labelStrengthInfo.TabIndex = 33;
            this.labelStrengthInfo.Text = "Strength";
            // 
            // labelAtcWInfo
            // 
            this.labelAtcWInfo.AutoSize = true;
            this.labelAtcWInfo.Location = new System.Drawing.Point(310, 228);
            this.labelAtcWInfo.Name = "labelAtcWInfo";
            this.labelAtcWInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcWInfo.TabIndex = 32;
            this.labelAtcWInfo.Text = "Atack";
            // 
            // labelAtcW
            // 
            this.labelAtcW.AutoSize = true;
            this.labelAtcW.Location = new System.Drawing.Point(351, 228);
            this.labelAtcW.Name = "labelAtcW";
            this.labelAtcW.Size = new System.Drawing.Size(13, 13);
            this.labelAtcW.TabIndex = 31;
            this.labelAtcW.Text = "0";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(351, 215);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(13, 13);
            this.labelStrength.TabIndex = 30;
            this.labelStrength.Text = "0";
            // 
            // buttonDrawWeapon
            // 
            this.buttonDrawWeapon.BackColor = System.Drawing.Color.Purple;
            this.buttonDrawWeapon.Location = new System.Drawing.Point(282, 189);
            this.buttonDrawWeapon.Name = "buttonDrawWeapon";
            this.buttonDrawWeapon.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawWeapon.TabIndex = 29;
            this.buttonDrawWeapon.Text = "Draw Weapon Card";
            this.buttonDrawWeapon.UseVisualStyleBackColor = false;
            this.buttonDrawWeapon.Click += new System.EventHandler(this.buttonDrawWeapon_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Power";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(475, 241);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(13, 13);
            this.labelPower.TabIndex = 41;
            this.labelPower.Text = "0";
            // 
            // labelHpPInfo
            // 
            this.labelHpPInfo.AutoSize = true;
            this.labelHpPInfo.Location = new System.Drawing.Point(434, 215);
            this.labelHpPInfo.Name = "labelHpPInfo";
            this.labelHpPInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpPInfo.TabIndex = 40;
            this.labelHpPInfo.Text = "Hp";
            // 
            // labelManaInfo
            // 
            this.labelManaInfo.AutoSize = true;
            this.labelManaInfo.Location = new System.Drawing.Point(434, 228);
            this.labelManaInfo.Name = "labelManaInfo";
            this.labelManaInfo.Size = new System.Drawing.Size(34, 13);
            this.labelManaInfo.TabIndex = 39;
            this.labelManaInfo.Text = "Mana";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(475, 228);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(13, 13);
            this.labelMana.TabIndex = 38;
            this.labelMana.Text = "0";
            // 
            // labelHpP
            // 
            this.labelHpP.AutoSize = true;
            this.labelHpP.Location = new System.Drawing.Point(475, 215);
            this.labelHpP.Name = "labelHpP";
            this.labelHpP.Size = new System.Drawing.Size(13, 13);
            this.labelHpP.TabIndex = 37;
            this.labelHpP.Text = "0";
            // 
            // buttonDrawPotion
            // 
            this.buttonDrawPotion.BackColor = System.Drawing.Color.Purple;
            this.buttonDrawPotion.Location = new System.Drawing.Point(406, 189);
            this.buttonDrawPotion.Name = "buttonDrawPotion";
            this.buttonDrawPotion.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawPotion.TabIndex = 36;
            this.buttonDrawPotion.Text = "Draw Potion Card";
            this.buttonDrawPotion.UseVisualStyleBackColor = false;
            this.buttonDrawPotion.Click += new System.EventHandler(this.buttonDrawPotion_Click);
            // 
            // labelPowerEnemyInfo
            // 
            this.labelPowerEnemyInfo.AutoSize = true;
            this.labelPowerEnemyInfo.Location = new System.Drawing.Point(434, 354);
            this.labelPowerEnemyInfo.Name = "labelPowerEnemyInfo";
            this.labelPowerEnemyInfo.Size = new System.Drawing.Size(37, 13);
            this.labelPowerEnemyInfo.TabIndex = 49;
            this.labelPowerEnemyInfo.Text = "Power";
            // 
            // labelPowerEnemy
            // 
            this.labelPowerEnemy.AutoSize = true;
            this.labelPowerEnemy.Location = new System.Drawing.Point(475, 354);
            this.labelPowerEnemy.Name = "labelPowerEnemy";
            this.labelPowerEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelPowerEnemy.TabIndex = 48;
            this.labelPowerEnemy.Text = "0";
            // 
            // labelHpPEnemyInfo
            // 
            this.labelHpPEnemyInfo.AutoSize = true;
            this.labelHpPEnemyInfo.Location = new System.Drawing.Point(434, 328);
            this.labelHpPEnemyInfo.Name = "labelHpPEnemyInfo";
            this.labelHpPEnemyInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpPEnemyInfo.TabIndex = 47;
            this.labelHpPEnemyInfo.Text = "Hp";
            // 
            // labelManaEnemyInfo
            // 
            this.labelManaEnemyInfo.AutoSize = true;
            this.labelManaEnemyInfo.Location = new System.Drawing.Point(434, 341);
            this.labelManaEnemyInfo.Name = "labelManaEnemyInfo";
            this.labelManaEnemyInfo.Size = new System.Drawing.Size(34, 13);
            this.labelManaEnemyInfo.TabIndex = 46;
            this.labelManaEnemyInfo.Text = "Mana";
            // 
            // labelManaEnemy
            // 
            this.labelManaEnemy.AutoSize = true;
            this.labelManaEnemy.Location = new System.Drawing.Point(475, 341);
            this.labelManaEnemy.Name = "labelManaEnemy";
            this.labelManaEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelManaEnemy.TabIndex = 45;
            this.labelManaEnemy.Text = "0";
            // 
            // labelHpPEnemy
            // 
            this.labelHpPEnemy.AutoSize = true;
            this.labelHpPEnemy.Location = new System.Drawing.Point(475, 328);
            this.labelHpPEnemy.Name = "labelHpPEnemy";
            this.labelHpPEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelHpPEnemy.TabIndex = 44;
            this.labelHpPEnemy.Text = "0";
            // 
            // buttonDrawPotionEnemy
            // 
            this.buttonDrawPotionEnemy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDrawPotionEnemy.Location = new System.Drawing.Point(406, 302);
            this.buttonDrawPotionEnemy.Name = "buttonDrawPotionEnemy";
            this.buttonDrawPotionEnemy.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawPotionEnemy.TabIndex = 43;
            this.buttonDrawPotionEnemy.Text = "Draw Potion Card";
            this.buttonDrawPotionEnemy.UseVisualStyleBackColor = false;
            this.buttonDrawPotionEnemy.Click += new System.EventHandler(this.buttonDrawPotionEnemy_Click);
            // 
            // labelArmMInfo
            // 
            this.labelArmMInfo.AutoSize = true;
            this.labelArmMInfo.Location = new System.Drawing.Point(557, 241);
            this.labelArmMInfo.Name = "labelArmMInfo";
            this.labelArmMInfo.Size = new System.Drawing.Size(34, 13);
            this.labelArmMInfo.TabIndex = 56;
            this.labelArmMInfo.Text = "Armor";
            // 
            // labelArmM
            // 
            this.labelArmM.AutoSize = true;
            this.labelArmM.Location = new System.Drawing.Point(598, 241);
            this.labelArmM.Name = "labelArmM";
            this.labelArmM.Size = new System.Drawing.Size(13, 13);
            this.labelArmM.TabIndex = 55;
            this.labelArmM.Text = "0";
            // 
            // labelHpMInfo
            // 
            this.labelHpMInfo.AutoSize = true;
            this.labelHpMInfo.Location = new System.Drawing.Point(557, 215);
            this.labelHpMInfo.Name = "labelHpMInfo";
            this.labelHpMInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpMInfo.TabIndex = 54;
            this.labelHpMInfo.Text = "Hp";
            // 
            // labelAtcMInfo
            // 
            this.labelAtcMInfo.AutoSize = true;
            this.labelAtcMInfo.Location = new System.Drawing.Point(557, 228);
            this.labelAtcMInfo.Name = "labelAtcMInfo";
            this.labelAtcMInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcMInfo.TabIndex = 53;
            this.labelAtcMInfo.Text = "Atack";
            // 
            // labelAtcM
            // 
            this.labelAtcM.AutoSize = true;
            this.labelAtcM.Location = new System.Drawing.Point(598, 228);
            this.labelAtcM.Name = "labelAtcM";
            this.labelAtcM.Size = new System.Drawing.Size(13, 13);
            this.labelAtcM.TabIndex = 52;
            this.labelAtcM.Text = "0";
            // 
            // labelHpM
            // 
            this.labelHpM.AutoSize = true;
            this.labelHpM.Location = new System.Drawing.Point(598, 215);
            this.labelHpM.Name = "labelHpM";
            this.labelHpM.Size = new System.Drawing.Size(13, 13);
            this.labelHpM.TabIndex = 51;
            this.labelHpM.Text = "0";
            // 
            // buttonDrawMonster
            // 
            this.buttonDrawMonster.BackColor = System.Drawing.Color.Purple;
            this.buttonDrawMonster.Location = new System.Drawing.Point(529, 189);
            this.buttonDrawMonster.Name = "buttonDrawMonster";
            this.buttonDrawMonster.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawMonster.TabIndex = 50;
            this.buttonDrawMonster.Text = "Draw Monster Card";
            this.buttonDrawMonster.UseVisualStyleBackColor = false;
            this.buttonDrawMonster.Click += new System.EventHandler(this.buttonDrawMonster_Click);
            // 
            // labelArmMEnemyInfo
            // 
            this.labelArmMEnemyInfo.AutoSize = true;
            this.labelArmMEnemyInfo.Location = new System.Drawing.Point(557, 354);
            this.labelArmMEnemyInfo.Name = "labelArmMEnemyInfo";
            this.labelArmMEnemyInfo.Size = new System.Drawing.Size(34, 13);
            this.labelArmMEnemyInfo.TabIndex = 63;
            this.labelArmMEnemyInfo.Text = "Armor";
            // 
            // labelArmMEnemy
            // 
            this.labelArmMEnemy.AutoSize = true;
            this.labelArmMEnemy.Location = new System.Drawing.Point(598, 354);
            this.labelArmMEnemy.Name = "labelArmMEnemy";
            this.labelArmMEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelArmMEnemy.TabIndex = 62;
            this.labelArmMEnemy.Text = "0";
            // 
            // labelHpMEnemyInfo
            // 
            this.labelHpMEnemyInfo.AutoSize = true;
            this.labelHpMEnemyInfo.Location = new System.Drawing.Point(557, 328);
            this.labelHpMEnemyInfo.Name = "labelHpMEnemyInfo";
            this.labelHpMEnemyInfo.Size = new System.Drawing.Size(21, 13);
            this.labelHpMEnemyInfo.TabIndex = 61;
            this.labelHpMEnemyInfo.Text = "Hp";
            // 
            // labelAtcMEnemyInfo
            // 
            this.labelAtcMEnemyInfo.AutoSize = true;
            this.labelAtcMEnemyInfo.Location = new System.Drawing.Point(557, 341);
            this.labelAtcMEnemyInfo.Name = "labelAtcMEnemyInfo";
            this.labelAtcMEnemyInfo.Size = new System.Drawing.Size(35, 13);
            this.labelAtcMEnemyInfo.TabIndex = 60;
            this.labelAtcMEnemyInfo.Text = "Atack";
            // 
            // labelAtcMEnemy
            // 
            this.labelAtcMEnemy.AutoSize = true;
            this.labelAtcMEnemy.Location = new System.Drawing.Point(598, 341);
            this.labelAtcMEnemy.Name = "labelAtcMEnemy";
            this.labelAtcMEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelAtcMEnemy.TabIndex = 59;
            this.labelAtcMEnemy.Text = "0";
            // 
            // labelHpMEnemy
            // 
            this.labelHpMEnemy.AutoSize = true;
            this.labelHpMEnemy.Location = new System.Drawing.Point(598, 328);
            this.labelHpMEnemy.Name = "labelHpMEnemy";
            this.labelHpMEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelHpMEnemy.TabIndex = 58;
            this.labelHpMEnemy.Text = "0";
            // 
            // buttonDrawMonsterEnemy
            // 
            this.buttonDrawMonsterEnemy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDrawMonsterEnemy.Location = new System.Drawing.Point(529, 302);
            this.buttonDrawMonsterEnemy.Name = "buttonDrawMonsterEnemy";
            this.buttonDrawMonsterEnemy.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawMonsterEnemy.TabIndex = 57;
            this.buttonDrawMonsterEnemy.Text = "Draw Monster Card";
            this.buttonDrawMonsterEnemy.UseVisualStyleBackColor = false;
            this.buttonDrawMonsterEnemy.Click += new System.EventHandler(this.buttonDrawMonsterEnemy_Click);
            // 
            // labelDivEnemyInfo
            // 
            this.labelDivEnemyInfo.AutoSize = true;
            this.labelDivEnemyInfo.Location = new System.Drawing.Point(692, 354);
            this.labelDivEnemyInfo.Name = "labelDivEnemyInfo";
            this.labelDivEnemyInfo.Size = new System.Drawing.Size(41, 13);
            this.labelDivEnemyInfo.TabIndex = 77;
            this.labelDivEnemyInfo.Text = "Divinity";
            // 
            // labelDivEnemy
            // 
            this.labelDivEnemy.AutoSize = true;
            this.labelDivEnemy.Location = new System.Drawing.Point(740, 354);
            this.labelDivEnemy.Name = "labelDivEnemy";
            this.labelDivEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelDivEnemy.TabIndex = 76;
            this.labelDivEnemy.Text = "0";
            // 
            // labelRigEnemyInfo
            // 
            this.labelRigEnemyInfo.AutoSize = true;
            this.labelRigEnemyInfo.Location = new System.Drawing.Point(657, 328);
            this.labelRigEnemyInfo.Name = "labelRigEnemyInfo";
            this.labelRigEnemyInfo.Size = new System.Drawing.Size(77, 13);
            this.labelRigEnemyInfo.TabIndex = 75;
            this.labelRigEnemyInfo.Text = "Righteousness";
            // 
            // labelProEnemyInfo
            // 
            this.labelProEnemyInfo.AutoSize = true;
            this.labelProEnemyInfo.Location = new System.Drawing.Point(680, 341);
            this.labelProEnemyInfo.Name = "labelProEnemyInfo";
            this.labelProEnemyInfo.Size = new System.Drawing.Size(53, 13);
            this.labelProEnemyInfo.TabIndex = 74;
            this.labelProEnemyInfo.Text = "Prosperity";
            // 
            // labelProEnemy
            // 
            this.labelProEnemy.AutoSize = true;
            this.labelProEnemy.Location = new System.Drawing.Point(740, 341);
            this.labelProEnemy.Name = "labelProEnemy";
            this.labelProEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelProEnemy.TabIndex = 73;
            this.labelProEnemy.Text = "0";
            // 
            // labelRigEnemy
            // 
            this.labelRigEnemy.AutoSize = true;
            this.labelRigEnemy.Location = new System.Drawing.Point(740, 328);
            this.labelRigEnemy.Name = "labelRigEnemy";
            this.labelRigEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelRigEnemy.TabIndex = 72;
            this.labelRigEnemy.Text = "0";
            // 
            // buttonDrawBlessingEnemy
            // 
            this.buttonDrawBlessingEnemy.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDrawBlessingEnemy.Location = new System.Drawing.Point(652, 302);
            this.buttonDrawBlessingEnemy.Name = "buttonDrawBlessingEnemy";
            this.buttonDrawBlessingEnemy.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawBlessingEnemy.TabIndex = 71;
            this.buttonDrawBlessingEnemy.Text = "Draw Blessing Card";
            this.buttonDrawBlessingEnemy.UseVisualStyleBackColor = false;
            this.buttonDrawBlessingEnemy.Click += new System.EventHandler(this.buttonDrawBlessingEnemy_Click);
            // 
            // labelDivInfo
            // 
            this.labelDivInfo.AutoSize = true;
            this.labelDivInfo.Location = new System.Drawing.Point(692, 241);
            this.labelDivInfo.Name = "labelDivInfo";
            this.labelDivInfo.Size = new System.Drawing.Size(41, 13);
            this.labelDivInfo.TabIndex = 70;
            this.labelDivInfo.Text = "Divinity";
            // 
            // labelDiv
            // 
            this.labelDiv.AutoSize = true;
            this.labelDiv.Location = new System.Drawing.Point(740, 241);
            this.labelDiv.Name = "labelDiv";
            this.labelDiv.Size = new System.Drawing.Size(13, 13);
            this.labelDiv.TabIndex = 69;
            this.labelDiv.Text = "0";
            // 
            // labelRigInfo
            // 
            this.labelRigInfo.AutoSize = true;
            this.labelRigInfo.Location = new System.Drawing.Point(657, 215);
            this.labelRigInfo.Name = "labelRigInfo";
            this.labelRigInfo.Size = new System.Drawing.Size(77, 13);
            this.labelRigInfo.TabIndex = 68;
            this.labelRigInfo.Text = "Righteousness";
            // 
            // labelProInfo
            // 
            this.labelProInfo.AutoSize = true;
            this.labelProInfo.Location = new System.Drawing.Point(681, 228);
            this.labelProInfo.Name = "labelProInfo";
            this.labelProInfo.Size = new System.Drawing.Size(53, 13);
            this.labelProInfo.TabIndex = 67;
            this.labelProInfo.Text = "Prosperity";
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Location = new System.Drawing.Point(740, 228);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(13, 13);
            this.labelPro.TabIndex = 66;
            this.labelPro.Text = "0";
            // 
            // labelRig
            // 
            this.labelRig.AutoSize = true;
            this.labelRig.Location = new System.Drawing.Point(740, 215);
            this.labelRig.Name = "labelRig";
            this.labelRig.Size = new System.Drawing.Size(13, 13);
            this.labelRig.TabIndex = 65;
            this.labelRig.Text = "0";
            // 
            // buttonDrawBlessing
            // 
            this.buttonDrawBlessing.BackColor = System.Drawing.Color.Purple;
            this.buttonDrawBlessing.Location = new System.Drawing.Point(652, 189);
            this.buttonDrawBlessing.Name = "buttonDrawBlessing";
            this.buttonDrawBlessing.Size = new System.Drawing.Size(118, 23);
            this.buttonDrawBlessing.TabIndex = 64;
            this.buttonDrawBlessing.Text = "Draw Blessing Card";
            this.buttonDrawBlessing.UseVisualStyleBackColor = false;
            this.buttonDrawBlessing.Click += new System.EventHandler(this.buttonDrawBlessing_Click);
            // 
            // labelTimeMin
            // 
            this.labelTimeMin.AutoSize = true;
            this.labelTimeMin.Location = new System.Drawing.Point(770, 35);
            this.labelTimeMin.Name = "labelTimeMin";
            this.labelTimeMin.Size = new System.Drawing.Size(0, 13);
            this.labelTimeMin.TabIndex = 78;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(821, 213);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(13, 13);
            this.labelScore.TabIndex = 79;
            this.labelScore.Text = "0";
            // 
            // labelScoreEnemy
            // 
            this.labelScoreEnemy.AutoSize = true;
            this.labelScoreEnemy.Location = new System.Drawing.Point(822, 342);
            this.labelScoreEnemy.Name = "labelScoreEnemy";
            this.labelScoreEnemy.Size = new System.Drawing.Size(13, 13);
            this.labelScoreEnemy.TabIndex = 80;
            this.labelScoreEnemy.Text = "0";
            // 
            // labelScoreInfo
            // 
            this.labelScoreInfo.AutoSize = true;
            this.labelScoreInfo.Location = new System.Drawing.Point(777, 213);
            this.labelScoreInfo.Name = "labelScoreInfo";
            this.labelScoreInfo.Size = new System.Drawing.Size(38, 13);
            this.labelScoreInfo.TabIndex = 81;
            this.labelScoreInfo.Text = "Score:";
            // 
            // labelScoreEnemyInfo
            // 
            this.labelScoreEnemyInfo.AutoSize = true;
            this.labelScoreEnemyInfo.Location = new System.Drawing.Point(777, 341);
            this.labelScoreEnemyInfo.Name = "labelScoreEnemyInfo";
            this.labelScoreEnemyInfo.Size = new System.Drawing.Size(38, 13);
            this.labelScoreEnemyInfo.TabIndex = 82;
            this.labelScoreEnemyInfo.Text = "Score:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(773, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 83;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(773, 431);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 84;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // LeaveTheDungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(876, 517);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelScoreEnemyInfo);
            this.Controls.Add(this.labelScoreInfo);
            this.Controls.Add(this.labelScoreEnemy);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimeMin);
            this.Controls.Add(this.labelDivEnemyInfo);
            this.Controls.Add(this.labelDivEnemy);
            this.Controls.Add(this.labelRigEnemyInfo);
            this.Controls.Add(this.labelProEnemyInfo);
            this.Controls.Add(this.labelProEnemy);
            this.Controls.Add(this.labelRigEnemy);
            this.Controls.Add(this.buttonDrawBlessingEnemy);
            this.Controls.Add(this.labelDivInfo);
            this.Controls.Add(this.labelDiv);
            this.Controls.Add(this.labelRigInfo);
            this.Controls.Add(this.labelProInfo);
            this.Controls.Add(this.labelPro);
            this.Controls.Add(this.labelRig);
            this.Controls.Add(this.buttonDrawBlessing);
            this.Controls.Add(this.labelArmMEnemyInfo);
            this.Controls.Add(this.labelArmMEnemy);
            this.Controls.Add(this.labelHpMEnemyInfo);
            this.Controls.Add(this.labelAtcMEnemyInfo);
            this.Controls.Add(this.labelAtcMEnemy);
            this.Controls.Add(this.labelHpMEnemy);
            this.Controls.Add(this.buttonDrawMonsterEnemy);
            this.Controls.Add(this.labelArmMInfo);
            this.Controls.Add(this.labelArmM);
            this.Controls.Add(this.labelHpMInfo);
            this.Controls.Add(this.labelAtcMInfo);
            this.Controls.Add(this.labelAtcM);
            this.Controls.Add(this.labelHpM);
            this.Controls.Add(this.buttonDrawMonster);
            this.Controls.Add(this.labelPowerEnemyInfo);
            this.Controls.Add(this.labelPowerEnemy);
            this.Controls.Add(this.labelHpPEnemyInfo);
            this.Controls.Add(this.labelManaEnemyInfo);
            this.Controls.Add(this.labelManaEnemy);
            this.Controls.Add(this.labelHpPEnemy);
            this.Controls.Add(this.buttonDrawPotionEnemy);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelHpPInfo);
            this.Controls.Add(this.labelManaInfo);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelHpP);
            this.Controls.Add(this.buttonDrawPotion);
            this.Controls.Add(this.labelRangeInfo);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelStrengthInfo);
            this.Controls.Add(this.labelAtcWInfo);
            this.Controls.Add(this.labelAtcW);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.buttonDrawWeapon);
            this.Controls.Add(this.labelRangeEnemyInfo);
            this.Controls.Add(this.labelRangeEnemy);
            this.Controls.Add(this.labelStrengthEnemyInfo);
            this.Controls.Add(this.labelAtcWEnemyInfo);
            this.Controls.Add(this.labelAtcWEnemy);
            this.Controls.Add(this.labelStrengthEnemy);
            this.Controls.Add(this.buttonDrawWeaponEnemy);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelArmEnemy);
            this.Controls.Add(this.labelAtcEnemy);
            this.Controls.Add(this.labelHpEnemy);
            this.Controls.Add(this.labelArmEnemyInfo);
            this.Controls.Add(this.labelHpEnemyInfo);
            this.Controls.Add(this.labelAtcEnemyInfo);
            this.Controls.Add(this.buttonDrawEnemy);
            this.Controls.Add(this.radioButtonTimerOff);
            this.Controls.Add(this.radioButtonTimerOn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelArmInfo);
            this.Controls.Add(this.labelArm);
            this.Controls.Add(this.labelHpInfo);
            this.Controls.Add(this.labelAtcInfo);
            this.Controls.Add(this.labelAtc);
            this.Controls.Add(this.labelHp);
            this.Controls.Add(this.buttonDraw);
            this.Name = "LeaveTheDungeon";
            this.Text = "Leave The Dungeon";
            this.Load += new System.EventHandler(this.LeaveTheDungeon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelHp;
        private System.Windows.Forms.Label labelAtc;
        private System.Windows.Forms.Label labelAtcInfo;
        private System.Windows.Forms.Label labelHpInfo;
        private System.Windows.Forms.Label labelArm;
        private System.Windows.Forms.Label labelArmInfo;
        private System.Windows.Forms.Timer timerEnd;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMin;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonTimerOn;
        private System.Windows.Forms.RadioButton radioButtonTimerOff;
        private System.Windows.Forms.Button buttonDrawEnemy;
        private System.Windows.Forms.Label labelArmEnemyInfo;
        private System.Windows.Forms.Label labelHpEnemyInfo;
        private System.Windows.Forms.Label labelAtcEnemyInfo;
        private System.Windows.Forms.Label labelArmEnemy;
        private System.Windows.Forms.Label labelAtcEnemy;
        private System.Windows.Forms.Label labelHpEnemy;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelRangeEnemyInfo;
        private System.Windows.Forms.Label labelRangeEnemy;
        private System.Windows.Forms.Label labelStrengthEnemyInfo;
        private System.Windows.Forms.Label labelAtcWEnemyInfo;
        private System.Windows.Forms.Label labelAtcWEnemy;
        private System.Windows.Forms.Label labelStrengthEnemy;
        private System.Windows.Forms.Button buttonDrawWeaponEnemy;
        private System.Windows.Forms.Label labelRangeInfo;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelStrengthInfo;
        private System.Windows.Forms.Label labelAtcWInfo;
        private System.Windows.Forms.Label labelAtcW;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Button buttonDrawWeapon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelHpPInfo;
        private System.Windows.Forms.Label labelManaInfo;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelHpP;
        private System.Windows.Forms.Button buttonDrawPotion;
        private System.Windows.Forms.Label labelPowerEnemyInfo;
        private System.Windows.Forms.Label labelPowerEnemy;
        private System.Windows.Forms.Label labelHpPEnemyInfo;
        private System.Windows.Forms.Label labelManaEnemyInfo;
        private System.Windows.Forms.Label labelManaEnemy;
        private System.Windows.Forms.Label labelHpPEnemy;
        private System.Windows.Forms.Button buttonDrawPotionEnemy;
        private System.Windows.Forms.Label labelArmMInfo;
        private System.Windows.Forms.Label labelArmM;
        private System.Windows.Forms.Label labelHpMInfo;
        private System.Windows.Forms.Label labelAtcMInfo;
        private System.Windows.Forms.Label labelAtcM;
        private System.Windows.Forms.Label labelHpM;
        private System.Windows.Forms.Button buttonDrawMonster;
        private System.Windows.Forms.Label labelArmMEnemyInfo;
        private System.Windows.Forms.Label labelArmMEnemy;
        private System.Windows.Forms.Label labelHpMEnemyInfo;
        private System.Windows.Forms.Label labelAtcMEnemyInfo;
        private System.Windows.Forms.Label labelAtcMEnemy;
        private System.Windows.Forms.Label labelHpMEnemy;
        private System.Windows.Forms.Button buttonDrawMonsterEnemy;
        private System.Windows.Forms.Label labelDivEnemyInfo;
        private System.Windows.Forms.Label labelDivEnemy;
        private System.Windows.Forms.Label labelRigEnemyInfo;
        private System.Windows.Forms.Label labelProEnemyInfo;
        private System.Windows.Forms.Label labelProEnemy;
        private System.Windows.Forms.Label labelRigEnemy;
        private System.Windows.Forms.Button buttonDrawBlessingEnemy;
        private System.Windows.Forms.Label labelDivInfo;
        private System.Windows.Forms.Label labelDiv;
        private System.Windows.Forms.Label labelRigInfo;
        private System.Windows.Forms.Label labelProInfo;
        private System.Windows.Forms.Label labelPro;
        private System.Windows.Forms.Label labelRig;
        private System.Windows.Forms.Button buttonDrawBlessing;
        private System.Windows.Forms.Label labelTimeMin;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreEnemy;
        private System.Windows.Forms.Label labelScoreInfo;
        private System.Windows.Forms.Label labelScoreEnemyInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

