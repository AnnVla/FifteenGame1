
namespace FifteenGUI
{
    partial class Fifteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fifteen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.moves = new System.Windows.Forms.ToolStripStatusLabel();
            this.count1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameTimer1 = new ComponentLibrary.GameTimer();
            this.button15 = new ComponentLibrary.NewButton();
            this.button14 = new ComponentLibrary.NewButton();
            this.button13 = new ComponentLibrary.NewButton();
            this.button12 = new ComponentLibrary.NewButton();
            this.button11 = new ComponentLibrary.NewButton();
            this.button10 = new ComponentLibrary.NewButton();
            this.button9 = new ComponentLibrary.NewButton();
            this.button8 = new ComponentLibrary.NewButton();
            this.button7 = new ComponentLibrary.NewButton();
            this.button6 = new ComponentLibrary.NewButton();
            this.button5 = new ComponentLibrary.NewButton();
            this.button4 = new ComponentLibrary.NewButton();
            this.button3 = new ComponentLibrary.NewButton();
            this.button2 = new ComponentLibrary.NewButton();
            this.button1 = new ComponentLibrary.NewButton();
            this.button0 = new ComponentLibrary.NewButton();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.restart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(86, 20);
            this.menu.Text = "Начать игру";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // restart
            // 
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(89, 20);
            this.restart.Text = "Отмена хода";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 368);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.moves,
            this.count1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Количество ходов: ";
            // 
            // moves
            // 
            this.moves.Name = "moves";
            this.moves.Size = new System.Drawing.Size(0, 17);
            // 
            // count1
            // 
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(13, 17);
            this.count1.Text = "0";
            // 
            // gameTimer1
            // 
            this.gameTimer1.Location = new System.Drawing.Point(350, -9);
            this.gameTimer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameTimer1.Name = "gameTimer1";
            this.gameTimer1.Size = new System.Drawing.Size(64, 32);
            this.gameTimer1.TabIndex = 2;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(311, 263);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(101, 83);
            this.button15.TabIndex = 15;
            this.button15.Tag = "15";
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(208, 263);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(99, 83);
            this.button14.TabIndex = 14;
            this.button14.Tag = "14";
            this.button14.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(105, 263);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(99, 83);
            this.button13.TabIndex = 13;
            this.button13.Tag = "13";
            this.button13.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(2, 263);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(99, 83);
            this.button12.TabIndex = 12;
            this.button12.Tag = "12";
            this.button12.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(311, 176);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 83);
            this.button11.TabIndex = 11;
            this.button11.Tag = "11";
            this.button11.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(208, 176);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 83);
            this.button10.TabIndex = 10;
            this.button10.Tag = "10";
            this.button10.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(105, 176);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 83);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(2, 176);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 83);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(311, 89);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 83);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(208, 89);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 83);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(105, 89);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 83);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(2, 89);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 83);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(311, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 83);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(208, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 83);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 83);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(2, 2);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(99, 83);
            this.button0.TabIndex = 0;
            this.button0.Tag = "0";
            this.button0.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // Fifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 392);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameTimer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Fifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Fifteen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentLibrary.GameTimer gameTimer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel moves;
        private System.Windows.Forms.ToolStripStatusLabel count1;
        private System.Windows.Forms.ToolStripMenuItem restart;
        private ComponentLibrary.NewButton button15;
        private ComponentLibrary.NewButton button14;
        private ComponentLibrary.NewButton button13;
        private ComponentLibrary.NewButton button12;
        private ComponentLibrary.NewButton button11;
        private ComponentLibrary.NewButton button10;
        private ComponentLibrary.NewButton button9;
        private ComponentLibrary.NewButton button8;
        private ComponentLibrary.NewButton button7;
        private ComponentLibrary.NewButton button6;
        private ComponentLibrary.NewButton button5;
        private ComponentLibrary.NewButton button4;
        private ComponentLibrary.NewButton button3;
        private ComponentLibrary.NewButton button2;
        private ComponentLibrary.NewButton button1;
        private ComponentLibrary.NewButton button0;
    }
}

