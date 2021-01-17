using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Image characterImage;
    public Image scenarioImage;
    public Image gameModeImage;

    public GameObject characterGameObject;
    public GameObject scenarioGameObject;
    public GameObject gameModeGameObject;

    //Game Mode Section
    public Text numberOfLifes;
    public Text numberOfMinutes;
    public Image lifesImage;
    public Image minutesImage;

    //Character stats selection
    public GameObject characterStats;

    public void Start()
    {
        characterImage.color = Color.yellow;

        PlayerPrefs.SetInt("numberOfLifes", 3);
        PlayerPrefs.SetInt("numberOfMinutes", 3);
        PlayerPrefs.SetString("mode", "lifes");
    }

    public void WhenCharacterIsClicked ()
    {
        characterImage.color = Color.yellow;
        scenarioImage.color = Color.white;
        gameModeImage.color = Color.white;

        characterGameObject.SetActive(true);
        scenarioGameObject.SetActive(false);
        gameModeGameObject.SetActive(false);
    }

    public void WhenScenarioIsClicked()
    {
        characterImage.color = Color.white;
        scenarioImage.color = Color.yellow;
        gameModeImage.color = Color.white;

        characterGameObject.SetActive(false);
        scenarioGameObject.SetActive(true);
        gameModeGameObject.SetActive(false);
    }

    public void WhenGameModeIsClicked()
    {
        characterImage.color = Color.white;
        scenarioImage.color = Color.white;
        gameModeImage.color = Color.yellow;

        characterGameObject.SetActive(false);
        scenarioGameObject.SetActive(false);
        gameModeGameObject.SetActive(true);
    }

    public void WhenPlayIsClicked()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void ChangeLifes (int number)
    {
        int lifes = PlayerPrefs.GetInt("numberOfLifes") + number;

        //controlling the maximum and the minimum for the lifes
        if (lifes < 0)
        { lifes = 0; }
        else if (lifes > 50)
        { lifes = 50;  }

        PlayerPrefs.SetInt("numberOfLifes", lifes);

        numberOfLifes.text = "" + PlayerPrefs.GetInt("numberOfLifes");

        this.ChangeGameMode("lifes");
    }

    public void ChangeMinutes(int number)
    {
        int minutes = PlayerPrefs.GetInt("numberOfMinutes") + number;

        //controlling the maximum and the minimum for the lifes
        if (minutes < 0)
        { minutes = 0; }
        else if (minutes > 50)
        { minutes = 50;  }

        PlayerPrefs.SetInt("numberOfMinutes", minutes );

        numberOfMinutes.text = "" + PlayerPrefs.GetInt("numberOfMinutes");

        this.ChangeGameMode("time");
    }

    public void ChangeGameMode (string gamemode)
    {
        if (gamemode == "lifes")
        {
            lifesImage.color = Color.yellow;
            minutesImage.color = Color.white;
            PlayerPrefs.SetString("gameMode", gamemode);

        }
        else if (gamemode == "time")
        {
            lifesImage.color = Color.white;
            minutesImage.color = Color.yellow;
            PlayerPrefs.SetString("gameMode", gamemode);
        }
    }

    public void changeControllers(int player, int mode)
    {
        PlayerPrefs.SetInt("controlsPlayer" + player, mode);

        Debug.Log( "controlsPlayer" + player );
        Debug.Log( PlayerPrefs.GetInt("controlsPlayer" + player ) );
    } 

    public void OpenAndCloseCharacterStats (bool open)
    {
         characterStats.SetActive(open);
    }
}
