namespace MY_WHETHER_YANDEX_PARSER
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.labelCityName = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelWindDir = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPressureMM = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Калуга",
            "Брянск",
            "Москва",
            "Санкт-Петербург",
            "Владивосток",
            "Калининград",
            "Краснодар",
            "Людинова"});
            this.comboBoxCities.Location = new System.Drawing.Point(8, 32);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(198, 26);
            this.comboBoxCities.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Города";
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetWeather.Location = new System.Drawing.Point(225, 25);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(183, 40);
            this.buttonGetWeather.TabIndex = 2;
            this.buttonGetWeather.Text = "Получить погоду";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCityName.ForeColor = System.Drawing.Color.Maroon;
            this.labelCityName.Location = new System.Drawing.Point(185, 89);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(19, 25);
            this.labelCityName.TabIndex = 3;
            this.labelCityName.Text = "-";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelLat.Location = new System.Drawing.Point(77, 415);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(15, 20);
            this.labelLat.TabIndex = 4;
            this.labelLat.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(-1, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Широта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(-1, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Долгота:";
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelLon.Location = new System.Drawing.Point(87, 440);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(15, 20);
            this.labelLon.TabIndex = 6;
            this.labelLon.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(104, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Температура:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(172, 149);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(18, 20);
            this.labelTemp.TabIndex = 9;
            this.labelTemp.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Погодные условия:";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCondition.Location = new System.Drawing.Point(213, 190);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(18, 20);
            this.labelCondition.TabIndex = 11;
            this.labelCondition.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Скорость ветра:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeed.Location = new System.Drawing.Point(191, 230);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(18, 20);
            this.labelWindSpeed.TabIndex = 13;
            this.labelWindSpeed.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Направление ветра:";
            // 
            // labelWindDir
            // 
            this.labelWindDir.AutoSize = true;
            this.labelWindDir.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindDir.Location = new System.Drawing.Point(217, 272);
            this.labelWindDir.Name = "labelWindDir";
            this.labelWindDir.Size = new System.Drawing.Size(18, 20);
            this.labelWindDir.TabIndex = 15;
            this.labelWindDir.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Давление (мм):";
            // 
            // labelPressureMM
            // 
            this.labelPressureMM.AutoSize = true;
            this.labelPressureMM.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressureMM.Location = new System.Drawing.Point(189, 313);
            this.labelPressureMM.Name = "labelPressureMM";
            this.labelPressureMM.Size = new System.Drawing.Size(18, 20);
            this.labelPressureMM.TabIndex = 17;
            this.labelPressureMM.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "Влажность воздуха (%):";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(257, 358);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(18, 20);
            this.labelHumidity.TabIndex = 19;
            this.labelHumidity.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 472);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelPressureMM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelWindDir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "Form1";
            this.Text = "Yandex.Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelWindDir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPressureMM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelHumidity;
    }
}

