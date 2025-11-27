using System;
using System.Collections;
using MoreMountains.Feedbacks;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject  explosion;
    [SerializeField] MMFeedbacks anim;

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ExplosionCoroutine());
        explosion.SetActive(true);
        anim?.PlayFeedbacks();
    }
    
    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(wall);
    }
}
