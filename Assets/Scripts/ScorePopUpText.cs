using System.Collections;
using TMPro;
using UnityEngine;

public class ScorePopUp : MonoBehaviour
{
	[SerializeField] TMP_Text scoreText;
	[SerializeField] Animation anim;

	public void UpdateScore(int bumperScore)
	{
		scoreText.text = bumperScore.ToString();
	}

	public IEnumerator Destroyer()
	{
		yield return new WaitForSeconds(0.6f);
		Destroy(gameObject);
	}
}
