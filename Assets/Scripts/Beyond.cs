using UnityEngine;
using UnityEngine.SceneManagement;

public class Beyond : MonoBehaviour
{
	public float stop;

	public GameObject beyond;

	public GameObject back;

	private void OnTriggerEnter(Collider other)
	{
		switch (stop)
		{
			case 1f:
				beyond.SetActive(value: true);
				Invoke(nameof(Beyond.SceneChanger), 4f);
				break;
			case 2f:
				back.SetActive(value: true);
				Invoke(nameof(Beyond.SceneChanger), 4f);
				break;
		}
	}

	public void SceneChanger()
	{
		SceneManager.LoadScene(0);
	}
}
