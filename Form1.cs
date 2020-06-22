using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Пятнашки;

namespace Пятнашки_Нэтблэттринашки
{
    public partial class Form1 : Form
    {
        Pyatnaska game;
        public Form1()
        {
            InitializeComponent();
            game = new Pyatnaska(4);
        }

        private void Pyat0_Click(object sender, EventArgs e)
        {
            int Position = Convert.ToInt16(((Button)sender).Tag);
            button(Position).Text = Position.ToString();
            game.Peremeshenie(Position);
            refresh();
            if(game.check_numbers())
            {
                MessageBox.Show("Нвйс мувы мэн");
                Game_start();
            }


        }
        private Button button (int Position)
        {
            switch (Position)
            {
                case 0: return Knopka0;
                case 1: return Knopka1;
                case 2: return Knopka2;
                case 3: return Knopka3;
                case 4: return Knopka4;
                case 5: return Knopka5;
                case 6: return Knopka6;
                case 7: return Knopka7;
                case 8: return Knopka8;
                case 9: return Knopka9;
                case 10: return Knopka10;
                case 11: return Knopka11;
                case 12: return Knopka12;
                case 13: return Knopka13;
                case 14: return Knopka14;
                case 15: return Knopka15;
               
                default: return null;

            }

        }
        private void Game_start()
        {
            game.start();
            for(int s=0;s<100;s++)
            {
                game.RandometoLife();
            }
            refresh();


        }

        private void Start_Click(object sender, EventArgs e)
        {
            Game_start();


        }
       
        private void refresh()
        {
            for (int position = 0; position < 16; position++)
            {
                int Kek = game.getnumber(position);
                button(position).Text = Kek.ToString();
                button(position).Visible = (Kek > 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game_start();

        }
    }
}
