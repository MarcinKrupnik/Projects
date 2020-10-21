namespace MarcinKrupnikLab2
{
    partial class Form1
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
            this.LabelName = new System.Windows.Forms.Label();
            this.radioButtonTram = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.textBoxVehicleNumber = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxMake = new System.Windows.Forms.GroupBox();
            this.labelMod = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelNr = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.buttonPantographUp = new System.Windows.Forms.Button();
            this.buttonRefual = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPantographDown = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelActualModelDesc = new System.Windows.Forms.Label();
            this.labelActualYearDesc = new System.Windows.Forms.Label();
            this.labelActualNumberDesc = new System.Windows.Forms.Label();
            this.labelActualVehicleDesc = new System.Windows.Forms.Label();
            this.labelActualModel = new System.Windows.Forms.Label();
            this.labelActualYearOfProduction = new System.Windows.Forms.Label();
            this.labelActualNumberVehicle = new System.Windows.Forms.Label();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.groupBoxMake.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.LabelName.Location = new System.Drawing.Point(34, 27);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(194, 31);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Marcin Krupnik";
            // 
            // radioButtonTram
            // 
            this.radioButtonTram.AutoSize = true;
            this.radioButtonTram.Location = new System.Drawing.Point(19, 34);
            this.radioButtonTram.Name = "radioButtonTram";
            this.radioButtonTram.Size = new System.Drawing.Size(65, 17);
            this.radioButtonTram.TabIndex = 1;
            this.radioButtonTram.TabStop = true;
            this.radioButtonTram.Text = "Tramwaj";
            this.radioButtonTram.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(119, 34);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(64, 17);
            this.radioButtonAuto.TabIndex = 2;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "Autobus";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(49, 153);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(168, 23);
            this.buttonAddVehicle.TabIndex = 3;
            this.buttonAddVehicle.Text = "Dodaj nowy pojazd";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // textBoxVehicleNumber
            // 
            this.textBoxVehicleNumber.Location = new System.Drawing.Point(148, 75);
            this.textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            this.textBoxVehicleNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxVehicleNumber.TabIndex = 4;
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(148, 102);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(100, 20);
            this.textBoxYearOfProduction.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // groupBoxMake
            // 
            this.groupBoxMake.Controls.Add(this.labelMod);
            this.groupBoxMake.Controls.Add(this.labelYear);
            this.groupBoxMake.Controls.Add(this.labelNr);
            this.groupBoxMake.Controls.Add(this.textBoxVehicleNumber);
            this.groupBoxMake.Controls.Add(this.textBoxName);
            this.groupBoxMake.Controls.Add(this.radioButtonTram);
            this.groupBoxMake.Controls.Add(this.textBoxYearOfProduction);
            this.groupBoxMake.Controls.Add(this.radioButtonAuto);
            this.groupBoxMake.Controls.Add(this.buttonAddVehicle);
            this.groupBoxMake.Location = new System.Drawing.Point(23, 85);
            this.groupBoxMake.Name = "groupBoxMake";
            this.groupBoxMake.Size = new System.Drawing.Size(373, 201);
            this.groupBoxMake.TabIndex = 7;
            this.groupBoxMake.TabStop = false;
            this.groupBoxMake.Text = "Utwórz nowy pojazd";
            // 
            // labelMod
            // 
            this.labelMod.AutoSize = true;
            this.labelMod.Location = new System.Drawing.Point(20, 90);
            this.labelMod.Name = "labelMod";
            this.labelMod.Size = new System.Drawing.Size(39, 13);
            this.labelMod.TabIndex = 9;
            this.labelMod.Text = "Model:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(17, 73);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(76, 13);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "Rok produkcji:";
            // 
            // labelNr
            // 
            this.labelNr.AutoSize = true;
            this.labelNr.Location = new System.Drawing.Point(17, 56);
            this.labelNr.Name = "labelNr";
            this.labelNr.Size = new System.Drawing.Size(61, 13);
            this.labelNr.TabIndex = 7;
            this.labelNr.Text = "Nr pojazdu:";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonPantographUp);
            this.groupBoxList.Controls.Add(this.buttonRefual);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonPantographDown);
            this.groupBoxList.Controls.Add(this.buttonBell);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActualModelDesc);
            this.groupBoxList.Controls.Add(this.labelActualYearDesc);
            this.groupBoxList.Controls.Add(this.labelActualNumberDesc);
            this.groupBoxList.Controls.Add(this.labelActualVehicleDesc);
            this.groupBoxList.Controls.Add(this.labelActualModel);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProduction);
            this.groupBoxList.Controls.Add(this.labelActualNumberVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Location = new System.Drawing.Point(418, 46);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(314, 279);
            this.groupBoxList.TabIndex = 8;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista obiektów";
            // 
            // buttonPantographUp
            // 
            this.buttonPantographUp.Location = new System.Drawing.Point(162, 250);
            this.buttonPantographUp.Name = "buttonPantographUp";
            this.buttonPantographUp.Size = new System.Drawing.Size(133, 23);
            this.buttonPantographUp.TabIndex = 16;
            this.buttonPantographUp.Text = "Podniesiono pantograf";
            this.buttonPantographUp.UseVisualStyleBackColor = true;
            this.buttonPantographUp.Click += new System.EventHandler(this.buttonPantographUp_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefual.Location = new System.Drawing.Point(162, 221);
            this.buttonRefual.Name = "buttonRefuel";
            this.buttonRefual.Size = new System.Drawing.Size(133, 23);
            this.buttonRefual.TabIndex = 15;
            this.buttonRefual.Text = "Zatankuj pojazd";
            this.buttonRefual.UseVisualStyleBackColor = true;
            this.buttonRefual.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.Location = new System.Drawing.Point(162, 192);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(133, 23);
            this.buttonStopVehicle.TabIndex = 14;
            this.buttonStopVehicle.Text = "Zatrzymaj Pojazd";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(162, 163);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(133, 23);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Następny element";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPantographDown
            // 
            this.buttonPantographDown.Location = new System.Drawing.Point(6, 250);
            this.buttonPantographDown.Name = "buttonPantographDown";
            this.buttonPantographDown.Size = new System.Drawing.Size(123, 23);
            this.buttonPantographDown.TabIndex = 12;
            this.buttonPantographDown.Text = "Opuść pantograf";
            this.buttonPantographDown.UseVisualStyleBackColor = true;
            this.buttonPantographDown.Click += new System.EventHandler(this.buttonPantographDown_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.Location = new System.Drawing.Point(6, 221);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(123, 23);
            this.buttonBell.TabIndex = 11;
            this.buttonBell.Text = "Zadzwoń dzwonkiem";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.Location = new System.Drawing.Point(6, 192);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(123, 23);
            this.buttonStartVehicle.TabIndex = 10;
            this.buttonStartVehicle.Text = "Rusz pojazdem";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(6, 163);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(123, 23);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "Poprzedni element";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelActualModelDesc
            // 
            this.labelActualModelDesc.AutoSize = true;
            this.labelActualModelDesc.Location = new System.Drawing.Point(181, 136);
            this.labelActualModelDesc.Name = "labelActualModelDesc";
            this.labelActualModelDesc.Size = new System.Drawing.Size(14, 13);
            this.labelActualModelDesc.TabIndex = 8;
            this.labelActualModelDesc.Text = "#";
            // 
            // labelActualYearDesc
            // 
            this.labelActualYearDesc.AutoSize = true;
            this.labelActualYearDesc.Location = new System.Drawing.Point(181, 105);
            this.labelActualYearDesc.Name = "labelActualYearDesc";
            this.labelActualYearDesc.Size = new System.Drawing.Size(14, 13);
            this.labelActualYearDesc.TabIndex = 7;
            this.labelActualYearDesc.Text = "#";
            // 
            // labelActualNumberDesc
            // 
            this.labelActualNumberDesc.AutoSize = true;
            this.labelActualNumberDesc.Location = new System.Drawing.Point(181, 75);
            this.labelActualNumberDesc.Name = "labelActualNumberDesc";
            this.labelActualNumberDesc.Size = new System.Drawing.Size(14, 13);
            this.labelActualNumberDesc.TabIndex = 6;
            this.labelActualNumberDesc.Text = "#";
            // 
            // labelActualVehicleDesc
            // 
            this.labelActualVehicleDesc.AutoSize = true;
            this.labelActualVehicleDesc.Location = new System.Drawing.Point(181, 47);
            this.labelActualVehicleDesc.Name = "labelActualVehicleDesc";
            this.labelActualVehicleDesc.Size = new System.Drawing.Size(14, 13);
            this.labelActualVehicleDesc.TabIndex = 5;
            this.labelActualVehicleDesc.Text = "#";
            // 
            // labelActualModel
            // 
            this.labelActualModel.AutoSize = true;
            this.labelActualModel.Location = new System.Drawing.Point(10, 136);
            this.labelActualModel.Name = "labelActualModel";
            this.labelActualModel.Size = new System.Drawing.Size(39, 13);
            this.labelActualModel.TabIndex = 4;
            this.labelActualModel.Text = "Model:";
            // 
            // labelActualYearOfProduction
            // 
            this.labelActualYearOfProduction.AutoSize = true;
            this.labelActualYearOfProduction.Location = new System.Drawing.Point(10, 105);
            this.labelActualYearOfProduction.Name = "labelActualYearOfProduction";
            this.labelActualYearOfProduction.Size = new System.Drawing.Size(76, 13);
            this.labelActualYearOfProduction.TabIndex = 2;
            this.labelActualYearOfProduction.Text = "Rok produkcji:";
            // 
            // labelActualNumberVehicle
            // 
            this.labelActualNumberVehicle.AutoSize = true;
            this.labelActualNumberVehicle.Location = new System.Drawing.Point(10, 78);
            this.labelActualNumberVehicle.Name = "labelActualNumberVehicle";
            this.labelActualNumberVehicle.Size = new System.Drawing.Size(61, 13);
            this.labelActualNumberVehicle.TabIndex = 1;
            this.labelActualNumberVehicle.Text = "Nr pojazdu:";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(10, 47);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(85, 13);
            this.labelActualVehicle.TabIndex = 0;
            this.labelActualVehicle.Text = "Aktualny pojazd:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxMake);
            this.Controls.Add(this.LabelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMake.ResumeLayout(false);
            this.groupBoxMake.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.RadioButton radioButtonTram;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.TextBox textBoxVehicleNumber;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxMake;
        private System.Windows.Forms.Label labelMod;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelNr;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonPantographUp;
        private System.Windows.Forms.Button buttonRefual;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPantographDown;
        private System.Windows.Forms.Button buttonBell;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelActualModelDesc;
        private System.Windows.Forms.Label labelActualYearDesc;
        private System.Windows.Forms.Label labelActualNumberDesc;
        private System.Windows.Forms.Label labelActualVehicleDesc;
        private System.Windows.Forms.Label labelActualModel;
        private System.Windows.Forms.Label labelActualYearOfProduction;
        private System.Windows.Forms.Label labelActualNumberVehicle;
        private System.Windows.Forms.Label labelActualVehicle;
    }
}

