using UnityEngine;

public class BunusFrame : MonoBehaviour
{
    public           int scoreToAdd = 10;
    [SerializeField] Animation anim;
    
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(scoreToAdd);
        anim.Play();
    }
}
