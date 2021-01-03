using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenericMarksController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Text pauseMenuText;

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
}
