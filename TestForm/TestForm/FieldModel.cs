using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    static class FieldModel
    {
        public const int PlayingField = 16;
        public const int ImageSizeX = 80;
        public const int ImageSizeY = 80;
        public const int SizeModel = 16;
        public static int[] model = BuildModel();

        public static Image[] images = 
        {
                Properties.Resources.Apple,
                Properties.Resources.Bear,
                Properties.Resources.Coconut,
                Properties.Resources.Leaf,
                Properties.Resources.Mushroom,
                Properties.Resources.Nut,
                Properties.Resources.Pineapple,
                Properties.Resources.Scorpio
            
        };

        private static int[] BuildModel()
        {
             int[] model = new int[SizeModel];

            for (int i = 0; i < model.Length; i++)
                model[i] = GlobalRandom.Random.Next(8);

            ValidatesModel(model);

            return model;
        }

        private static void ValidatesModel(int[] model)
        {
            int numberOfCoincidences = 0;
            for (int i = 0; i < model.Length; i++)
            {
                for (int j = 0; j < model.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (model[i] == model[j])
                    {
                        numberOfCoincidences++;
                        if (numberOfCoincidences > 1)
                        {
                            model[j] = GlobalRandom.Random.Next(8);
                            numberOfCoincidences = 0;
                            j = -1;
                            i = 0;
                        }
                    }
                }
                numberOfCoincidences = 0;
            }
        }
    }
}
