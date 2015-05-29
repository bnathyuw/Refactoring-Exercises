using System;

namespace RefactoringExercises.ExtractMethod
{
    public class UltimateQuestion
    {
        private readonly IThink _thinker;

        public UltimateQuestion(IThink thinker)
        {
            _thinker = thinker;
        }

        public int GetAnswer(DayOfWeek day, string favouriteColour)
        {
            // Think long and hard
            _thinker.ThinkLongAndHard();

            // Determine colour factor
            var colourFactor = favouriteColour.Length;

            // Determine day factors
            int dayFactorX;
            int dayFactorY;
            int dayFactorZ;
            switch (day)
            {
                case DayOfWeek.Monday:
                    dayFactorX = 3;
                    dayFactorY = 7;
                    dayFactorZ = colourFactor*2;
                    break;
                case DayOfWeek.Friday:
                    dayFactorX = colourFactor*21;
                    dayFactorY = 2;
                    dayFactorZ = 1;
                    break;
                default:
                    dayFactorX = 14;
                    dayFactorY = 1;
                    dayFactorZ = colourFactor*3;
                    break;
            }

            // Calculate answer
            return dayFactorX * dayFactorY * dayFactorZ / colourFactor;
        }
    }
}