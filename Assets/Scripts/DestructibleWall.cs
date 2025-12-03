using System;
using System.Collections;
using MoreMountains.Feedbacks;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
    [SerializeField] GameObject  wall;
    [SerializeField] GameObject  explosion;
    [SerializeField] MMFeedbacks anim;
    public           AudioSource audioSource;


    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ExplosionCoroutine());
        explosion.SetActive(true);
        anim?.PlayFeedbacks();
        audioSource.Play();
    }
    
    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(wall);
    }
}
