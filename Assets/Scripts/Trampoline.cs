using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] int strength = 35;
    public int scoreToAdd = 10;
    public Animation anim;
    public GameObject bounceDirection;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rigidbody rb  =  other.GetComponent<Rigidbody>();
            Vector3   dir = (bounceDirection.transform.position - transform.position).normalized;
            rb.AddForce(dir * strength, ForceMode.Impulse);   
            anim.Play();
        }

        ScoreManager.instance.AddScore(scoreToAdd);
    }
}
