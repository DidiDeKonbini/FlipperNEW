using UnityEngine;

public class BunusFrame : MonoBehaviour
{
    public int scoreToAdd = 10;
    
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(scoreToAdd);
    }
}
