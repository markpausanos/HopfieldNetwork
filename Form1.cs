using HopfieldNetwork.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HopfieldNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int is_Clicked(Button button)
        {
            if (button.BackColor == Color.LightGreen)
            {
                return 1;
            }

            return 0;
        }

        private void generateOutputButton_Click(object sender, EventArgs e)
        {
            // Pattern
            int[] pattern1 = new int[] {
                is_Clicked(button1),
                is_Clicked(button2),
                is_Clicked(button3),
                is_Clicked(button4),
                is_Clicked(button5),
                is_Clicked(button6),
                is_Clicked(button7),
                is_Clicked(button8),
                is_Clicked(button9)
            };

            // Weights
            int[] weight1 = new int[] { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
            int[] weight2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
            int[] weight3 = new int[] { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
            int[] weight4 = new int[] { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
            int[] weight5 = new int[] { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
            int[] weight6 = new int[] { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
            int[] weight7 = new int[] { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
            int[] weight8 = new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
            int[] weight9 = new int[] { 2, 0, 2, -2, -2, -2, 2, 0, 0 };

            // Create the network by calling its constructor. The constructor calls neuron 
            // constructor as many times as the number of Neurons in the network.
            Network hopfield1 = new Network(weight1, weight2, weight3, weight4, weight5, weight6, weight7, weight8, weight9);

            // Present a pattern to the network and get the activations of the neurons.
            hopfield1.Activation(pattern1);

            // Check if the pattern given is correctly recalled and give message 
            reset_ColorsPictureBox();
            var pictureBoxes = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            
            for (int i = 0; i < 9; i++)
            {
                if (hopfield1.output[i] == 1)
                {
                    pictureBoxes[i].BackColor = Color.LightGreen;
                }
            }
        }
        private void reset_ColorsPictureBox()
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;
        }
        private void switch_Color(Button button)
        {
            if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.White;
            } 
            else
            {
                button.BackColor = Color.LightGreen;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch_Color(button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch_Color(button2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch_Color(button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            switch_Color(button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch_Color(button5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            switch_Color(button6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            switch_Color(button7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            switch_Color(button8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            switch_Color(button9);
        }
    }
}
