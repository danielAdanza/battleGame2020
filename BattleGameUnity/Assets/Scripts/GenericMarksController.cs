using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenericMarksController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Text p1LifesText;
    public Text p1KillsText;
    public Text p1ScoreText;
    public Text p2LifesText;
    public Text p2KillsText;
    public Text p2ScoreText;
    public Text p3LifesText;
    public Text p3KillsText;
    public Text p3ScoreText;

    public MarksController marksP1;
    public MarksController marksP2;
    public MarksController marksP3;

    private float timer = 0.0f;
    public Text timerText;
    private int seconds = 0;

    public void Update()
    {
        timer += Time.deltaTime;
        if ( ( (int) timer ) != seconds)
        {
            if ( PlayerPrefs.GetString("gameMode") == "time" && seconds > (PlayerPrefs.GetInt("numberOfMinutes") * 60) )
            { WhenGameOver(); }
            seconds = (int) timer;
            timerText.text = "" + seconds;
        }
        
    }

    public void WhenGameOver ()
    {
        pauseMenuUI.SetActive(true);
        p1LifesText.text = "" + marksP1.GetTotalDeaths();
        p1KillsText.text = "" + marksP1.GetTotalKills();
        p2LifesText.text = "" + marksP2.GetTotalDeaths();
        p2KillsText.text = "" + marksP2.GetTotalKills();

        if (PlayerPrefs.GetString("gameMode") == "lifes")  {
            p1ScoreText.text = "" + marksP1.GetTotalDeaths();
            p2ScoreText.text = "" + marksP2.GetTotalDeaths();
        }
        else  {
            p1ScoreText.text = "" + ((marksP1.GetTotalKills() * 2) - marksP1.GetTotalDeaths());
            p2ScoreText.text = "" + ((marksP2.GetTotalKills() * 2) - marksP2.GetTotalDeaths());
        }
            
    }

    public void WhenMainMenuIsClicked ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void WhenReplayIsClicked()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void AddKill(string agresorTag)
    {
        if (agresorTag == "Player1")
        {
            marksP1.IncreaseKills();
        } else if (agresorTag == "Player2")
        {
            marksP2.IncreaseKills();
        }
    }
}
