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
    public Text totalKillsText;
    private int totalKills = 0;
    public GenericMarksController genericMarks;

    public void Start ()
    {
        if (PlayerPrefs.GetString("gameMode") == "lifes")
        {
            totalDeaths = PlayerPrefs.GetInt("numberOfLifes");
        } else if (PlayerPrefs.GetString("gameMode") == "time")
        {
            totalDeaths = 0;
        }
            
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

    public void resurrection (string agresorTag)
    {
        slider.value = slider.maxValue;
        healthBarImage.color = gradient.Evaluate(1f);
        if (PlayerPrefs.GetString("gameMode") == "lifes")
        { totalDeaths--; }
        else if (PlayerPrefs.GetString("gameMode") == "time")
        { totalDeaths++; }
        

        totalDeathsText.text = "" + totalDeaths;

        genericMarks.AddKill(agresorTag);

        if (PlayerPrefs.GetString("gameMode") == "lifes" && totalDeaths <= 0)
        {
            genericMarks.WhenGameOver();
        }
    }

    public void IncreaseKills ()
    {
        totalKills++;
        totalKillsText.text = "" + totalKills;
    }

    public int GetTotalDeaths ()
    {
        return totalDeaths;
    }

    public int GetTotalKills ()
    {
        return totalKills;
    }
}
