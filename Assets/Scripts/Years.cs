using UnityEngine;
using UnityEngine.SceneManagement;

public class Years : MonoBehaviour
{
	public GameObject back;

	public GameObject e;

	public GameObject r;

	public GameObject[] years;

	public float stop = 1;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if (stop > 2f)
		{
			back.SetActive(value: true);
		}
		else
		{
			back.SetActive(value: false);
		}
		if (Input.GetKeyDown(KeyCode.E) && stop < 32f)
		{
			stop += 1f;
		}
		if (Input.GetKeyDown(KeyCode.Q) && stop >= 2f)
		{
			stop -= 1f;
		}
		if (stop == 1)
		{
			years[0].SetActive(value: true);
		}
		else
		{
			years[0].SetActive(value: false);
		}
		if (stop == 2f)
		{
			years[1].SetActive(value: true);
		}
		else
		{
			years[1].SetActive(value: false);
		}
		if (stop == 3f)
		{
			years[2].SetActive(value: true);
		}
		else
		{
			years[2].SetActive(value: false);
		}
		if (stop == 4f)
		{
			years[3].SetActive(value: true);
		}
		else
		{
			years[3].SetActive(value: false);
		}
		if (stop == 5f)
		{
			years[4].SetActive(value: true);
		}
		else
		{
			years[4].SetActive(value: false);
		}
		if (stop == 6f)
		{
			years[5].SetActive(value: true);
		}
		else
		{
			years[5].SetActive(value: false);
		}
		if (stop == 7)
		{
			years[6].SetActive(value: true);
		}
		else
		{
			years[6].SetActive(value: false);
		}
		if (stop == 8f)
		{
			years[7].SetActive(value: true);
		}
		else
		{
			years[7].SetActive(value: false);
		}
		if (stop == 9f)
		{
			years[8].SetActive(value: true);
		}
		else
		{
			years[8].SetActive(value: false);
		}
		if (stop == 10f)
		{
			years[9].SetActive(value: true);
		}
		else
		{
			years[9].SetActive(value: false);
		}
		if (stop == 11f)
		{
			years[10].SetActive(value: true);
		}
		else
		{
			years[10].SetActive(value: false);
		}
		if (stop == 12f)
		{
			years[11].SetActive(value: true);
		}
		else
		{
			years[11].SetActive(value: false);
		}
		if (stop == 13f)
		{
			years[12].SetActive(value: true);
		}
		else
		{
			years[12].SetActive(value: false);
		}
		if (stop == 14f)
		{
			years[13].SetActive(value: true);
		}
		else
		{
			years[13].SetActive(value: false);
		}
		if (stop == 15f)
		{
			years[14].SetActive(value: true);
		}
		else
		{
			years[14].SetActive(value: false);
		}
		if (stop == 16f)
		{
			years[15].SetActive(value: true);
		}
		else
		{
			years[15].SetActive(value: false);
		}
		if (stop == 17f)
		{
			years[16].SetActive(value: true);
		}
		else
		{
			years[16].SetActive(value: false);
		}
		if (stop == 18f)
		{
			years[17].SetActive(value: true);
		}
		else
		{
			years[17].SetActive(value: false);
		}
		if (stop == 19f)
		{
			years[18].SetActive(value: true);
		}
		else
		{
			years[18].SetActive(value: false);
		}
		if (stop == 20f)
		{
			years[19].SetActive(value: true);
		}
		else
		{
			years[19].SetActive(value: false);
		}
		if (stop == 21f)
		{
			years[20].SetActive(value: true);
		}
		else
		{
			years[20].SetActive(value: false);
		}
		if (stop == 22f)
		{
			years[21].SetActive(value: true);
		}
		else
		{
			years[21].SetActive(value: false);
		}
		if (stop == 23f)
		{
			years[22].SetActive(value: true);
		}
		else
		{
			years[22].SetActive(value: false);
		}
		if (stop == 24f)
		{
			years[23].SetActive(value: true);
		}
		else
		{
			years[23].SetActive(value: false);
		}
		if (stop == 25f)
		{
			years[24].SetActive(value: true);
		}
		else
		{
			years[24].SetActive(value: false);
		}
		if (stop == 26f)
		{
			years[25].SetActive(value: true);
		}
		else
		{
			years[25].SetActive(value: false);
		}
		if (stop == 27f)
		{
			years[26].SetActive(value: true);
		}
		else
		{
			years[26].SetActive(value: false);
		}
		if (stop == 28f)
		{
			years[27].SetActive(value: true);
		}
		else
		{
			years[27].SetActive(value: false);
		}
		if (stop == 29f)
		{
			years[28].SetActive(value: true);
		}
		else
		{
			years[28].SetActive(value: false);
		}
		if (stop == 30f)
		{
			years[29].SetActive(value: true);
		}
		else
		{
			years[29].SetActive(value: false);
		}
		if (stop == 31f)
		{
			years[30].SetActive(value: true);
		}
		else
		{
			years[30].SetActive(value: false);
		}
		if (stop == 32f)
		{
			e.SetActive(value: false);
			r.SetActive(value: true);
			if (Input.GetKeyDown(KeyCode.R))
			{
				SceneManager.LoadScene(1);
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
