using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = player.position + offset;
    }
}
