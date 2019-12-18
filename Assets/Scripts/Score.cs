using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
    //public Text Banut;
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update () {
		scoreText.text = player.position.z.ToString("0");
       // Banut.text = k.ToString("0");
    }
}
