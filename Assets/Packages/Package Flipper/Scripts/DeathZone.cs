using UnityEngine;

public class DeathZone : MonoBehaviour
{
	public GameManager gameManager;
	
	void OnTriggerEnter(Collider other)
	{
		gameManager.LoseBall(other.gameObject);
	}
}
