using System;

namespace HopfieldNetwork.Classes
{
    public class Neuron
    {
        public int[] weightVector = new int[9];
        public int activation;
        public Neuron(int[] invec)
        {
            for (int i = 0; i < invec.Length; i++)
            {
                weightVector[i] = invec[i];
            }
        }

        public int Act(int[] pattern)
        {
            int value = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                value += pattern[i] * weightVector[i];
            }

            return value;
        }  
    }
}
