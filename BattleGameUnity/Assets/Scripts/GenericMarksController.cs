using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenericMarksController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Text pauseMenuText;

    public MarksController marksP1;
    public MarksController marksP2;

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
        pauseMenuText.text = "GAME OVER \n\n" + this.gameObject.name + " looses";
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
