using UnityEngine;

public class Select_Mat: MonoBehaviour
{
    void Start()
    {
        if(Data.nou!=null)
            gameObject.GetComponent<MeshRenderer>().material = Data.nou;
    }
}
