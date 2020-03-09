using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour {

	bool gameHasEnded = false;
    public PlayerCollision coll;
    
	public float restartDelay;

	public GameObject completeLevelUI;

    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        coll = GameObject.Find("Player").GetComponent<PlayerCollision>();
    }
    public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);

	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
            Data.banuti -= coll.bani;
        }
        Debug.Log(coll.bani);
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
