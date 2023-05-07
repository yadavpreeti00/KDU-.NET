using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    internal class TrackHighScore
    {
        int highScore = 100;
        string highScorePlayer = "Preeti";

        public void UpdateHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
                highScore = score;
                highScorePlayer = playerName;
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}
