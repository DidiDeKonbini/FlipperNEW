using UnityEngine;

public class DeathZone : MonoBehaviour
{
	public GameManager gameManager;
	
	void OnTriggerEnter(Collider other)
	{
		//Debug.Log(other.gameObject.name);
		gameManager.LoseBall(other.gameObject);
	}
}
