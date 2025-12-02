using System.Collections;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public           float     strength   = 100f;
    public           int       scoreToAdd = 4;
    [SerializeField] Animation anim;
    void OnTriggerEnter(Collider other)
    {
        Push(other.attachedRigidbody);
        ScoreManager.instance.AddScore(scoreToAdd);
        anim.Play();
        PopUp();
    }

    void PopUp()
    {
        GameObject save = Instantiate(ScoreManager.instance.scorePopUpPrefab, transform.GetChild(0).position, Quaternion.identity);
        ScorePopUp savePop = save.GetComponent<ScorePopUp>();
        savePop.UpdateScore(scoreToAdd);
        savePop.StartCoroutine(savePop.Destroyer());
    }

    public void Push(Rigidbody rb)
    {
        rb.GetComponent<Rigidbody>();
        rb.AddForce(transform.up*strength, ForceMode.Acceleration);
    }
}
