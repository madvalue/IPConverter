using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPConverter {
    public partial class main : Form {
        public main() {
            InitializeComponent();
        }

        // Konwertowanie z decymalnego na binarny
        private void button_dectobin_Click(object sender, EventArgs e) {
            if (input_bindec.Text.Length > 32) {
                MessageBox.Show("Podana liczba jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                var result = Convert.ToString(Convert.ToInt32(input_bindec.Text), 2);
                label_bindec_result.Text = result;
            } catch {
                MessageBox.Show("Wpisany ciag musi być liczbą w formacie decymalnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Konwertowanie z binarnergo na decymalny
        private void button_bintodec_Click(object sender, EventArgs e) {
            if (input_bindec.Text.Length > 32) {
                MessageBox.Show("Podana liczba jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                int result = Convert.ToInt32(input_bindec.Text, 2);
                label_bindec_result.Text = result.ToString();
            } catch {
                MessageBox.Show("Wpisany ciąg musi być liczbą w formacie binarnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Konwertowanie z decymalnego na hexadecymalny
        private void button_dectohex_Click(object sender, EventArgs e) {
            if (input_hexdec.Text.Length > 32) {
                MessageBox.Show("Podana liczba jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                int request = Convert.ToInt32(input_hexdec.Text);
                string result = request.ToString("X");
                label_hexdec_result.Text = result;
            } catch {
                MessageBox.Show("Wpisany ciag musi być liczbą w formacie decymalnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Konwerowanie z hexadecymalnego na decymalny
        private void button_hextodec_Click(object sender, EventArgs e)  {
            if (input_hexdec.Text.Length > 32)  {
                MessageBox.Show("Podana liczba jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                int result = int.Parse(input_hexdec.Text, System.Globalization.NumberStyles.HexNumber);
                label_hexdec_result.Text = result.ToString();
            } catch { 
                MessageBox.Show("Wpisany ciag musi być liczbą w formacie hexadecymalnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Konwertowanie IP z decymalnego na binarny
        private void button_ip_dectobin_Click(object sender, EventArgs e) {
            if (input_oktet1.Text.Length > 32 || input_oktet2.Text.Length > 32 || input_oktet3.Text.Length > 32 || input_oktet4.Text.Length > 32) {
                MessageBox.Show("Wartość przynajmniej jednego z oktetów jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                string result_oktet1 = Convert.ToString(Convert.ToInt32(input_oktet1.Text), 2);
                string result_oktet2 = Convert.ToString(Convert.ToInt32(input_oktet2.Text), 2);
                string result_oktet3 = Convert.ToString(Convert.ToInt32(input_oktet3.Text), 2);
                string result_oktet4 = Convert.ToString(Convert.ToInt32(input_oktet4.Text), 2);

                label_ip_result.Text = result_oktet1 + "." + result_oktet2 + "." + result_oktet3 + "." + result_oktet4;
            } catch {
                MessageBox.Show("Wartości wszystkich oktetów muszą być liczbami w formacie decymalnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Konwertowanie IP z binarnego na binarny
        private void button_ip_bintodec_Click(object sender, EventArgs e) {
            if (input_oktet1.Text.Length > 32 || input_oktet2.Text.Length > 32 || input_oktet3.Text.Length > 32 || input_oktet4.Text.Length > 32) {
                MessageBox.Show("Wartość przynajmniej jednego z oktetów jest poza maksymalnym zasięgiem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                int result_oktet1 = Convert.ToInt32(input_oktet1.Text, 2);
                int result_oktet2 = Convert.ToInt32(input_oktet2.Text, 2);
                int result_oktet3 = Convert.ToInt32(input_oktet3.Text, 2);
                int result_oktet4 = Convert.ToInt32(input_oktet4.Text, 2);

                label_ip_result.Text = result_oktet1 + "." + result_oktet2 + "." + result_oktet3 + "." + result_oktet4;
            } catch {
                MessageBox.Show("Wartości wszystkich oktetów muszą być liczbami w formacie binarnym", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Przycisk resetu
        private void button_reset_Click(object sender, EventArgs e) {
            input_bindec.Text = "";
            input_hexdec.Text = "";
            input_oktet1.Text = "";
            input_oktet2.Text = "";
            input_oktet3.Text = "";
            input_oktet4.Text = "";
        }

        // Autorzy
        private void button_credits_Click(object sender, EventArgs e) {
            Credits credits = new Credits();
            credits.Show();
        }
    }
}
