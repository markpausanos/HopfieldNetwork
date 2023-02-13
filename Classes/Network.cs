using System;

namespace HopfieldNetwork.Classes
{
    public class Network
    {
        public Neuron[] neuron = new Neuron[9];
        public int[] output = new int[9];
        public Network(
            int[] weight1, int[] weight2, int[] weight3,
            int[] weight4, int[] weight5, int[] weight6,
            int[] weight7, int[] weight8, int[] weight9
        )
        {
            neuron[0] = new Neuron(weight1);
            neuron[1] = new Neuron(weight2);
            neuron[2] = new Neuron(weight3);
            neuron[3] = new Neuron(weight4);
            neuron[4] = new Neuron(weight5);
            neuron[5] = new Neuron(weight6);
            neuron[6] = new Neuron(weight7);
            neuron[7] = new Neuron(weight8);
            neuron[8] = new Neuron(weight9);
        }
        public int Threshold(int value)
        {
            if (value >= 0)
            {
                return 1;
            }

            return -1;   
        }
        public void Activation(int[] pattern)
        {
            output = pattern;
            int[] previous = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] current = new int[9];

            while (previous != current)
            {
                previous = current;
                AsynchronousUpdate(output);
                current = output;
            }
        }
        public void AsynchronousUpdate(int[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                neuron[i].activation = neuron[i].Act(output);
                output[i] = Threshold(neuron[i].activation);
            }
        }
    }
}
