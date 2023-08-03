using UnityEngine;

public class StartMenu : MonoBehaviour
{
	public GameObject start;

	public GameObject aboutMenu;

	public GameObject tutorialMenu;

	public GameObject yearsMenu;

	private void Start()
	{
		Time.timeScale = 0f;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			Time.timeScale = 1f;
			yearsMenu.SetActive(value: true);
			start.SetActive(value: false);
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	public void About()
	{
		start.SetActive(value: false);
		aboutMenu.SetActive(value: true);
	}

	public void Tutorial()
	{
		start.SetActive(value: false);
		tutorialMenu.SetActive(value: true);
	}

	public void BackAbout()
	{
		start.SetActive(value: true);
		aboutMenu.SetActive(value: false);
	}

	public void BackTutorial()
	{
		start.SetActive(value: true);
		tutorialMenu.SetActive(value: false);
	}
}
