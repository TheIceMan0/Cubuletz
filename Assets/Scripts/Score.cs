using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	[SerializeField]private Transform player;
	[SerializeField]private Text scoreText;
	protected float score;
    //public Text Banut;
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    public float GetScore()
    {
        return score;
    }
    // Update is called once per frame
    void Update () {

        score = player.position.z;
        scoreText.text=score.ToString("0");
    }
}
