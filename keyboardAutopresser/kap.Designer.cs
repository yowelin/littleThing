namespace keyboard_autopresser
{
    partial class frm_kap
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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.gb_keyToPress = new System.Windows.Forms.GroupBox();
            this.gb_KeyModifiers = new System.Windows.Forms.GroupBox();
            this.chb_shiftKeyModifier = new System.Windows.Forms.CheckBox();
            this.chb_ctrlKeyModifier = new System.Windows.Forms.CheckBox();
            this.chb_altKeyModifier = new System.Windows.Forms.CheckBox();
            this.lbl_keyToPress = new System.Windows.Forms.Label();
            this.cb_keyToPress = new System.Windows.Forms.ComboBox();
            this.gb_PressOptions = new System.Windows.Forms.GroupBox();
            this.cb_timeUnits = new System.Windows.Forms.ComboBox();
            this.nud_delayTime = new System.Windows.Forms.NumericUpDown();
            this.lbl_delayTime = new System.Windows.Forms.Label();
            this.rb_delay = new System.Windows.Forms.RadioButton();
            this.rb_continuously = new System.Windows.Forms.RadioButton();
            this.timer_KeyPressing = new System.Windows.Forms.Timer(this.components);
            this.gb_keyToPress.SuspendLayout();
            this.gb_KeyModifiers.SuspendLayout();
            this.gb_PressOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(50, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 50);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start (Ctrl + F1)";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(200, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 50);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop (Ctrl + F2)";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // gb_keyToPress
            // 
            this.gb_keyToPress.Controls.Add(this.gb_KeyModifiers);
            this.gb_keyToPress.Controls.Add(this.lbl_keyToPress);
            this.gb_keyToPress.Controls.Add(this.cb_keyToPress);
            this.gb_keyToPress.Location = new System.Drawing.Point(12, 70);
            this.gb_keyToPress.Name = "gb_keyToPress";
            this.gb_keyToPress.Size = new System.Drawing.Size(326, 101);
            this.gb_keyToPress.TabIndex = 2;
            this.gb_keyToPress.TabStop = false;
            this.gb_keyToPress.Text = "the Key to Press";
            // 
            // gb_KeyModifiers
            // 
            this.gb_KeyModifiers.Controls.Add(this.chb_shiftKeyModifier);
            this.gb_KeyModifiers.Controls.Add(this.chb_ctrlKeyModifier);
            this.gb_KeyModifiers.Controls.Add(this.chb_altKeyModifier);
            this.gb_KeyModifiers.Location = new System.Drawing.Point(10, 47);
            this.gb_KeyModifiers.Name = "gb_KeyModifiers";
            this.gb_KeyModifiers.Size = new System.Drawing.Size(310, 48);
            this.gb_KeyModifiers.TabIndex = 2;
            this.gb_KeyModifiers.TabStop = false;
            this.gb_KeyModifiers.Text = "Use Key Modifires";
            // 
            // chb_shiftKeyModifier
            // 
            this.chb_shiftKeyModifier.AutoSize = true;
            this.chb_shiftKeyModifier.Location = new System.Drawing.Point(98, 25);
            this.chb_shiftKeyModifier.Name = "chb_shiftKeyModifier";
            this.chb_shiftKeyModifier.Size = new System.Drawing.Size(47, 17);
            this.chb_shiftKeyModifier.TabIndex = 2;
            this.chb_shiftKeyModifier.Text = "Shift";
            this.chb_shiftKeyModifier.UseVisualStyleBackColor = true;
            // 
            // chb_ctrlKeyModifier
            // 
            this.chb_ctrlKeyModifier.AutoSize = true;
            this.chb_ctrlKeyModifier.Location = new System.Drawing.Point(51, 25);
            this.chb_ctrlKeyModifier.Name = "chb_ctrlKeyModifier";
            this.chb_ctrlKeyModifier.Size = new System.Drawing.Size(41, 17);
            this.chb_ctrlKeyModifier.TabIndex = 1;
            this.chb_ctrlKeyModifier.Text = "Ctrl";
            this.chb_ctrlKeyModifier.UseVisualStyleBackColor = true;
            // 
            // chb_altKeyModifier
            // 
            this.chb_altKeyModifier.AutoSize = true;
            this.chb_altKeyModifier.Location = new System.Drawing.Point(7, 25);
            this.chb_altKeyModifier.Name = "chb_altKeyModifier";
            this.chb_altKeyModifier.Size = new System.Drawing.Size(38, 17);
            this.chb_altKeyModifier.TabIndex = 0;
            this.chb_altKeyModifier.Text = "Alt";
            this.chb_altKeyModifier.UseVisualStyleBackColor = true;
            // 
            // lbl_keyToPress
            // 
            this.lbl_keyToPress.AutoSize = true;
            this.lbl_keyToPress.Location = new System.Drawing.Point(7, 27);
            this.lbl_keyToPress.Name = "lbl_keyToPress";
            this.lbl_keyToPress.Size = new System.Drawing.Size(25, 13);
            this.lbl_keyToPress.TabIndex = 1;
            this.lbl_keyToPress.Text = "Key";
            // 
            // cb_keyToPress
            // 
            this.cb_keyToPress.BackColor = System.Drawing.SystemColors.Window;
            this.cb_keyToPress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keyToPress.FormattingEnabled = true;
            this.cb_keyToPress.Location = new System.Drawing.Point(38, 20);
            this.cb_keyToPress.Name = "cb_keyToPress";
            this.cb_keyToPress.Size = new System.Drawing.Size(282, 21);
            this.cb_keyToPress.TabIndex = 0;
            // 
            // gb_PressOptions
            // 
            this.gb_PressOptions.Controls.Add(this.cb_timeUnits);
            this.gb_PressOptions.Controls.Add(this.nud_delayTime);
            this.gb_PressOptions.Controls.Add(this.lbl_delayTime);
            this.gb_PressOptions.Controls.Add(this.rb_delay);
            this.gb_PressOptions.Controls.Add(this.rb_continuously);
            this.gb_PressOptions.Location = new System.Drawing.Point(12, 177);
            this.gb_PressOptions.Name = "gb_PressOptions";
            this.gb_PressOptions.Size = new System.Drawing.Size(326, 93);
            this.gb_PressOptions.TabIndex = 3;
            this.gb_PressOptions.TabStop = false;
            this.gb_PressOptions.Text = "Press Options";
            // 
            // cb_timeUnits
            // 
            this.cb_timeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timeUnits.FormattingEnabled = true;
            this.cb_timeUnits.Items.AddRange(new object[] {
            "ms",
            "s"});
            this.cb_timeUnits.Location = new System.Drawing.Point(240, 65);
            this.cb_timeUnits.Name = "cb_timeUnits";
            this.cb_timeUnits.Size = new System.Drawing.Size(80, 21);
            this.cb_timeUnits.TabIndex = 4;
            // 
            // nud_delayTime
            // 
            this.nud_delayTime.Location = new System.Drawing.Point(73, 66);
            this.nud_delayTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_delayTime.Name = "nud_delayTime";
            this.nud_delayTime.Size = new System.Drawing.Size(161, 20);
            this.nud_delayTime.TabIndex = 3;
            this.nud_delayTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbl_delayTime
            // 
            this.lbl_delayTime.AutoSize = true;
            this.lbl_delayTime.Location = new System.Drawing.Point(6, 68);
            this.lbl_delayTime.Name = "lbl_delayTime";
            this.lbl_delayTime.Size = new System.Drawing.Size(63, 13);
            this.lbl_delayTime.TabIndex = 2;
            this.lbl_delayTime.Text = "Delay Time:";
            // 
            // rb_delay
            // 
            this.rb_delay.AutoSize = true;
            this.rb_delay.Checked = true;
            this.rb_delay.Location = new System.Drawing.Point(7, 43);
            this.rb_delay.Name = "rb_delay";
            this.rb_delay.Size = new System.Drawing.Size(270, 17);
            this.rb_delay.TabIndex = 1;
            this.rb_delay.TabStop = true;
            this.rb_delay.Text = "Delay a Fixed Time Between Two Key Press Events";
            this.rb_delay.UseVisualStyleBackColor = true;
            // 
            // rb_continuously
            // 
            this.rb_continuously.AutoSize = true;
            this.rb_continuously.Location = new System.Drawing.Point(7, 20);
            this.rb_continuously.Name = "rb_continuously";
            this.rb_continuously.Size = new System.Drawing.Size(149, 17);
            this.rb_continuously.TabIndex = 0;
            this.rb_continuously.Text = "Hold the Key Continuously";
            this.rb_continuously.UseVisualStyleBackColor = true;
            // 
            // timer_KeyPressing
            // 
            this.timer_KeyPressing.Tick += new System.EventHandler(this.timer_KeyPressing_Tick);
            // 
            // frm_kap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 282);
            this.Controls.Add(this.gb_PressOptions);
            this.Controls.Add(this.gb_keyToPress);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_kap";
            this.ShowIcon = false;
            this.Text = "Keyboard autopresser";
            this.Load += new System.EventHandler(this.frm_kap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_kap_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_kap_KeyPress);
            this.gb_keyToPress.ResumeLayout(false);
            this.gb_keyToPress.PerformLayout();
            this.gb_KeyModifiers.ResumeLayout(false);
            this.gb_KeyModifiers.PerformLayout();
            this.gb_PressOptions.ResumeLayout(false);
            this.gb_PressOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delayTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox gb_keyToPress;
        private System.Windows.Forms.GroupBox gb_KeyModifiers;
        private System.Windows.Forms.CheckBox chb_shiftKeyModifier;
        private System.Windows.Forms.CheckBox chb_ctrlKeyModifier;
        private System.Windows.Forms.CheckBox chb_altKeyModifier;
        private System.Windows.Forms.Label lbl_keyToPress;
        private System.Windows.Forms.ComboBox cb_keyToPress;
        private System.Windows.Forms.GroupBox gb_PressOptions;
        private System.Windows.Forms.ComboBox cb_timeUnits;
        private System.Windows.Forms.NumericUpDown nud_delayTime;
        private System.Windows.Forms.Label lbl_delayTime;
        private System.Windows.Forms.RadioButton rb_delay;
        private System.Windows.Forms.RadioButton rb_continuously;
        private System.Windows.Forms.Timer timer_KeyPressing;
    }
}

