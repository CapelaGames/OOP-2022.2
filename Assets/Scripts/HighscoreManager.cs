using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <----------

public class HighscoreManager : MonoBehaviour
{
    private HighscoreData highscore;
    public Text text;
    private Timer timer;//
    public SaveHighscoreToFile saveSystem;

    void Start()
    {
        timer = new Timer(); //
        highscore = saveSystem.Load();
        text.text = "Highscore = " + highscore.score;
        GameStarted();//
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) 
        { 
            saveSystem.Save(highscore);
            text.text = "Highscore = " + highscore.score;//
        }
    }
    public void GameStarted()
    {
        timer.StartTimer();//
    }
    public void GameWon()
    {
        float timerScore = timer.StopTimer();
        highscore.SubmitScore(timerScore);
        text.text = "Highscore = " + highscore.score;
        //you could save score to file here if you wanted
    }

}
