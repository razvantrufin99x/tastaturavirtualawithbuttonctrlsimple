using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tastaturavirtualawithbuttonctrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        public void setValue(string n)
        {
            if (n == "&&")
            {
                textBox1.Text += "&";
            }
            else
            {
                textBox1.Text += n;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //first line of buttons esc fn...
                        vkkb145.setText("ESC");
                        vkkb146.setText("F1");
                        vkkb147.setText("F2");
                        vkkb148.setText("F3");
                        vkkb149.setText("F4");
                        vkkb150.setText("F5");
                        vkkb151.setText("F6");
                        vkkb152.setText("F7");
                        vkkb153.setText("F8");
                        vkkb154.setText("F9");
                        vkkb155.setText("F10");
                        vkkb156.setText("F11");
                        vkkb157.setText("F12");
                        vkkb158.setText("POS1");
                        vkkb159.setText("END");
                        vkkb160.setText("ROLL");

                        vkkb161.setText("WIFI");
                        vkkb162.setText("SNDD");
                        vkkb163.setText("MUT");
                        vkkb164.setText("SNDD");
                        vkkb165.setText("MOU");
                        vkkb166.setText("CAM");
                        vkkb167.setText("B-");
                        vkkb168.setText("B+");
                        vkkb169.setText("SCR");
                        vkkb170.setText("FAN");
                        vkkb171.setText("SLEEP");
                        vkkb172.setText("NUM");
                        vkkb173.setText("DRUCK");
                        vkkb174.setText("EINFG");
                        vkkb175.setText("PAUSE");
                        vkkb176.setText("ENTF");
            // line of digits 

                        vkkb1.setText("~");
                        vkkb2.setText("!");
                        vkkb3.setText("@");
                        vkkb4.setText("#");
                        vkkb5.setText("$");
                        vkkb6.setText("%");
                        vkkb7.setText("^");
                        vkkb8.setText("&&");
                        vkkb9.setText("*");
                        vkkb10.setText("(");
                        vkkb11.setText(")");
                        vkkb12.setText("_");
                        vkkb13.setText("+");
                        vkkb14.setText("<--");
                        vkkb15.setText("EN");
                        vkkb16.setText("RO");

                        vkkb17.setText("`");
                        vkkb18.setText("1");
                        vkkb19.setText("2");
                        vkkb20.setText("3");
                        vkkb21.setText("4");
                        vkkb22.setText("5");
                        vkkb23.setText("6");
                        vkkb24.setText("7");
                        vkkb25.setText("8");
                        vkkb26.setText("9");
                        vkkb27.setText("0");
                        vkkb28.setText("-");
                        vkkb29.setText("=");
                        vkkb30.setText("RET");
                        vkkb31.setText("SCH");
                        vkkb32.setText("TAB");

           // first row of letters 

                        vkkb33.setText("TAB");
                        vkkb34.setText("Q");
                        vkkb35.setText("W");
                        vkkb36.setText("E");
                        vkkb37.setText("R");
                        vkkb38.setText("T");
                        vkkb39.setText("Y");
                        vkkb40.setText("U");
                        vkkb41.setText("I");
                        vkkb42.setText("O");
                        vkkb43.setText("P");
                        vkkb44.setText("{");
                        vkkb45.setText("}");
                        vkkb46.setText("ENT");
                        vkkb47.setText("ESC");
                        vkkb48.setText("PRN");

                        vkkb49.setText("TAB");
                        vkkb50.setText("q");
                        vkkb51.setText("w");
                        vkkb52.setText("e");
                        vkkb53.setText("r");
                        vkkb54.setText("t");
                        vkkb55.setText("y");
                        vkkb56.setText("u");
                        vkkb57.setText("i");
                        vkkb58.setText("o");
                        vkkb59.setText("p");
                        vkkb60.setText("[");
                        vkkb61.setText("]");
                        vkkb62.setText("RET");
                        vkkb63.setText("SCH");
                        vkkb64.setText("TAB");

                        vkkb65.setText("CL");
                        vkkb66.setText("A");
                        vkkb67.setText("S");
                        vkkb68.setText("D");
                        vkkb69.setText("F");
                        vkkb70.setText("G");
                        vkkb71.setText("H");
                        vkkb72.setText("J");
                        vkkb73.setText("K");
                        vkkb74.setText("L");
                        vkkb75.setText(":");
                        vkkb76.setText("\"");
                        vkkb77.setText("|");
                        vkkb78.setText("RET");
                        vkkb79.setText("SCH");
                        vkkb80.setText("TAB");

                        vkkb81.setText("CL");
                        vkkb82.setText("a");
                        vkkb83.setText("s");
                        vkkb84.setText("d");
                        vkkb85.setText("f");
                        vkkb86.setText("g");
                        vkkb87.setText("h");
                        vkkb88.setText("j");
                        vkkb89.setText("k");
                        vkkb90.setText("l");
                        vkkb91.setText(";");
                        vkkb92.setText("'");
                        vkkb93.setText("\\");
                        vkkb94.setText("RET");
                        vkkb95.setText("SCH");
                        vkkb96.setText("TAB");

                        vkkb97.setText("SHF");
                        vkkb98.setText("|");
                        vkkb99.setText("Z");
                        vkkb100.setText("X");
                        vkkb101.setText("C");
                        vkkb102.setText("V");
                        vkkb103.setText("B");
                        vkkb104.setText("N");
                        vkkb105.setText("M");
                        vkkb106.setText(",");
                        vkkb107.setText(".");
                        vkkb108.setText("/");
                        vkkb109.setText("SCH");
                        vkkb110.setText("RET");
                        vkkb111.setText("CTRL");
                        vkkb112.setText("TAB");

                        vkkb113.setText("SCH");
                        vkkb114.setText("\\");
                        vkkb115.setText("z");
                        vkkb116.setText("x");
                        vkkb117.setText("c");
                        vkkb118.setText("v");
                        vkkb119.setText("b");
                        vkkb120.setText("n");
                        vkkb121.setText("m");
                        vkkb122.setText("<");
                        vkkb123.setText(">");
                        vkkb124.setText("?");
                        vkkb125.setText("SCH");
                        vkkb126.setText("RET");
                        vkkb127.setText("SCH");
                        vkkb128.setText("TAB");
            //last row of buttons
                        vkkb129.setText("CTRL");
                        vkkb130.setText("FN");
                        vkkb131.setText("WIN");
                        vkkb132.setText("ALT");
                        vkkb133.setText(" ");
                        vkkb134.setText("  ");
                        vkkb135.setText(" ");
                        vkkb136.setText(" ");
                        vkkb137.setText(" ");
                        vkkb138.setText("AGR");
                        vkkb139.setText("MEN");
                        vkkb140.setText("CTRL");
                        vkkb141.setText("UP");
                        vkkb142.setText("LF");
                        vkkb143.setText("DN");
                        vkkb144.setText("RG");
           



        }
    }
}
