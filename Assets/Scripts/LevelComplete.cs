using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel ()
	{
        if (SceneManager.GetActiveScene().buildIndex + 1 == 6)
            SceneManager.LoadScene(7);
        else
		    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
