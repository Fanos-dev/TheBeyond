using UnityEngine;
using UnityEngine.SceneManagement;

public class Beyond : MonoBehaviour
{
	public float stop;

	public GameObject beyond;

	public GameObject back;

	private void OnTriggerEnter(Collider other)
	{
		if (stop == 1f)
		{
			beyond.SetActive(value: true);
			Invoke("SceneChanger", 4f);
		}
		else if (stop == 2f)
		{
			back.SetActive(value: true);
			Invoke("SceneChanger", 4f);
		}
	}

	public void SceneChanger()
	{
		SceneManager.LoadScene(0);
	}
}
