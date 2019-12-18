using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        GameObject go = Instantiate(player, new Vector3(0, 1, 0), Quaternion.identity);
        go.transform.parent = GameObject.Find("Player_pref").transform;
        go.name = go.name.Replace("(Clone)", "");
    }
}
