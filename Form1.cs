using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_VH
{
    public partial class GameForm : Form
    {
        public static int[,] TileTable = new int[4, 4];
        public void TileRefresh()
        {
            Num11.Text = TileTable[0, 0].ToString();
            Num12.Text = TileTable[0, 1].ToString();
            Num13.Text = TileTable[0, 2].ToString();
            Num14.Text = TileTable[0, 3].ToString();

            Num21.Text = TileTable[1, 0].ToString();
            Num22.Text = TileTable[1, 1].ToString();
            Num23.Text = TileTable[1, 2].ToString();
            Num24.Text = TileTable[1, 3].ToString();

            Num31.Text = TileTable[2, 0].ToString();
            Num32.Text = TileTable[2, 1].ToString();
            Num33.Text = TileTable[2, 2].ToString();
            Num34.Text = TileTable[2, 3].ToString();

            Num41.Text = TileTable[3, 0].ToString();
            Num42.Text = TileTable[3, 1].ToString();
            Num43.Text = TileTable[3, 2].ToString();
            Num44.Text = TileTable[3, 3].ToString();
        }
        private bool FullRowCheck(int i)
        {
            for (int j = 1; j < 4; ++j)
                if (TileTable[i, j] == 0)
                    return false;
            return true;
        }
        private bool FullTableCheck()
        {
            for (int i = 0; i < 4; ++i)
                if (FullRowCheck(i) == false) return false;
            return true;
        }
        private void SquareGen()
        {
            int[] v = {0};
            int i, j;
            Random rand = new Random();
            do
            {
                i = rand.Next(0, 4);
            } while (FullRowCheck(i) == true);

            //generate random j coordinate on empty position
            do
            {
                j = rand.Next(0, 4);
            } while (TileTable[i, j] != 0);
            TileTable[i, j] = 2;
        }

        public GameForm()
        {
            InitializeComponent();
        }

        private void arena_Enter(object sender, EventArgs e)
        {

        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (FullTableCheck() == false)
                SquareGen();
            TileRefresh();

        }
    }
}
