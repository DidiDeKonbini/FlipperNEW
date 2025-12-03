using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static    GameManager     instance;
	[SerializeField] int             ballCount = 3;
	public           GameObject      ballPrefab;
	public           Transform       spawner;
	public           KeyCode         menuKey = KeyCode.Escape;
	public           bool            isMenuOpen;
	public           GameObject      mainMenu;
	public           GameObject      gameOverMenu;
	public           GameObject      startMenu;
	public           bool            isStartMenuOpen;
	public           TextMeshProUGUI lifeCountText;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Debug.LogError("Game Manager Instance already exists");
			Destroy(this);
		}
	}

	public void Start()
	{
		CreateBall();
		lifeCountText.text = "Lives left: " + ballCount;
		Time.timeScale = 0;
	}

	public void LoseBall(GameObject ball)
	{
		ballCount          = ballCount      - 1;
		lifeCountText.text = "Lives left: " + ballCount;
		
		Destroy(ball);

		if (ballCount < 0)
		{
			gameOverMenu.SetActive(true);
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

		mainMenu.SetActive(isMenuOpen);

		if (isMenuOpen)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
	}
	
	public void ChangeStartMenuState()
	{
		isStartMenuOpen = !isStartMenuOpen;

		startMenu.SetActive(isStartMenuOpen);

		if (isStartMenuOpen)
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