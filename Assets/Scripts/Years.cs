using UnityEngine;
using UnityEngine.SceneManagement;

public class Years : MonoBehaviour
{
	public GameObject back;

	public GameObject e;

	public GameObject r;

	public GameObject[] years;

	public int stop = 1;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		back.SetActive(value: stop > 2);
		if (Input.GetKeyDown(KeyCode.E) && stop < 32f)
		{
			stop += 1;
		}
		if (Input.GetKeyDown(KeyCode.Q) && stop >= 2f)
		{
			stop -= 1;
		}
		years[0].SetActive(value: stop == 1);
		years[1].SetActive(value: stop == 2);
		years[2].SetActive(value: stop == 3);
		years[3].SetActive(value: stop == 4);
		years[4].SetActive(value: stop == 5);
		years[5].SetActive(value: stop == 6);
		years[6].SetActive(value: stop == 7);
		years[7].SetActive(value: stop == 8);
		years[8].SetActive(value: stop == 9);
		years[9].SetActive(value: stop == 10);
		years[10].SetActive(value: stop == 11);
		years[11].SetActive(value: stop == 12);
		years[12].SetActive(value: stop == 13);
		years[13].SetActive(value: stop == 14);
		years[14].SetActive(value: stop == 15);
		years[15].SetActive(value: stop == 16);
		years[16].SetActive(value: stop == 17);
		years[17].SetActive(value: stop == 18);
		years[18].SetActive(value: stop == 19);
		years[19].SetActive(value: stop == 20);
		years[20].SetActive(value: stop == 21);
		years[21].SetActive(value: stop == 22);
		years[22].SetActive(value: stop == 23);
		years[23].SetActive(value: stop == 24);
		years[24].SetActive(value: stop == 25);
		years[25].SetActive(value: stop == 26);
		years[26].SetActive(value: stop == 27);
		years[27].SetActive(value: stop == 28);
		years[28].SetActive(value: stop == 29);
		years[29].SetActive(value: stop == 30);
		years[30].SetActive(value: stop == 31);
		if (stop == 32)
		{
			e.SetActive(value: false);
			r.SetActive(value: true);
			if (Input.GetKeyDown(KeyCode.R))
			{
				SceneManager.LoadScene(sceneBuildIndex: 1);
			}
			years[31].SetActive(value: true);
		}
		else
		{
			years[31].SetActive(value: false);
			e.SetActive(value: true);
			r.SetActive(value: false);
		}
	}
}
