using System.Collections;
using TMPro;
using UnityEngine;

public class ScorePopUp : MonoBehaviour
{
	[SerializeField] TMP_Text scoreText;
	[SerializeField] Animation anim;

	public void UpdateScore(int bumperScore)
	{
		anim.Play("ScorePopUp");
		scoreText.text = bumperScore.ToString();
	}

	public IEnumerator Destroyer()
	{
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
}
