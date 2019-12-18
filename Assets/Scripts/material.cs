using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material : MonoBehaviour
{
    void Start()
    {
        if(Data.nou!=null)
            gameObject.GetComponent<MeshRenderer>().material = Data.nou;
    }

    
}
