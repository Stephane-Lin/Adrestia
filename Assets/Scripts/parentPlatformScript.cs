using UnityEngine;
using System.Collections;

public class parentPlatformScript : MonoBehaviour 
{

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.transform.SetParent(transform);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.transform.SetParent(null);
        }
    }
    
}
