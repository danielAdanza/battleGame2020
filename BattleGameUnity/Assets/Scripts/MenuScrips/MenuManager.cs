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
}
