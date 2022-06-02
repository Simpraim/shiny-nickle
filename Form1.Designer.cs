namespace Budgeting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.categorize_button = new System.Windows.Forms.Button();
            this.category_box = new System.Windows.Forms.ListBox();
            this.category_input = new System.Windows.Forms.TextBox();
            this.add_category_button = new System.Windows.Forms.Button();
            this.cat_trans = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trans_display = new System.Windows.Forms.RichTextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.cat1 = new System.Windows.Forms.Button();
            this.cat2 = new System.Windows.Forms.Button();
            this.cat3 = new System.Windows.Forms.Button();
            this.cat4 = new System.Windows.Forms.Button();
            this.cat5 = new System.Windows.Forms.Button();
            this.cat6 = new System.Windows.Forms.Button();
            this.cat12 = new System.Windows.Forms.Button();
            this.cat11 = new System.Windows.Forms.Button();
            this.cat10 = new System.Windows.Forms.Button();
            this.cat9 = new System.Windows.Forms.Button();
            this.cat8 = new System.Windows.Forms.Button();
            this.cat7 = new System.Windows.Forms.Button();
            this.cat18 = new System.Windows.Forms.Button();
            this.cat17 = new System.Windows.Forms.Button();
            this.cat16 = new System.Windows.Forms.Button();
            this.cat15 = new System.Windows.Forms.Button();
            this.cat14 = new System.Windows.Forms.Button();
            this.cat13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1361, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categorize_button
            // 
            this.categorize_button.Location = new System.Drawing.Point(12, 84);
            this.categorize_button.Name = "categorize_button";
            this.categorize_button.Size = new System.Drawing.Size(1361, 66);
            this.categorize_button.TabIndex = 3;
            this.categorize_button.Text = "Add Categories";
            this.categorize_button.UseVisualStyleBackColor = true;
            this.categorize_button.Visible = false;
            this.categorize_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.ItemHeight = 16;
            this.category_box.Location = new System.Drawing.Point(12, 266);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(271, 84);
            this.category_box.TabIndex = 4;
            this.category_box.Visible = false;
            // 
            // category_input
            // 
            this.category_input.Location = new System.Drawing.Point(12, 238);
            this.category_input.Name = "category_input";
            this.category_input.Size = new System.Drawing.Size(157, 22);
            this.category_input.TabIndex = 5;
            this.category_input.Text = "Add categories here";
            this.category_input.Visible = false;
            this.category_input.MouseClick += new System.Windows.Forms.MouseEventHandler(this.category_input_MouseClick);
            this.category_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.category_input_KeyDown);
            // 
            // add_category_button
            // 
            this.add_category_button.Location = new System.Drawing.Point(175, 237);
            this.add_category_button.Name = "add_category_button";
            this.add_category_button.Size = new System.Drawing.Size(108, 23);
            this.add_category_button.TabIndex = 6;
            this.add_category_button.Text = "Add to list";
            this.add_category_button.UseVisualStyleBackColor = true;
            this.add_category_button.Visible = false;
            this.add_category_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_category_button_MouseClick);
            // 
            // cat_trans
            // 
            this.cat_trans.Location = new System.Drawing.Point(12, 156);
            this.cat_trans.Name = "cat_trans";
            this.cat_trans.Size = new System.Drawing.Size(1361, 66);
            this.cat_trans.TabIndex = 7;
            this.cat_trans.Text = "Categorize Transactions";
            this.cat_trans.UseVisualStyleBackColor = true;
            this.cat_trans.Visible = false;
            this.cat_trans.Click += new System.EventHandler(this.cat_trans_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Done!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trans_display
            // 
            this.trans_display.Location = new System.Drawing.Point(307, 266);
            this.trans_display.Name = "trans_display";
            this.trans_display.Size = new System.Drawing.Size(480, 113);
            this.trans_display.TabIndex = 9;
            this.trans_display.Text = "";
            this.trans_display.Visible = false;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(821, 266);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(163, 23);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Next Transaction";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Visible = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(438, 241);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(245, 17);
            this.status_label.TabIndex = 11;
            this.status_label.Text = "Select a category for your transaction";
            this.status_label.Visible = false;
            // 
            // cat1
            // 
            this.cat1.Location = new System.Drawing.Point(307, 385);
            this.cat1.Name = "cat1";
            this.cat1.Size = new System.Drawing.Size(75, 23);
            this.cat1.TabIndex = 12;
            this.cat1.UseVisualStyleBackColor = true;
            this.cat1.Visible = false;
            this.cat1.Click += new System.EventHandler(this.cat1_Click);
            // 
            // cat2
            // 
            this.cat2.Location = new System.Drawing.Point(388, 385);
            this.cat2.Name = "cat2";
            this.cat2.Size = new System.Drawing.Size(75, 23);
            this.cat2.TabIndex = 13;
            this.cat2.UseVisualStyleBackColor = true;
            this.cat2.Visible = false;
            this.cat2.Click += new System.EventHandler(this.cat2_Click);
            // 
            // cat3
            // 
            this.cat3.Location = new System.Drawing.Point(469, 385);
            this.cat3.Name = "cat3";
            this.cat3.Size = new System.Drawing.Size(75, 23);
            this.cat3.TabIndex = 14;
            this.cat3.UseVisualStyleBackColor = true;
            this.cat3.Visible = false;
            this.cat3.Click += new System.EventHandler(this.cat3_Click);
            // 
            // cat4
            // 
            this.cat4.Location = new System.Drawing.Point(550, 385);
            this.cat4.Name = "cat4";
            this.cat4.Size = new System.Drawing.Size(75, 23);
            this.cat4.TabIndex = 15;
            this.cat4.UseVisualStyleBackColor = true;
            this.cat4.Visible = false;
            this.cat4.Click += new System.EventHandler(this.cat4_Click);
            // 
            // cat5
            // 
            this.cat5.Location = new System.Drawing.Point(631, 385);
            this.cat5.Name = "cat5";
            this.cat5.Size = new System.Drawing.Size(75, 23);
            this.cat5.TabIndex = 16;
            this.cat5.UseVisualStyleBackColor = true;
            this.cat5.Visible = false;
            this.cat5.Click += new System.EventHandler(this.cat5_Click);
            // 
            // cat6
            // 
            this.cat6.Location = new System.Drawing.Point(712, 385);
            this.cat6.Name = "cat6";
            this.cat6.Size = new System.Drawing.Size(75, 23);
            this.cat6.TabIndex = 17;
            this.cat6.UseVisualStyleBackColor = true;
            this.cat6.Visible = false;
            this.cat6.Click += new System.EventHandler(this.cat6_Click);
            // 
            // cat12
            // 
            this.cat12.Location = new System.Drawing.Point(712, 414);
            this.cat12.Name = "cat12";
            this.cat12.Size = new System.Drawing.Size(75, 23);
            this.cat12.TabIndex = 23;
            this.cat12.UseVisualStyleBackColor = true;
            this.cat12.Visible = false;
            this.cat12.Click += new System.EventHandler(this.cat12_Click);
            // 
            // cat11
            // 
            this.cat11.Location = new System.Drawing.Point(631, 414);
            this.cat11.Name = "cat11";
            this.cat11.Size = new System.Drawing.Size(75, 23);
            this.cat11.TabIndex = 22;
            this.cat11.UseVisualStyleBackColor = true;
            this.cat11.Visible = false;
            this.cat11.Click += new System.EventHandler(this.cat11_Click);
            // 
            // cat10
            // 
            this.cat10.Location = new System.Drawing.Point(550, 414);
            this.cat10.Name = "cat10";
            this.cat10.Size = new System.Drawing.Size(75, 23);
            this.cat10.TabIndex = 21;
            this.cat10.UseVisualStyleBackColor = true;
            this.cat10.Visible = false;
            this.cat10.Click += new System.EventHandler(this.cat10_Click);
            // 
            // cat9
            // 
            this.cat9.Location = new System.Drawing.Point(469, 414);
            this.cat9.Name = "cat9";
            this.cat9.Size = new System.Drawing.Size(75, 23);
            this.cat9.TabIndex = 20;
            this.cat9.UseVisualStyleBackColor = true;
            this.cat9.Visible = false;
            this.cat9.Click += new System.EventHandler(this.cat9_Click);
            // 
            // cat8
            // 
            this.cat8.Location = new System.Drawing.Point(388, 414);
            this.cat8.Name = "cat8";
            this.cat8.Size = new System.Drawing.Size(75, 23);
            this.cat8.TabIndex = 19;
            this.cat8.UseVisualStyleBackColor = true;
            this.cat8.Visible = false;
            this.cat8.Click += new System.EventHandler(this.cat8_Click);
            // 
            // cat7
            // 
            this.cat7.Location = new System.Drawing.Point(307, 414);
            this.cat7.Name = "cat7";
            this.cat7.Size = new System.Drawing.Size(75, 23);
            this.cat7.TabIndex = 18;
            this.cat7.UseVisualStyleBackColor = true;
            this.cat7.Visible = false;
            this.cat7.Click += new System.EventHandler(this.cat7_Click);
            // 
            // cat18
            // 
            this.cat18.Location = new System.Drawing.Point(712, 443);
            this.cat18.Name = "cat18";
            this.cat18.Size = new System.Drawing.Size(75, 23);
            this.cat18.TabIndex = 29;
            this.cat18.UseVisualStyleBackColor = true;
            this.cat18.Visible = false;
            this.cat18.Click += new System.EventHandler(this.cat18_Click_1);
            // 
            // cat17
            // 
            this.cat17.Location = new System.Drawing.Point(631, 443);
            this.cat17.Name = "cat17";
            this.cat17.Size = new System.Drawing.Size(75, 23);
            this.cat17.TabIndex = 28;
            this.cat17.UseVisualStyleBackColor = true;
            this.cat17.Visible = false;
            this.cat17.Click += new System.EventHandler(this.cat17_Click);
            // 
            // cat16
            // 
            this.cat16.Location = new System.Drawing.Point(550, 443);
            this.cat16.Name = "cat16";
            this.cat16.Size = new System.Drawing.Size(75, 23);
            this.cat16.TabIndex = 27;
            this.cat16.UseVisualStyleBackColor = true;
            this.cat16.Visible = false;
            this.cat16.Click += new System.EventHandler(this.cat16_Click);
            // 
            // cat15
            // 
            this.cat15.Location = new System.Drawing.Point(469, 443);
            this.cat15.Name = "cat15";
            this.cat15.Size = new System.Drawing.Size(75, 23);
            this.cat15.TabIndex = 26;
            this.cat15.UseVisualStyleBackColor = true;
            this.cat15.Visible = false;
            this.cat15.Click += new System.EventHandler(this.cat15_Click);
            // 
            // cat14
            // 
            this.cat14.Location = new System.Drawing.Point(388, 443);
            this.cat14.Name = "cat14";
            this.cat14.Size = new System.Drawing.Size(75, 23);
            this.cat14.TabIndex = 25;
            this.cat14.UseVisualStyleBackColor = true;
            this.cat14.Visible = false;
            this.cat14.Click += new System.EventHandler(this.cat14_Click);
            // 
            // cat13
            // 
            this.cat13.Location = new System.Drawing.Point(307, 443);
            this.cat13.Name = "cat13";
            this.cat13.Size = new System.Drawing.Size(75, 23);
            this.cat13.TabIndex = 24;
            this.cat13.UseVisualStyleBackColor = true;
            this.cat13.Visible = false;
            this.cat13.Click += new System.EventHandler(this.cat13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1385, 492);
            this.Controls.Add(this.cat18);
            this.Controls.Add(this.cat17);
            this.Controls.Add(this.cat16);
            this.Controls.Add(this.cat15);
            this.Controls.Add(this.cat14);
            this.Controls.Add(this.cat13);
            this.Controls.Add(this.cat12);
            this.Controls.Add(this.cat11);
            this.Controls.Add(this.cat10);
            this.Controls.Add(this.cat9);
            this.Controls.Add(this.cat8);
            this.Controls.Add(this.cat7);
            this.Controls.Add(this.cat6);
            this.Controls.Add(this.cat5);
            this.Controls.Add(this.cat4);
            this.Controls.Add(this.cat3);
            this.Controls.Add(this.cat2);
            this.Controls.Add(this.cat1);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.trans_display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cat_trans);
            this.Controls.Add(this.add_category_button);
            this.Controls.Add(this.category_input);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.categorize_button);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Budgeting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button categorize_button;
        private System.Windows.Forms.ListBox category_box;
        private System.Windows.Forms.TextBox category_input;
        private System.Windows.Forms.Button add_category_button;
        private System.Windows.Forms.Button cat_trans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox trans_display;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button cat1;
        private System.Windows.Forms.Button cat2;
        private System.Windows.Forms.Button cat3;
        private System.Windows.Forms.Button cat4;
        private System.Windows.Forms.Button cat5;
        private System.Windows.Forms.Button cat6;
        private System.Windows.Forms.Button cat12;
        private System.Windows.Forms.Button cat11;
        private System.Windows.Forms.Button cat10;
        private System.Windows.Forms.Button cat9;
        private System.Windows.Forms.Button cat8;
        private System.Windows.Forms.Button cat7;
        private System.Windows.Forms.Button cat18;
        private System.Windows.Forms.Button cat17;
        private System.Windows.Forms.Button cat16;
        private System.Windows.Forms.Button cat15;
        private System.Windows.Forms.Button cat14;
        private System.Windows.Forms.Button cat13;
    }
}

