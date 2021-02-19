using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_autopresser
{
    public partial class frm_kap : Form
    {
        private Dictionary<string, Keys> keysDictionary = new Dictionary<string, Keys>();
        private Keys keyToPress = new Keys();
        public frm_kap()
        {
            InitializeComponent();
            var actHook = new UserActivityHook();
            actHook.KeyDown += this.frm_kap_KeyDown;
        }

        private void frm_kap_Load(object sender, EventArgs e)
        {
            Keys[] keysArray = { Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.A };
            cb_timeUnits.Text = cb_timeUnits.Items[0].ToString();
            
            foreach (Keys item in keysArray)
            {
                cb_keyToPress.Items.Add("Key name: " + item.ToString());
                keysDictionary.Add("Key name: " + item.ToString(), item);
            }
            cb_keyToPress.Text = cb_keyToPress.Items[0].ToString();
            cb_keyToPress.FlatStyle = FlatStyle.Popup;
            cb_timeUnits.FlatStyle = FlatStyle.Popup;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_timeUnits.Text == "ms")
            {
                timer_KeyPressing.Interval = (int)nud_delayTime.Value;
            }
            else
            {
                timer_KeyPressing.Interval = (int)nud_delayTime.Value * 1000;
            }
            keyToPress = keysDictionary[cb_keyToPress.Text];
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            timer_KeyPressing.Start();
        }

        private void timer_KeyPressing_Tick(object sender, EventArgs e)
        {
            SendKeys.Send((chb_altKeyModifier.Checked ? "%" : "") + (chb_ctrlKeyModifier.Checked ? "^" : "") + (chb_shiftKeyModifier.Checked ? "+" : "") + ((char)keyToPress).ToString());
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            timer_KeyPressing.Stop();
        }

        private void frm_kap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frm_kap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F1)
            {
                btn_start.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.F2)
            {
                btn_stop.PerformClick();
            }
        }
    }
}
