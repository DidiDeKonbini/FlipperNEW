using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] int        ballCount = 3;
	public           GameObject ballPrefab;
	public           Transform  spawner;
	public           KeyCode    menuKey = KeyCode.Escape;
	public           bool       isMenuOpen;
	public           GameObject menuGO;

	public void Start()
	{
		CreateBall();
	}

	public void LoseBall(GameObject ball)
	{
		ballCount = ballCount - 1;

		Destroy(ball);

		if (ballCount < 0)
		{
			Debug.Log("Game Over");
		}
		else
		{
			CreateBall();
		}
	}

	void CreateBall()
	{
		GameObject ballInstance = Instantiate(ballPrefab, spawner.position, Quaternion.identity, transform);
	}

	void Update()
	{
		if (Input.GetKeyDown(menuKey))
		{
			ChangeMenuState();
		}
	}
	
	public void ChangeMenuState()
	{
		isMenuOpen = !isMenuOpen;

		menuGO.SetActive(isMenuOpen);

		if (isMenuOpen)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
	}

	public void Restart()
	{
		Time.timeScale = 1;
		Application.LoadLevel(Application.loadedLevel);
	}

	public void Quit()
	{
		Application.Quit();
	}
}