﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinit_Generator : MonoBehaviour
{
    public Vector3 offset, poz;
    public Transform player;
    private float lenght,time;
    public int rand;
    private GameObject clone;
    [SerializeField]private GameObject ground;
    [SerializeField] private GameObject[] obstacole=new GameObject[7];

    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
        lenght = ground.transform.localScale[2];
        poz = new Vector3(3.55f, 1f, 0f);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        lenght = ground.transform.position.z;
        poz.z = player.position.z;
        
        if (((lenght)/2)-20f < player.position.z)
        {
            Instantiate(ground,offset , Quaternion.identity);
            rand = Random.Range(0, 6);
            poz.z += 20f;
            offset += new Vector3(0, 0, lenght);
            clone = Instantiate(obstacole[rand], poz, Quaternion.identity);
            time = time + Time.fixedDeltaTime;
            if (time > 10.0f)
            {
                Destroy(clone);
                time = 0.0f;
            }
        }
    }
}
