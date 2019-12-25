namespace Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_cityname = new System.Windows.Forms.Label();
            this.lbl_units = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wind = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_lon = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbl_cityname
            // 
            this.lbl_cityname.AutoSize = true;
            this.lbl_cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cityname.Location = new System.Drawing.Point(19, 27);
            this.lbl_cityname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cityname.Name = "lbl_cityname";
            this.lbl_cityname.Size = new System.Drawing.Size(135, 46);
            this.lbl_cityname.TabIndex = 0;
            this.lbl_cityname.Text = "Город";
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_units.Location = new System.Drawing.Point(136, 84);
            this.lbl_units.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(0, 46);
            this.lbl_units.TabIndex = 2;
            
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 157);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Цельсий";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 180);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Фаренгейт";
            this.radioButton2.UseVisualStyleBackColor = true;
            
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_temp.Location = new System.Drawing.Point(19, 84);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(0, 46);
            this.lbl_temp.TabIndex = 6;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ветер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Влажность:";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.Location = new System.Drawing.Point(306, 110);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(0, 13);
            this.lbl_wind.TabIndex = 9;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Location = new System.Drawing.Point(332, 84);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(0, 13);
            this.lbl_humidity.TabIndex = 10;
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Location = new System.Drawing.Point(304, 157);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(0, 13);
            this.lbl_lat.TabIndex = 11;
            // 
            // lbl_lon
            // 
            this.lbl_lon.AutoSize = true;
            this.lbl_lon.Location = new System.Drawing.Point(314, 180);
            this.lbl_lon.Name = "lbl_lon";
            this.lbl_lon.Size = new System.Drawing.Size(0, 13);
            this.lbl_lon.TabIndex = 12;
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(400, 27);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(121, 20);
            this.search_box.TabIndex = 13;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(530, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(58, 21);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Долгота:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Широта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Шкала";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 223);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.lbl_lon);
            this.Controls.Add(this.lbl_lat);
            this.Controls.Add(this.lbl_humidity);
            this.Controls.Add(this.lbl_wind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_units);
            this.Controls.Add(this.lbl_cityname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_cityname;
        private System.Windows.Forms.Label lbl_units;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wind;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_lon;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

