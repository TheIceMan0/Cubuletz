using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinit_Generator : MonoBehaviour
{
    public Vector3 offset, poz;
    public Transform player;
    private float lenght;
    public int rand;
    private GameObject clone;
    [SerializeField]private GameObject ground;
    [SerializeField] private GameObject[] obstacole=new GameObject[7];

    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
        lenght = ground.transform.localScale[2];
        poz = new Vector3(3.5f, 1f, 0f);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
    }

    private void Destroy()
    {
        Destroy(clone);
    }

    void Update()
    {
        lenght = ground.transform.localScale[2];
        poz.z = player.position.z;
        //Invoke("Destroy", 8);
        if (((lenght)/2)-20f < player.position.z)
        {
            ground.transform.localScale += offset;
            rand = Random.Range(0, 6);
            poz.z += 30f;
            clone=Instantiate(obstacole[rand], poz, Quaternion.identity);
        }
        
            
    }
}
