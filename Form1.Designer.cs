namespace StoneScissorsPaper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.label_stat = new System.Windows.Forms.Label();
            this.text_debug = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radio_server = new System.Windows.Forms.RadioButton();
            this.radio_client = new System.Windows.Forms.RadioButton();
            this.button_stone = new System.Windows.Forms.Button();
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(13, 86);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(91, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // label_stat
            // 
            this.label_stat.BackColor = System.Drawing.Color.PapayaWhip;
            this.label_stat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stat.Location = new System.Drawing.Point(12, 112);
            this.label_stat.Name = "label_stat";
            this.label_stat.Size = new System.Drawing.Size(242, 38);
            this.label_stat.TabIndex = 3;
            this.label_stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_debug
            // 
            this.text_debug.BackColor = System.Drawing.SystemColors.Info;
            this.text_debug.Enabled = false;
            this.text_debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_debug.Location = new System.Drawing.Point(12, 169);
            this.text_debug.Multiline = true;
            this.text_debug.Name = "text_debug";
            this.text_debug.Size = new System.Drawing.Size(243, 37);
            this.text_debug.TabIndex = 4;
            this.text_debug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(13, 59);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(91, 20);
            this.textBox_ip.TabIndex = 5;
            this.textBox_ip.Text = "127.0.0.1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // radio_server
            // 
            this.radio_server.AutoSize = true;
            this.radio_server.Checked = true;
            this.radio_server.Location = new System.Drawing.Point(13, 13);
            this.radio_server.Name = "radio_server";
            this.radio_server.Size = new System.Drawing.Size(62, 17);
            this.radio_server.TabIndex = 6;
            this.radio_server.TabStop = true;
            this.radio_server.Text = "Сервер";
            this.radio_server.UseVisualStyleBackColor = true;
            // 
            // radio_client
            // 
            this.radio_client.AutoSize = true;
            this.radio_client.Location = new System.Drawing.Point(13, 36);
            this.radio_client.Name = "radio_client";
            this.radio_client.Size = new System.Drawing.Size(61, 17);
            this.radio_client.TabIndex = 7;
            this.radio_client.Text = "Клиент";
            this.radio_client.UseVisualStyleBackColor = true;
            // 
            // button_stone
            // 
            this.button_stone.Location = new System.Drawing.Point(131, 13);
            this.button_stone.Name = "button_stone";
            this.button_stone.Size = new System.Drawing.Size(124, 23);
            this.button_stone.TabIndex = 8;
            this.button_stone.Text = "Камень";
            this.button_stone.UseVisualStyleBackColor = true;
            this.button_stone.Click += new System.EventHandler(this.Button_stone_Click);
            // 
            // button_scissors
            // 
            this.button_scissors.Location = new System.Drawing.Point(131, 43);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(124, 23);
            this.button_scissors.TabIndex = 9;
            this.button_scissors.Text = "Ножницы";
            this.button_scissors.UseVisualStyleBackColor = true;
            this.button_scissors.Click += new System.EventHandler(this.Button_scissors_Click);
            // 
            // button_paper
            // 
            this.button_paper.Location = new System.Drawing.Point(131, 73);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(124, 23);
            this.button_paper.TabIndex = 10;
            this.button_paper.Text = "Бумага";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.Button_paper_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(264, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.StripStatusLabel.Text = "Статистика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 239);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_scissors);
            this.Controls.Add(this.button_stone);
            this.Controls.Add(this.radio_client);
            this.Controls.Add(this.radio_server);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.text_debug);
            this.Controls.Add(this.label_stat);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "КНБ by SlaY";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_stat;
        private System.Windows.Forms.TextBox text_debug;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radio_server;
        private System.Windows.Forms.RadioButton radio_client;
        private System.Windows.Forms.Button button_stone;
        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
    }
}

