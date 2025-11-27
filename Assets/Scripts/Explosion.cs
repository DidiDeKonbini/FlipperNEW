using System.Collections;
using MoreMountains.Feedbacks;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public           KeyCode     key = KeyCode.E;
    [SerializeField] GameObject  explosion;
    [SerializeField] MMFeedbacks anim;


    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            explosion.SetActive(true);
            StartCoroutine(ExplosionCoroutine());
            anim?.PlayFeedbacks();
        }
    }

    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        explosion.SetActive(false);
        GameManager.instance.LoseBall(gameObject);

    }
    
}
