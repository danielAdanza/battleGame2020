using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarksController : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image healthBarImage;
    public Text totalDeathsText;
    private int totalDeaths = 0;
    public GameObject pauseMenuUI;
    public Text pauseMenuText;

    public void Start ()
    {
        PlayerPrefs.SetInt("numberOfLifes", 3);
        totalDeaths = PlayerPrefs.GetInt("numberOfLifes");
        healthBarImage.color = gradient.Evaluate(1f);
        totalDeathsText.text = "" + totalDeaths;
    }

    public void SetMaxHealth(int maxValue)
    {
        slider.maxValue = maxValue;
        slider.value = maxValue;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        healthBarImage.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void resurrection ()
    {
        slider.value = slider.maxValue;
        healthBarImage.color = gradient.Evaluate(1f);
        totalDeaths--;

        totalDeathsText.text = "" + totalDeaths;

        if (totalDeaths <= 0)
        {
            pauseMenuUI.SetActive(true);
            pauseMenuText.text = "GAME OVER \n\n" +this.gameObject.name + " looses";
        }
    }
}
