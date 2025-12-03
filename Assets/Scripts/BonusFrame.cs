using System.Collections;
using UnityEngine;

public class BunusFrame : MonoBehaviour
{
    public           int scoreToAdd = 10;
    [SerializeField] Animation anim;
    
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(scoreToAdd);
        anim.Play();
        StartCoroutine(popUp());
    }

    private IEnumerator popUp()
    {
        GameObject save = Instantiate(ScoreManager.instance.scorePopUpPrefab, transform.position, Quaternion.identity);
        save.GetComponent<ScorePopUp>().UpdateScore(scoreToAdd);
        yield return new WaitForSeconds(0.6f);
        Destroy(save);
    }
}
