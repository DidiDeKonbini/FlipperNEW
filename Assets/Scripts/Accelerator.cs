using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public float strength = 100f;
    void OnTriggerEnter(Collider other)
    {
        Poussée(other.attachedRigidbody);
    }

    public void Poussée(Rigidbody rb)
    {
        rb.GetComponent<Rigidbody>();
        rb.AddForce(transform.up*strength, ForceMode.Acceleration);
    }
}
