using System.Collections;
using UnityEngine;

public class Bumper : MonoBehaviour
{
	public float       strength   = 1;
	public int         scoreToAdd = 10;
	public Animation   anim;
	public AudioSource audioSource;

	void OnCollisionEnter(Collision other)
	{
		Vector3 direction = other.transform.position - transform.position;
		other.rigidbody.AddForce(direction.normalized * strength, ForceMode.Impulse);

		ScoreManager.instance.AddScore(scoreToAdd);
		anim.Play();
		audioSource.Play();
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