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
    public Text p4LifesText;
    public Text p4KillsText;
    public Text p4ScoreText;

    public AIMovement[] ias;

    public MarksController marksP1;
    public MarksController marksP2;
    public MarksController marksP3;
    public MarksController marksP4;

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
        p3LifesText.text = "" + marksP3.GetTotalDeaths();
        p3KillsText.text = "" + marksP3.GetTotalKills();
        p4LifesText.text = "" + marksP4.GetTotalDeaths();
        p4KillsText.text = "" + marksP4.GetTotalKills();

        if (PlayerPrefs.GetString("gameMode") == "lifes")  {
            p1ScoreText.text = "" + marksP1.GetTotalDeaths();
            p2ScoreText.text = "" + marksP2.GetTotalDeaths();
            p3ScoreText.text = "" + marksP3.GetTotalDeaths();
            p4ScoreText.text = "" + marksP4.GetTotalDeaths();
        }
        else  {
            p1ScoreText.text = "" + ((marksP1.GetTotalKills() * 2) - marksP1.GetTotalDeaths());
            p2ScoreText.text = "" + ((marksP2.GetTotalKills() * 2) - marksP2.GetTotalDeaths());
            p3ScoreText.text = "" + ((marksP3.GetTotalKills() * 2) - marksP3.GetTotalDeaths());
            p4ScoreText.text = "" + ((marksP4.GetTotalKills() * 2) - marksP4.GetTotalDeaths());
        }

        //here we will need to finish the episode for all the IAs
        ias[0].finishEpisode();
        ias[1].finishEpisode();
    }

    public void WhenMainMenuIsClicked ()
    {
        Debug.Log("It entered when main menu is clicked");
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
        } else if (agresorTag == "Player3")
        {
            marksP3.IncreaseKills();
        } else if (agresorTag == "Player4")
        {
            marksP4.IncreaseKills();
        }
    }
}
