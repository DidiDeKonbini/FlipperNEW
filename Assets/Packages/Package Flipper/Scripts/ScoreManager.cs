using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public float             score;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        RefreshText();
    }

    public void AddScore(float scoreToAdd)
    {
        score += scoreToAdd;
        RefreshText();
    }
    
    public void MultiplyScore(float multiplier)
    {
        score += (score * multiplier);
        RefreshText();
    }
    
    void RefreshText()
    {
        scoreText.text = "Score: " +  score;
    }
   
}
