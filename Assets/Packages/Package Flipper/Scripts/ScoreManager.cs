using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager    instance;
    public        TextMeshProUGUI scoreText;
    public        float           score;
    public        GameObject      scorePopUpPrefab;
    public        TextMeshProUGUI scoreGameOverText;


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
        score = (score * multiplier);
        RefreshText();
    }
    
    void RefreshText()
    {
        scoreText.text = "Score: " +  score;
        scoreGameOverText.text = "Score final: " + score;
    }
   
}
