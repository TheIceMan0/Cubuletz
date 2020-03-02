using System.Collections;
using UnityEngine;



public class Infinit_Generator : MonoBehaviour
{
    public Vector3 offset,poz,poz_grd;
    public Transform player;
    [SerializeField] private float lenght;
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
        
        poz.z = player.position.z;
        //Invoke("Destroy", 8);
        if (lenght-player.position.z<=80f)
        {
            //player.position.z+=1;
            poz_grd.z = lenght;
            poz.z += 40f;
            Instantiate(ground, poz_grd, Quaternion.identity);
            lenght += 120;
            clone = Instantiate(obstacole[rand], poz, Quaternion.identity);
        }
        if (lenght - player.position.z <= 40f)
        {
            clone = Instantiate(obstacole[rand], poz, Quaternion.identity);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag=="ground")
            Destroy(collision.gameObject);
    }
}
