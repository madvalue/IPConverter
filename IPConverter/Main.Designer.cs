namespace IPConverter
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.group_bindec = new System.Windows.Forms.GroupBox();
            this.group_bindec_result = new System.Windows.Forms.GroupBox();
            this.label_bindec_result = new System.Windows.Forms.Label();
            this.button_bintodec = new System.Windows.Forms.Button();
            this.button_dectobin = new System.Windows.Forms.Button();
            this.input_bindec = new System.Windows.Forms.TextBox();
            this.group_hexdec = new System.Windows.Forms.GroupBox();
            this.group_hexdec_result = new System.Windows.Forms.GroupBox();
            this.label_hexdec_result = new System.Windows.Forms.Label();
            this.button_hextodec = new System.Windows.Forms.Button();
            this.button_dectohex = new System.Windows.Forms.Button();
            this.input_hexdec = new System.Windows.Forms.TextBox();
            this.group_ip = new System.Windows.Forms.GroupBox();
            this.button_ip_dectobin = new System.Windows.Forms.Button();
            this.button_ip_bintodec = new System.Windows.Forms.Button();
            this.label_dot3 = new System.Windows.Forms.Label();
            this.label_dot2 = new System.Windows.Forms.Label();
            this.label_dot1 = new System.Windows.Forms.Label();
            this.group_ip_result = new System.Windows.Forms.GroupBox();
            this.label_ip_result = new System.Windows.Forms.Label();
            this.input_oktet4 = new System.Windows.Forms.TextBox();
            this.input_oktet3 = new System.Windows.Forms.TextBox();
            this.input_oktet2 = new System.Windows.Forms.TextBox();
            this.input_oktet1 = new System.Windows.Forms.TextBox();
            this.button_credits = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.group_bindec.SuspendLayout();
            this.group_bindec_result.SuspendLayout();
            this.group_hexdec.SuspendLayout();
            this.group_hexdec_result.SuspendLayout();
            this.group_ip.SuspendLayout();
            this.group_ip_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_bindec
            // 
            this.group_bindec.Controls.Add(this.group_bindec_result);
            this.group_bindec.Controls.Add(this.button_bintodec);
            this.group_bindec.Controls.Add(this.button_dectobin);
            this.group_bindec.Controls.Add(this.input_bindec);
            this.group_bindec.Location = new System.Drawing.Point(575, 13);
            this.group_bindec.Name = "group_bindec";
            this.group_bindec.Size = new System.Drawing.Size(213, 203);
            this.group_bindec.TabIndex = 0;
            this.group_bindec.TabStop = false;
            this.group_bindec.Text = "Binarny - decymalny";
            // 
            // group_bindec_result
            // 
            this.group_bindec_result.Controls.Add(this.label_bindec_result);
            this.group_bindec_result.Location = new System.Drawing.Point(23, 127);
            this.group_bindec_result.Name = "group_bindec_result";
            this.group_bindec_result.Size = new System.Drawing.Size(172, 53);
            this.group_bindec_result.TabIndex = 3;
            this.group_bindec_result.TabStop = false;
            this.group_bindec_result.Text = "Wynik";
            // 
            // label_bindec_result
            // 
            this.label_bindec_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bindec_result.Location = new System.Drawing.Point(6, 16);
            this.label_bindec_result.Name = "label_bindec_result";
            this.label_bindec_result.Size = new System.Drawing.Size(160, 26);
            this.label_bindec_result.TabIndex = 0;
            this.label_bindec_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_bintodec
            // 
            this.button_bintodec.Location = new System.Drawing.Point(23, 85);
            this.button_bintodec.Name = "button_bintodec";
            this.button_bintodec.Size = new System.Drawing.Size(172, 23);
            this.button_bintodec.TabIndex = 2;
            this.button_bintodec.Text = "Na decymalny";
            this.button_bintodec.UseVisualStyleBackColor = true;
            this.button_bintodec.Click += new System.EventHandler(this.button_bintodec_Click);
            // 
            // button_dectobin
            // 
            this.button_dectobin.Location = new System.Drawing.Point(23, 55);
            this.button_dectobin.Name = "button_dectobin";
            this.button_dectobin.Size = new System.Drawing.Size(172, 23);
            this.button_dectobin.TabIndex = 1;
            this.button_dectobin.Text = "Na binarny";
            this.button_dectobin.UseVisualStyleBackColor = true;
            this.button_dectobin.Click += new System.EventHandler(this.button_dectobin_Click);
            // 
            // input_bindec
            // 
            this.input_bindec.Location = new System.Drawing.Point(23, 28);
            this.input_bindec.Name = "input_bindec";
            this.input_bindec.Size = new System.Drawing.Size(172, 20);
            this.input_bindec.TabIndex = 0;
            // 
            // group_hexdec
            // 
            this.group_hexdec.Controls.Add(this.group_hexdec_result);
            this.group_hexdec.Controls.Add(this.button_hextodec);
            this.group_hexdec.Controls.Add(this.button_dectohex);
            this.group_hexdec.Controls.Add(this.input_hexdec);
            this.group_hexdec.Location = new System.Drawing.Point(575, 232);
            this.group_hexdec.Name = "group_hexdec";
            this.group_hexdec.Size = new System.Drawing.Size(213, 206);
            this.group_hexdec.TabIndex = 1;
            this.group_hexdec.TabStop = false;
            this.group_hexdec.Text = "Hexadecymalny - decymalny";
            // 
            // group_hexdec_result
            // 
            this.group_hexdec_result.Controls.Add(this.label_hexdec_result);
            this.group_hexdec_result.Location = new System.Drawing.Point(23, 131);
            this.group_hexdec_result.Name = "group_hexdec_result";
            this.group_hexdec_result.Size = new System.Drawing.Size(172, 50);
            this.group_hexdec_result.TabIndex = 3;
            this.group_hexdec_result.TabStop = false;
            this.group_hexdec_result.Text = "Wynik";
            // 
            // label_hexdec_result
            // 
            this.label_hexdec_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hexdec_result.Location = new System.Drawing.Point(6, 16);
            this.label_hexdec_result.Name = "label_hexdec_result";
            this.label_hexdec_result.Size = new System.Drawing.Size(160, 23);
            this.label_hexdec_result.TabIndex = 0;
            this.label_hexdec_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_hextodec
            // 
            this.button_hextodec.Location = new System.Drawing.Point(23, 89);
            this.button_hextodec.Name = "button_hextodec";
            this.button_hextodec.Size = new System.Drawing.Size(172, 23);
            this.button_hextodec.TabIndex = 2;
            this.button_hextodec.Text = "Na decymalny";
            this.button_hextodec.UseVisualStyleBackColor = true;
            this.button_hextodec.Click += new System.EventHandler(this.button_hextodec_Click);
            // 
            // button_dectohex
            // 
            this.button_dectohex.Location = new System.Drawing.Point(23, 59);
            this.button_dectohex.Name = "button_dectohex";
            this.button_dectohex.Size = new System.Drawing.Size(172, 23);
            this.button_dectohex.TabIndex = 1;
            this.button_dectohex.Text = "Na hexadecymalny";
            this.button_dectohex.UseVisualStyleBackColor = true;
            this.button_dectohex.Click += new System.EventHandler(this.button_dectohex_Click);
            // 
            // input_hexdec
            // 
            this.input_hexdec.Location = new System.Drawing.Point(23, 32);
            this.input_hexdec.Name = "input_hexdec";
            this.input_hexdec.Size = new System.Drawing.Size(172, 20);
            this.input_hexdec.TabIndex = 0;
            // 
            // group_ip
            // 
            this.group_ip.Controls.Add(this.button_ip_dectobin);
            this.group_ip.Controls.Add(this.button_ip_bintodec);
            this.group_ip.Controls.Add(this.label_dot3);
            this.group_ip.Controls.Add(this.label_dot2);
            this.group_ip.Controls.Add(this.label_dot1);
            this.group_ip.Controls.Add(this.group_ip_result);
            this.group_ip.Controls.Add(this.input_oktet4);
            this.group_ip.Controls.Add(this.input_oktet3);
            this.group_ip.Controls.Add(this.input_oktet2);
            this.group_ip.Controls.Add(this.input_oktet1);
            this.group_ip.Location = new System.Drawing.Point(13, 13);
            this.group_ip.Name = "group_ip";
            this.group_ip.Size = new System.Drawing.Size(537, 203);
            this.group_ip.TabIndex = 2;
            this.group_ip.TabStop = false;
            this.group_ip.Text = "Adres IP";
            // 
            // button_ip_dectobin
            // 
            this.button_ip_dectobin.Location = new System.Drawing.Point(366, 153);
            this.button_ip_dectobin.Name = "button_ip_dectobin";
            this.button_ip_dectobin.Size = new System.Drawing.Size(105, 37);
            this.button_ip_dectobin.TabIndex = 9;
            this.button_ip_dectobin.Text = "Na binarny";
            this.button_ip_dectobin.UseVisualStyleBackColor = true;
            this.button_ip_dectobin.Click += new System.EventHandler(this.button_ip_dectobin_Click);
            // 
            // button_ip_bintodec
            // 
            this.button_ip_bintodec.Location = new System.Drawing.Point(255, 153);
            this.button_ip_bintodec.Name = "button_ip_bintodec";
            this.button_ip_bintodec.Size = new System.Drawing.Size(105, 37);
            this.button_ip_bintodec.TabIndex = 8;
            this.button_ip_bintodec.Text = "Na decymalny";
            this.button_ip_bintodec.UseVisualStyleBackColor = true;
            this.button_ip_bintodec.Click += new System.EventHandler(this.button_ip_bintodec_Click);
            // 
            // label_dot3
            // 
            this.label_dot3.AutoSize = true;
            this.label_dot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dot3.Location = new System.Drawing.Point(361, 23);
            this.label_dot3.Name = "label_dot3";
            this.label_dot3.Size = new System.Drawing.Size(19, 25);
            this.label_dot3.TabIndex = 7;
            this.label_dot3.Text = ".";
            // 
            // label_dot2
            // 
            this.label_dot2.AutoSize = true;
            this.label_dot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dot2.Location = new System.Drawing.Point(248, 23);
            this.label_dot2.Name = "label_dot2";
            this.label_dot2.Size = new System.Drawing.Size(19, 25);
            this.label_dot2.TabIndex = 6;
            this.label_dot2.Text = ".";
            // 
            // label_dot1
            // 
            this.label_dot1.AutoSize = true;
            this.label_dot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dot1.Location = new System.Drawing.Point(133, 23);
            this.label_dot1.Name = "label_dot1";
            this.label_dot1.Size = new System.Drawing.Size(19, 25);
            this.label_dot1.TabIndex = 5;
            this.label_dot1.Text = ".";
            // 
            // group_ip_result
            // 
            this.group_ip_result.Controls.Add(this.label_ip_result);
            this.group_ip_result.Location = new System.Drawing.Point(42, 69);
            this.group_ip_result.Name = "group_ip_result";
            this.group_ip_result.Size = new System.Drawing.Size(429, 78);
            this.group_ip_result.TabIndex = 4;
            this.group_ip_result.TabStop = false;
            this.group_ip_result.Text = "Wynik";
            // 
            // label_ip_result
            // 
            this.label_ip_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ip_result.Location = new System.Drawing.Point(1, 13);
            this.label_ip_result.Name = "label_ip_result";
            this.label_ip_result.Size = new System.Drawing.Size(422, 62);
            this.label_ip_result.TabIndex = 0;
            this.label_ip_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_oktet4
            // 
            this.input_oktet4.Location = new System.Drawing.Point(386, 28);
            this.input_oktet4.Name = "input_oktet4";
            this.input_oktet4.Size = new System.Drawing.Size(85, 20);
            this.input_oktet4.TabIndex = 3;
            // 
            // input_oktet3
            // 
            this.input_oktet3.Location = new System.Drawing.Point(273, 28);
            this.input_oktet3.Name = "input_oktet3";
            this.input_oktet3.Size = new System.Drawing.Size(85, 20);
            this.input_oktet3.TabIndex = 2;
            // 
            // input_oktet2
            // 
            this.input_oktet2.Location = new System.Drawing.Point(155, 28);
            this.input_oktet2.Name = "input_oktet2";
            this.input_oktet2.Size = new System.Drawing.Size(85, 20);
            this.input_oktet2.TabIndex = 1;
            // 
            // input_oktet1
            // 
            this.input_oktet1.Location = new System.Drawing.Point(42, 28);
            this.input_oktet1.Name = "input_oktet1";
            this.input_oktet1.Size = new System.Drawing.Size(85, 20);
            this.input_oktet1.TabIndex = 0;
            // 
            // button_credits
            // 
            this.button_credits.Location = new System.Drawing.Point(461, 222);
            this.button_credits.Name = "button_credits";
            this.button_credits.Size = new System.Drawing.Size(89, 30);
            this.button_credits.TabIndex = 3;
            this.button_credits.Text = "Autorzy";
            this.button_credits.UseVisualStyleBackColor = true;
            this.button_credits.Click += new System.EventHandler(this.button_credits_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(367, 222);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(88, 30);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Wyczyść";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_credits);
            this.Controls.Add(this.group_ip);
            this.Controls.Add(this.group_hexdec);
            this.Controls.Add(this.group_bindec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "main";
            this.Text = "IP Converter 0.1a by madvalue";
            this.group_bindec.ResumeLayout(false);
            this.group_bindec.PerformLayout();
            this.group_bindec_result.ResumeLayout(false);
            this.group_hexdec.ResumeLayout(false);
            this.group_hexdec.PerformLayout();
            this.group_hexdec_result.ResumeLayout(false);
            this.group_ip.ResumeLayout(false);
            this.group_ip.PerformLayout();
            this.group_ip_result.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_bindec;
        private System.Windows.Forms.Button button_dectobin;
        private System.Windows.Forms.TextBox input_bindec;
        private System.Windows.Forms.Button button_bintodec;
        private System.Windows.Forms.GroupBox group_bindec_result;
        private System.Windows.Forms.Label label_bindec_result;
        private System.Windows.Forms.GroupBox group_hexdec;
        private System.Windows.Forms.TextBox input_hexdec;
        private System.Windows.Forms.Button button_dectohex;
        private System.Windows.Forms.Button button_hextodec;
        private System.Windows.Forms.GroupBox group_hexdec_result;
        private System.Windows.Forms.Label label_hexdec_result;
        private System.Windows.Forms.GroupBox group_ip;
        private System.Windows.Forms.Button button_credits;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox input_oktet1;
        private System.Windows.Forms.TextBox input_oktet3;
        private System.Windows.Forms.TextBox input_oktet2;
        private System.Windows.Forms.TextBox input_oktet4;
        private System.Windows.Forms.GroupBox group_ip_result;
        private System.Windows.Forms.Label label_ip_result;
        private System.Windows.Forms.Label label_dot3;
        private System.Windows.Forms.Label label_dot2;
        private System.Windows.Forms.Label label_dot1;
        private System.Windows.Forms.Button button_ip_bintodec;
        private System.Windows.Forms.Button button_ip_dectobin;
    }
}

