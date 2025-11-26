using System.Collections;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public KeyCode  key = KeyCode.E;
    public GameObject explosion;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            explosion.SetActive(true);
            StartCoroutine(ExplosionCoroutine());
        }
    }

    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        explosion.SetActive(false);
        GameManager.instance.LoseBall(gameObject);
    }
}
