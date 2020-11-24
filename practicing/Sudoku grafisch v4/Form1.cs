using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public static long[,] Feld = new long[10, 10];
        public static long eingabeLongX = 0;
        public static long eingabeLongY = 0;
        public static long ziffer = 0;
        public static long A;
        public static long B;
        public static string[] SudokuBlockedPositions = new string[81];
        public static string SudokuTemplatePath;
        public static Button[] buttonsFelder = new Button[81];

        public Form1()
        {
            InitializeComponent();
            reset();
        }
        private void textBoxSaveFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonsString()
        {
            buttonsFelder[0] = buttonA1;
            buttonsFelder[1] = buttonA2;
            buttonsFelder[2] = buttonA3;
            buttonsFelder[3] = buttonA4;
            buttonsFelder[4] = buttonA5;
            buttonsFelder[5] = buttonA6;
            buttonsFelder[6] = buttonA7;
            buttonsFelder[7] = buttonA8;
            buttonsFelder[8] = buttonA9;
            buttonsFelder[9] = buttonB1;
            buttonsFelder[10] = buttonB2;
            buttonsFelder[11] = buttonB3;
            buttonsFelder[12] = buttonB4;
            buttonsFelder[13] = buttonB5;
            buttonsFelder[14] = buttonB6;
            buttonsFelder[15] = buttonB7;
            buttonsFelder[16] = buttonB8;
            buttonsFelder[17] = buttonB9;
            buttonsFelder[18] = buttonC1;
            buttonsFelder[19] = buttonC2;
            buttonsFelder[20] = buttonC3;
            buttonsFelder[21] = buttonC4;
            buttonsFelder[22] = buttonC5;
            buttonsFelder[23] = buttonC6;
            buttonsFelder[24] = buttonC7;
            buttonsFelder[25] = buttonC8;
            buttonsFelder[26] = buttonC9;
            buttonsFelder[27] = buttonD1;
            buttonsFelder[28] = buttonD2;
            buttonsFelder[29] = buttonD3;
            buttonsFelder[30] = buttonD4;
            buttonsFelder[31] = buttonD5;
            buttonsFelder[32] = buttonD6;
            buttonsFelder[33] = buttonD7;
            buttonsFelder[34] = buttonD8;
            buttonsFelder[35] = buttonD9;
            buttonsFelder[36] = buttonE1;
            buttonsFelder[37] = buttonE2;
            buttonsFelder[38] = buttonE3;
            buttonsFelder[39] = buttonE4;
            buttonsFelder[40] = buttonE5;
            buttonsFelder[41] = buttonE6;
            buttonsFelder[42] = buttonE7;
            buttonsFelder[43] = buttonE8;
            buttonsFelder[44] = buttonE9;
            buttonsFelder[45] = buttonF1;
            buttonsFelder[46] = buttonF2;
            buttonsFelder[47] = buttonF3;
            buttonsFelder[48] = buttonF4;
            buttonsFelder[49] = buttonF5;
            buttonsFelder[50] = buttonF6;
            buttonsFelder[51] = buttonF7;
            buttonsFelder[52] = buttonF8;
            buttonsFelder[53] = buttonF9;
            buttonsFelder[54] = buttonG1;
            buttonsFelder[55] = buttonG2;
            buttonsFelder[56] = buttonG3;
            buttonsFelder[57] = buttonG4;
            buttonsFelder[58] = buttonG5;
            buttonsFelder[59] = buttonG6;
            buttonsFelder[60] = buttonG7;
            buttonsFelder[61] = buttonG8;
            buttonsFelder[62] = buttonG9;
            buttonsFelder[63] = buttonH1;
            buttonsFelder[64] = buttonH2;
            buttonsFelder[65] = buttonH3;
            buttonsFelder[66] = buttonH4;
            buttonsFelder[67] = buttonH5;
            buttonsFelder[68] = buttonH6;
            buttonsFelder[69] = buttonH7;
            buttonsFelder[70] = buttonH8;
            buttonsFelder[71] = buttonH9;
            buttonsFelder[72] = buttonI1;
            buttonsFelder[73] = buttonI2;
            buttonsFelder[74] = buttonI3;
            buttonsFelder[75] = buttonI4;
            buttonsFelder[76] = buttonI5;
            buttonsFelder[77] = buttonI6;
            buttonsFelder[78] = buttonI7;
            buttonsFelder[79] = buttonI8;
            buttonsFelder[80] = buttonI9;
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("11"))
            {
                eingabeLongX = 1;
                eingabeLongY = 1;
            }

            ResetAllColors();
            buttonA1.BackColor = Color.LightGreen;
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("12"))
            {
                eingabeLongX = 1;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonA2.BackColor = Color.LightGreen;
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("13"))
            {
                eingabeLongX = 1;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonA3.BackColor = Color.LightGreen;
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("14"))
            {
                eingabeLongX = 1;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonA4.BackColor = Color.LightGreen;
        }

        private void buttonA5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("15"))
            {
                eingabeLongX = 1;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonA5.BackColor = Color.LightGreen;
        }

        private void buttonA6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("16"))
            {
                eingabeLongX = 1;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonA6.BackColor = Color.LightGreen;
        }

        private void buttonA7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("17"))
            {
                eingabeLongX = 1;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonA7.BackColor = Color.LightGreen;
        }

        private void buttonA8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("18"))
            {
                eingabeLongX = 1;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonA8.BackColor = Color.LightGreen;
        }

        private void buttonA9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("19"))
            {
                eingabeLongX = 1;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonA9.BackColor = Color.LightGreen;
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("21"))
            {
                eingabeLongX = 2;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonB1.BackColor = Color.LightGreen;
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("22"))
            {
                eingabeLongX = 2;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonB2.BackColor = Color.LightGreen;
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("23"))
            {
                eingabeLongX = 2;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonB3.BackColor = Color.LightGreen;
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("24"))
            {
                eingabeLongX = 2;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonB4.BackColor = Color.LightGreen;
        }

        private void buttonB5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("25"))
            {
                eingabeLongX = 2;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonB5.BackColor = Color.LightGreen;
        }

        private void buttonB6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("26"))
            {
                eingabeLongX = 2;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonB6.BackColor = Color.LightGreen;
        }

        private void buttonB7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("27"))
            {
                eingabeLongX = 2;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonB7.BackColor = Color.LightGreen;
        }

        private void buttonB8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("28"))
            {
                eingabeLongX = 2;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonB8.BackColor = Color.LightGreen;
        }

        private void buttonB9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("29"))
            {
                eingabeLongX = 2;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonB9.BackColor = Color.LightGreen;
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("31"))
            {
                eingabeLongX = 3;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonC1.BackColor = Color.LightGreen;
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("32"))
            {
                eingabeLongX = 3;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonC2.BackColor = Color.LightGreen;
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("33"))
            {
                eingabeLongX = 3;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonC3.BackColor = Color.LightGreen;
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("34"))
            {
                eingabeLongX = 3;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonC4.BackColor = Color.LightGreen;
        }

        private void buttonC5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("35"))
            {
                eingabeLongX = 3;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonC5.BackColor = Color.LightGreen;
        }

        private void buttonC6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("36"))
            {
                eingabeLongX = 3;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonC6.BackColor = Color.LightGreen;
        }

        private void buttonC7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("37"))
            {
                eingabeLongX = 3;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonC7.BackColor = Color.LightGreen;
        }

        private void buttonC8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("38"))
            {
                eingabeLongX = 3;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonC8.BackColor = Color.LightGreen;
        }

        private void buttonC9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("39"))
            {
                eingabeLongX = 3;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonC9.BackColor = Color.LightGreen;
        }

        private void buttonD1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("41"))
            {
                eingabeLongX = 4;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonD1.BackColor = Color.LightGreen;
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("42"))
            {
                eingabeLongX = 4;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonD2.BackColor = Color.LightGreen;
        }

        private void buttonD3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("43"))
            {
                eingabeLongX = 4;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonD3.BackColor = Color.LightGreen;
        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("44"))
            {
                eingabeLongX = 4;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonD4.BackColor = Color.LightGreen;
        }

        private void buttonD5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("45"))
            {
                eingabeLongX = 4;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonD5.BackColor = Color.LightGreen;
        }

        private void buttonD6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("46"))
            {
                eingabeLongX = 4;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonD6.BackColor = Color.LightGreen;
        }

        private void buttonD7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("47"))
            {
                eingabeLongX = 4;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonD7.BackColor = Color.LightGreen;
        }

        private void buttonD8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("48"))
            {
                eingabeLongX = 4;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonD8.BackColor = Color.LightGreen;
        }

        private void buttonD9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("49"))
            {
                eingabeLongX = 4;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonD9.BackColor = Color.LightGreen;
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("51"))
            {
                eingabeLongX = 5;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonE1.BackColor = Color.LightGreen;
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("52"))
            {
                eingabeLongX = 5;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonE2.BackColor = Color.LightGreen;
        }

        private void buttonE3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("53"))
            {
                eingabeLongX = 5;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonE3.BackColor = Color.LightGreen;
        }

        private void buttonE4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("54"))
            {
                eingabeLongX = 5;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonE4.BackColor = Color.LightGreen;
        }

        private void buttonE5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("55"))
            {
                eingabeLongX = 5;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonE5.BackColor = Color.LightGreen;
        }

        private void buttonE6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("56"))
            {
                eingabeLongX = 5;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonE6.BackColor = Color.LightGreen;
        }

        private void buttonE7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("57"))
            {
                eingabeLongX = 5;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonE7.BackColor = Color.LightGreen;
        }

        private void buttonE8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("58"))
            {
                eingabeLongX = 5;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonE8.BackColor = Color.LightGreen;
        }

        private void buttonE9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("59"))
            {
                eingabeLongX = 5;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonE9.BackColor = Color.LightGreen;
        }

        private void buttonF1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("61"))
            {
                eingabeLongX = 6;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonF1.BackColor = Color.LightGreen;
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("62"))
            {
                eingabeLongX = 6;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonF2.BackColor = Color.LightGreen;
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("63"))
            {
                eingabeLongX = 6;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonF3.BackColor = Color.LightGreen;
        }

        private void buttonF4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("64"))
            {
                eingabeLongX = 6;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonF4.BackColor = Color.LightGreen;
        }

        private void buttonF5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("65"))
            {
                eingabeLongX = 6;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonF5.BackColor = Color.LightGreen;
        }

        private void buttonF6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("66"))
            {
                eingabeLongX = 6;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonF6.BackColor = Color.LightGreen;
        }

        private void buttonF7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("67"))
            {
                eingabeLongX = 6;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonF7.BackColor = Color.LightGreen;
        }

        private void buttonF8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("68"))
            {
                eingabeLongX = 6;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonF8.BackColor = Color.LightGreen;
        }

        private void buttonF9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("69"))
            {
                eingabeLongX = 6;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonF9.BackColor = Color.LightGreen;
        }

        private void buttonG1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("71"))
            {
                eingabeLongX = 7;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonG1.BackColor = Color.LightGreen;
        }

        private void buttonG2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("72"))
            {
                eingabeLongX = 7;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonG2.BackColor = Color.LightGreen;
        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("73"))
            {
                eingabeLongX = 7;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonG3.BackColor = Color.LightGreen;
        }

        private void buttonG4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("74"))
            {
                eingabeLongX = 7;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonG4.BackColor = Color.LightGreen;
        }

        private void buttonG5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("75"))
            {
                eingabeLongX = 7;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonG5.BackColor = Color.LightGreen;
        }

        private void buttonG6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("76"))
            {
                eingabeLongX = 7;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonG6.BackColor = Color.LightGreen;
        }

        private void buttonG7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("77"))
            {
                eingabeLongX = 7;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonG7.BackColor = Color.LightGreen;
        }

        private void buttonG8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("78"))
            {
                eingabeLongX = 7;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonG8.BackColor = Color.LightGreen;
        }

        private void buttonG9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("79"))
            {
                eingabeLongX = 7;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonG9.BackColor = Color.LightGreen;
        }

        private void buttonH1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("81"))
            {
                eingabeLongX = 8;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonH1.BackColor = Color.LightGreen;
        }

        private void buttonH2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("82"))
            {
                eingabeLongX = 8;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonH2.BackColor = Color.LightGreen;
        }

        private void buttonH3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("83"))
            {
                eingabeLongX = 8;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonH3.BackColor = Color.LightGreen;
        }

        private void buttonH4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("84"))
            {
                eingabeLongX = 8;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonH4.BackColor = Color.LightGreen;
        }

        private void buttonH5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("85"))
            {
                eingabeLongX = 8;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonH5.BackColor = Color.LightGreen;
        }

        private void buttonH6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("86"))
            {
                eingabeLongX = 8;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonH6.BackColor = Color.LightGreen;
        }

        private void buttonH7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("87"))
            {
                eingabeLongX = 8;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonH7.BackColor = Color.LightGreen;
        }

        private void buttonH8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("88"))
            {
                eingabeLongX = 8;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonH8.BackColor = Color.LightGreen;
        }

        private void buttonH9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("89"))
            {
                eingabeLongX = 8;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonH9.BackColor = Color.LightGreen;
        }

        private void buttonI1_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("91"))
            {
                eingabeLongX = 9;
                eingabeLongY = 1;
            }
            ResetAllColors();
            buttonI1.BackColor = Color.LightGreen;
        }

        private void buttonI2_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("92"))
            {
                eingabeLongX = 9;
                eingabeLongY = 2;
            }
            ResetAllColors();
            buttonI2.BackColor = Color.LightGreen;
        }

        private void buttonI3_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("93"))
            {
                eingabeLongX = 9;
                eingabeLongY = 3;
            }
            ResetAllColors();
            buttonI3.BackColor = Color.LightGreen;
        }

        private void buttonI4_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("94"))
            {
                eingabeLongX = 9;
                eingabeLongY = 4;
            }
            ResetAllColors();
            buttonI4.BackColor = Color.LightGreen;
        }

        private void buttonI5_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("95"))
            {
                eingabeLongX = 9;
                eingabeLongY = 5;
            }
            ResetAllColors();
            buttonI5.BackColor = Color.LightGreen;
        }

        private void buttonI6_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("96"))
            {
                eingabeLongX = 9;
                eingabeLongY = 6;
            }
            ResetAllColors();
            buttonI6.BackColor = Color.LightGreen;
        }

        private void buttonI7_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("97"))
            {
                eingabeLongX = 9;
                eingabeLongY = 7;
            }
            ResetAllColors();
            buttonI7.BackColor = Color.LightGreen;
        }

        private void buttonI8_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("98"))
            {
                eingabeLongX = 9;
                eingabeLongY = 8;
            }
            ResetAllColors();
            buttonI8.BackColor = Color.LightGreen;
        }

        private void buttonI9_Click(object sender, EventArgs e)
        {
            if (!BlockierteButtons("99"))
            {
                eingabeLongX = 9;
                eingabeLongY = 9;
            }
            ResetAllColors();
            buttonI9.BackColor = Color.LightGreen;
        }

        private void buttonEingabe1_Click(object sender, EventArgs e)
        {
            ziffer = 1;
            ZahlFestlegen();
        }

        private void buttonEingabe2_Click(object sender, EventArgs e)
        {
            ziffer = 2;
            ZahlFestlegen();
        }

        private void buttonEingabe3_Click(object sender, EventArgs e)
        {
            ziffer = 3;
            ZahlFestlegen();
        }

        private void buttonEingabe4_Click(object sender, EventArgs e)
        {
            ziffer = 4;
            ZahlFestlegen();
        }

        private void buttonEingabe5_Click(object sender, EventArgs e)
        {
            ziffer = 5;
            ZahlFestlegen();
        }

        private void buttonEingabe6_Click(object sender, EventArgs e)
        {
            ziffer = 6;
            ZahlFestlegen();
        }

        private void buttonEingabe7_Click(object sender, EventArgs e)
        {
            ziffer = 7;
            ZahlFestlegen();
        }

        private void buttonEingabe8_Click(object sender, EventArgs e)
        {
            ziffer = 8;
            ZahlFestlegen();
        }

        private void buttonEingabe9_Click(object sender, EventArgs e)
        {
            ziffer = 9;
            ZahlFestlegen();
        }

        private void buttonEingabe0_Click(object sender, EventArgs e)
        {
            ziffer = 0;
            ZahlFestlegen();
        }

        private void buttonLoadSudoku_Click(object sender, EventArgs e)
        {
            reset();
            string Eingabe = textBoxSudokuFileName.Text;

            if (System.IO.File.Exists(@Eingabe + ".txt"))
            {
                string[] Zwischenstring = new string[81];
                Zwischenstring = System.IO.File.ReadAllLines(@Eingabe + ".txt");

                long i3 = 0;
                long i4 = 0;

                SudokuTemplatePath = Eingabe + ".txt";

                Zwischenstring = System.IO.File.ReadAllLines(@Eingabe + ".txt");
                for (long i1 = 1; i1 <= 9; i1++)
                {
                    for (long i2 = 1; i2 <= 9; i2++)
                    {

                        if (i3 <= Zwischenstring.Length - 1)
                        {
                            Feld[i1, i2] = long.Parse(Zwischenstring[i3]);

                            if ((Zwischenstring[i3] == "1") || (Zwischenstring[i3] == "2") || (Zwischenstring[i3] == "3") || (Zwischenstring[i3] == "4") || (Zwischenstring[i3] == "5") || (Zwischenstring[i3] == "6") || (Zwischenstring[i3] == "7") || (Zwischenstring[i3] == "8") || (Zwischenstring[i3] == "9"))
                            {
                                SudokuBlockedPositions[i4] = i1.ToString() + i2.ToString();
                                i4++;
                            }

                            i3++;
                        }
                    }
                }

                System.IO.File.WriteAllLines(@"Sudoku_autosave_blocked_positions.txt", SudokuBlockedPositions);
                ResetAllColors();
                Ausgabe();
                textBoxSudokuFileName.Text = "";
                buttonLoadSudoku.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxSudokuFileName.BackColor = Color.OrangeRed;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] Speichern = new string[81];
            string Zwischenspeicher;
            long i3 = 0;
            for (long i1 = 1; i1 <= 9; i1++)
            {
                for (long i2 = 1; i2 <= 9; i2++)
                {

                    long FeldLong = Feld[i1, i2];
                    Zwischenspeicher = FeldLong.ToString();
                    Speichern[i3] = Zwischenspeicher;
                    i3++;
                }
            }
            if (textBoxSaveFileName.Text == "")
            {
                System.IO.File.WriteAllLines(@"Sudoku_savedGame.txt", Speichern);
                System.IO.File.WriteAllLines(@"Sudoku_savedGame_blocked_positions.txt", SudokuBlockedPositions);
            }
            else
            {
                string Eingabe = textBoxSaveFileName.Text;
                System.IO.File.WriteAllLines(@Eingabe + ".txt", Speichern);
                System.IO.File.WriteAllLines(@Eingabe + "_blocked_positions.txt", SudokuBlockedPositions);
            }



            ResetAllColors();
            buttonSave.BackColor = Color.LightGreen;
        }

        private void buttonLoadSavedGame_Click(object sender, EventArgs e)
        {
            ResetAllColors();

            string[] Zwischenstring = new string[81];

            if (textBoxSaveFileName.Text == "")
            {
                if (System.IO.File.Exists(@"Sudoku_savedGame.txt") && System.IO.File.Exists(@"Sudoku_savedGame_blocked_positions.txt"))
                {
                    Zwischenstring = System.IO.File.ReadAllLines(@"Sudoku_savedGame.txt");
                    long i3 = 0;
                    for (long i1 = 1; i1 <= 9; i1++)
                    {
                        for (long i2 = 1; i2 <= 9; i2++)
                        {

                            if (i3 <= Zwischenstring.Length - 1)
                            {

                                Feld[i1, i2] = long.Parse(Zwischenstring[i3]);
                                i3++;
                            }
                        }
                    }
                    SudokuBlockedPositions = System.IO.File.ReadAllLines(@"Sudoku_savedGame_blocked_positions.txt");
                    Ausgabe();
                    buttonLoadSavedGame.BackColor = Color.LightGreen;
                }
                else
                {
                    Ausgabe();
                    buttonLoadSavedGame.BackColor = Color.OrangeRed;
                }
            }
            else
            {
                string Eingabe = textBoxSaveFileName.Text;
                if (System.IO.File.Exists(@Eingabe + ".txt") && System.IO.File.Exists(@Eingabe + "_blocked_positions.txt"))
                {
                    Zwischenstring = System.IO.File.ReadAllLines(@Eingabe + ".txt");
                    long i3 = 0;
                    for (long i1 = 1; i1 <= 9; i1++)
                    {
                        for (long i2 = 1; i2 <= 9; i2++)
                        {

                            if (i3 <= Zwischenstring.Length - 1)
                            {

                                Feld[i1, i2] = long.Parse(Zwischenstring[i3]);
                                i3++;
                            }
                        }
                    }
                    SudokuBlockedPositions = System.IO.File.ReadAllLines(@Eingabe + "_blocked_positions.txt");
                    Ausgabe();
                    buttonLoadSavedGame.BackColor = Color.LightGreen;
                }
                else
                {
                    Ausgabe();
                    textBoxSaveFileName.BackColor = Color.OrangeRed;
                }
            }
        }

        private void buttonLoadAutosave_Click(object sender, EventArgs e)
        {
            ResetAllColors();

            if (System.IO.File.Exists(@"Sudoku_autosave.txt") && System.IO.File.Exists(@"Sudoku_autosave_blocked_positions.txt"))
            {
                string[] Zwischenstring = new string[81];
                Zwischenstring = System.IO.File.ReadAllLines(@"Sudoku_autosave.txt");
                long i3 = 0;
                for (long i1 = 1; i1 <= 9; i1++)
                {
                    for (long i2 = 1; i2 <= 9; i2++)
                    {
                        if (i3 <= Zwischenstring.Length - 1)
                        {

                            Feld[i1, i2] = long.Parse(Zwischenstring[i3]);
                            i3++;
                        }
                    }
                }
                SudokuBlockedPositions = System.IO.File.ReadAllLines(@"Sudoku_autosave_blocked_positions.txt");
                Ausgabe();
                buttonLoadAutosave.BackColor = Color.LightGreen;
            }
            else
            {
                buttonLoadAutosave.BackColor = Color.OrangeRed;
            }
        }

        static void autosave()
        {
            string[] Speichern = new string[81];
            string Zwischenspeicher;
            long i3 = 0;
            for (long i1 = 1; i1 <= 9; i1++)
            {
                for (long i2 = 1; i2 <= 9; i2++)
                {

                    long FeldLong = Feld[i1, i2];
                    Zwischenspeicher = FeldLong.ToString();
                    Speichern[i3] = Zwischenspeicher;
                    i3++;
                }
            }
            System.IO.File.WriteAllLines(@"Sudoku_autosave.txt", Speichern);
            System.IO.File.WriteAllLines(@"Sudoku_autosave_blocked_positions.txt", SudokuBlockedPositions);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"Sudoku_autosave_blocked_positions.txt") && System.IO.File.Exists(@SudokuTemplatePath))
            {
                reset();
                SudokuBlockedPositions = System.IO.File.ReadAllLines(@"Sudoku_autosave_blocked_positions.txt");
                string[] Zwischenstring = new string[81];
                Zwischenstring = System.IO.File.ReadAllLines(@SudokuTemplatePath);

                long i3 = 0;

                Zwischenstring = System.IO.File.ReadAllLines(@SudokuTemplatePath);
                for (long i1 = 1; i1 <= 9; i1++)
                {
                    for (long i2 = 1; i2 <= 9; i2++)
                    {

                        if (i3 <= Zwischenstring.Length - 1)
                        {
                            Feld[i1, i2] = long.Parse(Zwischenstring[i3]);
                            i3++;
                        }
                    }
                }

                Ausgabe();
                ResetAllColors();
                buttonRestart.BackColor = Color.LightGreen;
            }
            else
            {
                buttonRestart.BackColor = Color.OrangeRed;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            for (long i1 = 1; i1 <= 9; i1++)
            {
                for (long i2 = 1; i2 <= 9; i2++)
                {

                    Feld[i1, i2] = 0;
                }
            }
            for (long i3 = 0; i3 < 81; i3++)
            {
                SudokuBlockedPositions[i3] = "00";
            }
            eingabeLongX = 0;
            eingabeLongY = 0;
            ziffer = 0;
            ButtonsString();
            Ausgabe();
            ResetAllColors();
        }

        private void ResetAllColors()
        {
            foreach (Button button in buttonsFelder)
            {
                button.BackColor = Color.LightGray;
            }

            buttonCheck.BackColor = Color.LightGray;
            buttonSave.BackColor = Color.LightGray;
            buttonLoadSavedGame.BackColor = Color.LightGray;
            buttonLoadAutosave.BackColor = Color.LightGray;
            buttonReset.BackColor = Color.LightGray;
            buttonLoadSudoku.BackColor = Color.LightGray;
            buttonRestart.BackColor = Color.LightGray;
            textBoxSaveFileName.BackColor = Color.White;
            textBoxSudokuFileName.BackColor = Color.White;

            ResetBlockedButtonsColors();
        }

        private void ResetBlockedButtonsColors()
        {
            int i3 = 0;
            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    string A1 = i1.ToString();
                    string A2 = i2.ToString();
                    if (BlockierteButtons(A1 + A2))
                    {
                        buttonsFelder[i3].BackColor = Color.Gray;
                    }
                    i3++;
                }
            }
        }
        private bool BlockierteButtons(string Eingabe)
        {
            for (int i1 = 0; i1 < 81; i1++)
            {
                if (SudokuBlockedPositions[i1] == Eingabe)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            ResetAllColors();
            long yCheck = 0;
            long xCheck = 0;
            long BereichCheck = 0;
            if ((CheckYAchse(yCheck) == 0) && (CheckXAchse(xCheck) == 0) && (CheckBereich(BereichCheck) == 0))
            {
                buttonCheck.BackColor = Color.LightGreen;
            }
            else
            {
                buttonCheck.BackColor = Color.OrangeRed;
            }
        }

        static long CheckYAchse(long yCheck)
        {
            for (A = 1; A < 10; A++)
            {
                bool Stelle1 = false;
                bool Stelle2 = false;
                bool Stelle3 = false;
                bool Stelle4 = false;
                bool Stelle5 = false;
                bool Stelle6 = false;
                bool Stelle7 = false;
                bool Stelle8 = false;
                bool Stelle9 = false;

                for (B = 1; B < 10; B++)
                {
                    if (Feld[A, B] == 1)
                    {
                        Stelle1 = true;
                    }
                    if (Feld[A, B] == 2)
                    {
                        Stelle2 = true;
                    }
                    if (Feld[A, B] == 3)
                    {
                        Stelle3 = true;
                    }
                    if (Feld[A, B] == 4)
                    {
                        Stelle4 = true;
                    }
                    if (Feld[A, B] == 5)
                    {
                        Stelle5 = true;
                    }
                    if (Feld[A, B] == 6)
                    {
                        Stelle6 = true;
                    }
                    if (Feld[A, B] == 7)
                    {
                        Stelle7 = true;
                    }
                    if (Feld[A, B] == 8)
                    {
                        Stelle8 = true;
                    }
                    if (Feld[A, B] == 9)
                    {
                        Stelle9 = true;
                    }
                }

                if (!(Stelle1) || !(Stelle2) || !(Stelle3) || !(Stelle4) || !(Stelle5) || !(Stelle6) || !(Stelle7) || !(Stelle8) || !(Stelle9))
                {
                    yCheck++;
                    return yCheck;
                }

            }

            return yCheck;
        }

        static long CheckXAchse(long xCheck)
        {
            for (B = 1; B < 10; B++)
            {
                bool Stelle1 = false;
                bool Stelle2 = false;
                bool Stelle3 = false;
                bool Stelle4 = false;
                bool Stelle5 = false;
                bool Stelle6 = false;
                bool Stelle7 = false;
                bool Stelle8 = false;
                bool Stelle9 = false;

                for (A = 1; A < 10; A++)
                {
                    if (Feld[A, B] == 1)
                    {
                        Stelle1 = true;
                    }
                    if (Feld[A, B] == 2)
                    {
                        Stelle2 = true;
                    }
                    if (Feld[A, B] == 3)
                    {
                        Stelle3 = true;
                    }
                    if (Feld[A, B] == 4)
                    {
                        Stelle4 = true;
                    }
                    if (Feld[A, B] == 5)
                    {
                        Stelle5 = true;
                    }
                    if (Feld[A, B] == 6)
                    {
                        Stelle6 = true;
                    }
                    if (Feld[A, B] == 7)
                    {
                        Stelle7 = true;
                    }
                    if (Feld[A, B] == 8)
                    {
                        Stelle8 = true;
                    }
                    if (Feld[A, B] == 9)
                    {
                        Stelle9 = true;
                    }
                }
                if (!(Stelle1) || !(Stelle2) || !(Stelle3) || !(Stelle4) || !(Stelle5) || !(Stelle6) || !(Stelle7) || !(Stelle8) || !(Stelle9))
                {
                    xCheck++;
                    return xCheck;
                }

            }

            return xCheck;
        }

        static long CheckBereich(long BereichCheck)
        {
            bool Stelle1 = false;
            bool Stelle2 = false;
            bool Stelle3 = false;
            bool Stelle4 = false;
            bool Stelle5 = false;
            bool Stelle6 = false;
            bool Stelle7 = false;
            bool Stelle8 = false;
            bool Stelle9 = false;

            //bool[] FeldBool = new bool[9];
            //for (int i1 = 0; i1 < 9; i1++)
            //{
            //    FeldBool[i1] = false;
            //}

            A = 1;

            for (B = 1; B <= 10; B++)
            {
                for (; A < 10; A++)
                {
                    if (Feld[A, B] == 1)
                    {
                        Stelle1 = true;
                    }
                    if (Feld[A, B] == 2)
                    {
                        Stelle2 = true;
                    }
                    if (Feld[A, B] == 3)
                    {
                        Stelle3 = true;
                    }
                    if (Feld[A, B] == 4)
                    {
                        Stelle4 = true;
                    }
                    if (Feld[A, B] == 5)
                    {
                        Stelle5 = true;
                    }
                    if (Feld[A, B] == 6)
                    {
                        Stelle6 = true;
                    }
                    if (Feld[A, B] == 7)
                    {
                        Stelle7 = true;
                    }
                    if (Feld[A, B] == 8)
                    {
                        Stelle8 = true;
                    }
                    if (Feld[A, B] == 9)
                    {
                        Stelle9 = true;
                    }

                    if (B % 9 == 0 && A % 3 == 0)
                    {
                        break;
                    }

                    if (A % 3 == 0)
                    {
                        A -= 3;
                        B++;
                    }
                }

                if (B % 3 == 0 && A % 3 == 0)
                {
                    if (!(Stelle1) || !(Stelle2) || !(Stelle3) || !(Stelle4) || !(Stelle5) || !(Stelle6) || !(Stelle7) || !(Stelle8) || !(Stelle9))
                    {
                        BereichCheck++;
                        return BereichCheck;
                    }

                    if (B % 9 == 0 && A % 9 == 0)
                    {
                        break;
                    }

                    if (B % 9 == 0 && A % 3 == 0)
                    {
                        A++;
                        B = 0;
                    }

                    Stelle1 = false;
                    Stelle2 = false;
                    Stelle3 = false;
                    Stelle4 = false;
                    Stelle5 = false;
                    Stelle6 = false;
                    Stelle7 = false;
                    Stelle8 = false;
                    Stelle9 = false;
                }
            }
            return BereichCheck;
        }

        private void ZahlFestlegen()
        {
            Feld[eingabeLongX, eingabeLongY] = ziffer;
            eingabeLongX = 0;
            eingabeLongY = 0;
            ziffer = 0;
            autosave();
            Ausgabe();
            ResetAllColors();
        }
        private void Ausgabe()
        {
            int i3 = 0;
            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    string FeldString = Feld[i1, i2].ToString();

                    if (FeldString == "0")
                    {
                        buttonsFelder[i3].Text = "";
                    }
                    else
                    {
                        buttonsFelder[i3].Text = FeldString;
                    }

                    i3++;
                }
            }
        }

        private void buttonSolveAutomatically_Click(object sender, EventArgs e)
        {
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    bool blocked = false;

                    for (int c = 0; c < 81; c++)
                    {
                        if (SudokuBlockedPositions[c] == a.ToString() + b.ToString())
                        {
                            blocked = true;
                        }
                    }

                    if (!blocked)
                    {
                        Feld[a, b] = 0;
                    }
                }
            }

            for (int a = 99; a > 10; a--)
            {
                int b = a / 10;
                int c = a % 10;

                if (c != 0)
                {
                    int x = b;
                    int y = c;

                    //long zahl;
                    //bool reset = false;

                    int o = 0;
                    int p = 0;

                    Test(x, y, b, c, p, o);




                    //for (; x < 10; x++)
                    //{
                    //    for (; y < 10; y++)
                    //    {
                    //        Ausgabe(); 
                    //        //string Test = Feld[x,y].ToString();
                    //        //zahl = Feld[x, y] + 1;
                    //        //if (zahl == 10)
                    //        //{
                    //        //    zahl = 1;
                    //        //    reset = true;
                    //        //}

                    //        if (!BlockierteButtons(x.ToString() + y.ToString()))
                    //        {   
                    //            x = x;
                    //            y = y;

                    //            Feld[x, y] = Feld[x, y] + 1;

                    //            if (Feld[x, y] == 10)
                    //            {
                    //                Feld[x, y] = 1;
                    //                reset = true;
                    //            }

                    //            //if (zahl == 9)
                    //            //{
                    //            //    zahl = 1;
                    //            //    reset = true;
                    //            //}

                    //            Ausgabe();
                    //            long yCheck = 0;
                    //            long xCheck = 0;
                    //            long BereichCheck = 0;

                    //            if ((CheckYAchse(yCheck) == 0) && (CheckXAchse(xCheck) == 0) && (CheckBereich(BereichCheck) == 0))
                    //            {
                    //                buttonCheck.BackColor = Color.Blue;
                    //                break;
                    //            }

                    //        }
                    //    }

                    //    if (reset)
                    //    {
                    //        //x -= 1;
                    //        reset = false;
                    //    }
                    //}

                    //long yCheck = 0;
                    //long xCheck = 0;
                    //long BereichCheck = 0;

                    //if ((CheckYAchse(yCheck) == 0) && (CheckXAchse(xCheck) == 0) && (CheckBereich(BereichCheck) == 0))
                    //{
                    //    break;
                    //}
                }

            }

            Ausgabe();
        }



        private void Test(int x, int y, int b, int c, int o, int p)
        {
            if (o != 0 && p != 0)
            {
                x = o;
                y = p;
            }

            int h = x;
            int j = y;

            Feld[x, y] = Feld[x, y] + 1;

            if (Feld[x, y] == 10)
            {
                if (y == 1)
                {
                    x -= 1;
                    j = y - 1;
                    Feld[x, j] = Feld[x, j] + 1;
                }
                else
                {
                    Feld[x, y - 1] = Feld[x, y - 1] + 1;
                }

                Feld[x, y] = 1;
            }
        }

        //private void buttonSolveAutomatically_Click(object sender, EventArgs e)
        //{
        //    //while (1 == 1)
        //    //{
        //        for (int i1 = 1; i1 < 10; i1++)
        //        {
        //            for (int i2 = 1; i2 < 10; i2++)
        //            {
        //                bool blocked = false;
        //                for (int i3 = 0; i3 < 81; i3++)
        //                {
        //                    if (SudokuBlockedPositions[i3] == i1.ToString() + i2.ToString())
        //                    {
        //                        blocked = true;
        //                    }
        //                }



        //                if (!blocked)
        //                {
        //                    for (int i4 = 1; i4 < 10; i4++)
        //                    {
        //                        bool exists = false;

        //                        if (!Vorhanden(exists, i1, i2, i4))
        //                        {
        //                            Feld[i1, i2] = i4;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        //long xCheck = 0;
        //        //long yCheck = 0;
        //        //long BereichCheck = 0;

        //        //if (CheckXAchse(xCheck) == 0 && CheckYAchse(yCheck) == 0 && CheckBereich(BereichCheck) == 0)
        //        //{
        //        //    Ausgabe();
        //        //    ResetAllColors();
        //        //    break;
        //        //}

        //    //}

        //    Ausgabe();
        //    ResetAllColors();
        //}

        private bool Vorhanden(bool exists, int x, int y, int zahl)
        {
            //X Achse
            for (int z = 1; z < 10; z++)
            {
                if (Feld[x, z] == zahl && y != z)
                {
                    exists = true;
                    return exists;
                }
            }

            //Y Achse
            for (int z = 1; z < 10; z++)
            {
                if (Feld[z, y] == zahl && x != z)
                {
                    exists = true;
                    return exists;
                }
            }

            //im Block

            for (int counter = 1; counter < 10; counter++)
            {
                int a = 0;
                int b = 0;

                if (x > 0 && x < 4 && y > 0 && y < 4)
                {
                    a = 1;
                    b = 1;
                }
                if (x > 3 && x < 7 && y > 0 && y < 4)
                {
                    a = 4;
                    b = 1;
                }
                if (x > 6 && x < 10 && y > 0 && y < 4)
                {
                    a = 7;
                    b = 1;
                }
                if (x > 0 && x < 4 && y > 3 && y < 7)
                {
                    a = 1;
                    b = 4;
                }
                if (x > 3 && x < 7 && y > 3 && y < 7)
                {
                    a = 4;
                    b = 4;
                }
                if (x > 6 && x < 10 && y > 3 && y < 7)
                {
                    a = 7;
                    b = 4;
                }
                if (x > 0 && x < 4 && y > 6 && y < 10)
                {
                    a = 1;
                    b = 7;
                }
                if (x > 3 && x < 7 && y > 6 && y < 10)
                {
                    a = 4;
                    b = 7;
                }
                if (x > 6 && x < 10 && y > 6 && y < 10)
                {
                    a = 7;
                    b = 7;
                }

                int a2 = a + 3;
                int b2 = b + 3;

                for (; a < a2; a++)
                {
                    for (; b < b2; b++)
                    {
                        if (Feld[a, b] == zahl && x != a && y != b)
                        {
                            exists = true;
                            return exists;
                        }
                    }

                    if (b == b2)
                    {
                        b -= 3;
                    }
                }
            }

            

            //for (int z = 1; z < 10; z++)
            //{
            //    if (Feld[x, y] == Feld[z, y] && )
            //    {
            //        exists = true;
            //        return exists;
            //    }
            //}

            return exists;
        }
    }
}