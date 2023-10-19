namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            anket_box = new GroupBox();
            list_group_box = new GroupBox();
            fileName_box = new TextBox();
            btn_load = new Button();
            btn_save = new Button();
            name_box = new TextBox();
            surname_box = new TextBox();
            email_box = new TextBox();
            tel_box = new TextBox();
            day_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_change = new Button();
            people_list = new ListBox();
            month_box = new TextBox();
            year_box = new TextBox();
            minus_label = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            anket_box.SuspendLayout();
            list_group_box.SuspendLayout();
            SuspendLayout();
            // 
            // anket_box
            // 
            anket_box.Controls.Add(label10);
            anket_box.Controls.Add(label9);
            anket_box.Controls.Add(label8);
            anket_box.Controls.Add(label7);
            anket_box.Controls.Add(label6);
            anket_box.Controls.Add(minus_label);
            anket_box.Controls.Add(year_box);
            anket_box.Controls.Add(month_box);
            anket_box.Controls.Add(btn_change);
            anket_box.Controls.Add(btn_add);
            anket_box.Controls.Add(label5);
            anket_box.Controls.Add(label4);
            anket_box.Controls.Add(label3);
            anket_box.Controls.Add(label2);
            anket_box.Controls.Add(label1);
            anket_box.Controls.Add(day_box);
            anket_box.Controls.Add(tel_box);
            anket_box.Controls.Add(email_box);
            anket_box.Controls.Add(surname_box);
            anket_box.Controls.Add(name_box);
            anket_box.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            anket_box.Location = new Point(50, 57);
            anket_box.Name = "anket_box";
            anket_box.Size = new Size(392, 332);
            anket_box.TabIndex = 0;
            anket_box.TabStop = false;
            anket_box.Text = "Anket";
            // 
            // list_group_box
            // 
            list_group_box.Controls.Add(people_list);
            list_group_box.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            list_group_box.Location = new Point(470, 57);
            list_group_box.Name = "list_group_box";
            list_group_box.Size = new Size(267, 269);
            list_group_box.TabIndex = 1;
            list_group_box.TabStop = false;
            list_group_box.Text = "ListBox";
            // 
            // fileName_box
            // 
            fileName_box.Location = new Point(470, 332);
            fileName_box.Name = "fileName_box";
            fileName_box.Size = new Size(267, 23);
            fileName_box.TabIndex = 2;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(470, 361);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(116, 28);
            btn_load.TabIndex = 3;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(621, 361);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(116, 28);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // name_box
            // 
            name_box.Location = new Point(92, 43);
            name_box.Name = "name_box";
            name_box.Size = new Size(276, 27);
            name_box.TabIndex = 0;
            // 
            // surname_box
            // 
            surname_box.Location = new Point(92, 85);
            surname_box.Name = "surname_box";
            surname_box.Size = new Size(276, 27);
            surname_box.TabIndex = 1;
            // 
            // email_box
            // 
            email_box.Location = new Point(92, 132);
            email_box.Name = "email_box";
            email_box.Size = new Size(276, 27);
            email_box.TabIndex = 2;
            // 
            // tel_box
            // 
            tel_box.Location = new Point(92, 175);
            tel_box.Name = "tel_box";
            tel_box.Size = new Size(276, 27);
            tel_box.TabIndex = 3;
            // 
            // day_box
            // 
            day_box.Location = new Point(92, 223);
            day_box.Name = "day_box";
            day_box.Size = new Size(59, 27);
            day_box.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 17);
            label1.TabIndex = 5;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 6;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 133);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 176);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 8;
            label4.Text = "Tel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 224);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 9;
            label5.Text = "B-Date:";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(253, 275);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(115, 35);
            btn_add.TabIndex = 10;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += add_click;
            // 
            // btn_change
            // 
            btn_change.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.Location = new Point(112, 275);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(115, 35);
            btn_change.TabIndex = 11;
            btn_change.Text = "Change";
            btn_change.UseVisualStyleBackColor = true;
            // 
            // people_list
            // 
            people_list.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            people_list.FormattingEnabled = true;
            people_list.ItemHeight = 15;
            people_list.Location = new Point(6, 20);
            people_list.Name = "people_list";
            people_list.Size = new Size(255, 244);
            people_list.TabIndex = 0;
            people_list.Tag = "";
            // 
            // month_box
            // 
            month_box.Location = new Point(178, 224);
            month_box.Name = "month_box";
            month_box.Size = new Size(59, 27);
            month_box.TabIndex = 12;
            // 
            // year_box
            // 
            year_box.Location = new Point(263, 224);
            year_box.Name = "year_box";
            year_box.Size = new Size(105, 27);
            year_box.TabIndex = 13;
            // 
            // minus_label
            // 
            minus_label.AutoSize = true;
            minus_label.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            minus_label.ForeColor = Color.Silver;
            minus_label.Location = new Point(157, 226);
            minus_label.Name = "minus_label";
            minus_label.Size = new Size(16, 20);
            minus_label.TabIndex = 5;
            minus_label.Text = "/";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(242, 227);
            label6.Name = "label6";
            label6.Size = new Size(16, 20);
            label6.TabIndex = 6;
            label6.Text = "/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(92, 205);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 5;
            label7.Text = "Day";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(178, 206);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 6;
            label8.Text = "Month";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(263, 205);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 6;
            label9.Text = "Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.IndianRed;
            label10.Location = new Point(92, 251);
            label10.Name = "label10";
            label10.Size = new Size(80, 13);
            label10.TabIndex = 5;
            label10.Text = "Ex: 2 / 4 / 1999";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_load);
            Controls.Add(fileName_box);
            Controls.Add(list_group_box);
            Controls.Add(anket_box);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            anket_box.ResumeLayout(false);
            anket_box.PerformLayout();
            list_group_box.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox anket_box;
        private GroupBox list_group_box;
        private Label label1;
        private TextBox day_box;
        private TextBox tel_box;
        private TextBox email_box;
        private TextBox surname_box;
        private TextBox name_box;
        private TextBox fileName_box;
        private Button btn_load;
        private Button btn_save;
        private Button btn_change;
        private Button btn_add;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox people_list;
        private TextBox year_box;
        private TextBox month_box;
        private Label label7;
        private Label label6;
        private Label minus_label;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}