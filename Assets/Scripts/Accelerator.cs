using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public           float     strength   = 100f;
    public           int       scoreToAdd = 4;
    [SerializeField] Animation anim;
    void OnTriggerEnter(Collider other)
    {
        Poussée(other.attachedRigidbody);
        ScoreManager.instance.AddScore(scoreToAdd);
        anim.Play();
    }

    public void Poussée(Rigidbody rb)
    {
        rb.GetComponent<Rigidbody>();
        rb.AddForce(transform.up*strength, ForceMode.Acceleration);
    }
}
