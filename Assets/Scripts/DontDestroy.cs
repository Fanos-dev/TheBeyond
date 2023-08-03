using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	private void Awake()
	{
		if (GameObject.FindGameObjectsWithTag($"music").Length > 1)
		{
			Object.Destroy(gameObject);
		}
		Object.DontDestroyOnLoad(gameObject);
	}
}
