using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentLibrary;
using System.Windows.Forms;


namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        Game game;
        int count = 0;
        public Fifteen()
        {
            InitializeComponent();
            game = new Game();
        }

        private void RefreshButtonField()

        {

            for (int poition = 0; poition < 16; poition++)
            {
                GetButton(poition).Textbutton = game.GetNumber(poition).ToString();
                GetButton(poition).Visible = true;
                if (game.GetNumber(poition).ToString() == "0") GetButton(poition).Visible = false;
                GetButton(poition).Invalidate();

            }

        }

        private NewButton GetButton(int index)
        {
            switch (index)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return button0;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void Fifteen_Load(object sender, EventArgs e)
        {
            GameStart();
        }

        private void GameStart()
        {                        
            game.Start();
            for (int i = 0; i < 300; i++)
            {            
                game.ShiftRandom();
                RefreshButtonField();
                gameTimer1.Start();
                count = 0;
                count1.Text = (count).ToString();
            }
        }


        private void restart_Click(object sender, EventArgs e)
        {       
            
            game.RestoreMoves();
            RefreshButtonField();
            count1.Text = (++count).ToString();
        }

        private void Fifteen_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.Z))
                restart_Click(sender, e);

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((NewButton)sender).Tag);
            game.SaveHistory(position);
            game.Shift(position);
            RefreshButtonField();
            count1.Text = (++count).ToString();
            if (game.Check())
            {
                gameTimer1.Stop();
                MessageBox.Show("Молодцы! Вы смогли! Время: " + gameTimer1.Text);
                GameStart();
            }
        }
    }
}
