using System.Collections;
using UnityEngine;



public class Infinit_Generator : MonoBehaviour
{
    public Vector3 offset,poz,cop_poz,poz_grd;
    public Transform player;
    [SerializeField] private float lenght, delay=0.0f;
    public int rand;
    private GameObject clone;
    public GameObject ground;
    [SerializeField] private GameObject[] obstacole = new GameObject[7];
    // Update is called once per frame

    void Start()
    {
        StartCoroutine(ExecuteAfterTime(0.01f));
        lenght = 120;
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        player = GameObject.Find("Player").transform;
    }
    // Update is called once per frame

    void Update()
    {
        rand = Random.Range(0, 7);
        poz.z = player.position.z;
        poz.z += 30f;
        
        //Invoke("Destroy", 8);
        if (lenght-player.position.z<=100f)
        {
            poz_grd.z = lenght;
            poz_grd.y -= 0.01f;

            Instantiate(ground, poz_grd, Quaternion.identity);
            lenght += 120;
        }
        delay += Time.deltaTime;

        if (delay > 2.0f&&cop_poz!=poz) { 
            Instantiate(obstacole[rand], poz, Quaternion.identity);
            delay = 0f;
            cop_poz = poz;
        }
    }
    
}
