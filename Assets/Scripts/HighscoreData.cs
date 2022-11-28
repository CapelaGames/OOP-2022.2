using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighscoreData
{
    public float score;

    public HighscoreData()
    {
        score = float.MaxValue;
    }

    public HighscoreData(float prevScore)
    {
        score = prevScore;
    }

   public void SubmitScore(float newScore)
    {
        if(newScore < score)
        {
            score = newScore;
        }
    }


}
