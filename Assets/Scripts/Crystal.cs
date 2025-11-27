using UnityEngine;

public class Crystal : MonoBehaviour
{
    public float     strength   = 1f;
    public float       multiplier = 1.2f;
    public Animation anim;

    void OnCollisionEnter(Collision other)
    {
        Vector3 direction = other.transform.position - transform.position;
        other.rigidbody.AddForce(direction.normalized * strength, ForceMode.Impulse);

        ScoreManager.instance.AddScore(multiplier);
        anim.Play();
    }
}
