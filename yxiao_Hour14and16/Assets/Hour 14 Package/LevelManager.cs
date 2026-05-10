using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "yxiao_Hour16";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
