using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int health = 0;
    public Text ScoreUI;
    public Text HealthUI;
  
    
        public void CoinScore()
    {
        score++;
        ScoreUI.text = "Score: " + score;
    }
    public void BottleScore()
    {
        health = health + 5;
        HealthUI.text = "Health: " + health;
    }
}