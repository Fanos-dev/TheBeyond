using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	private void Awake()
	{
		if (GameObject.FindGameObjectsWithTag("music").Length > 1)
		{
			Object.Destroy(base.gameObject);
		}
		Object.DontDestroyOnLoad(base.gameObject);
	}
}
