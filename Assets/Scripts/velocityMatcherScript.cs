using UnityEngine;
using System.Collections;

public class velocityMatcherScript : MonoBehaviour 
{

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x,col.gameObject.GetComponent<Rigidbody>().velocity.y,GetComponent<Rigidbody>().velocity.z);
            //col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x,GetComponent<Rigidbody>().velocity.y,GetComponent<Rigidbody>().velocity.z);
        }
    }

    /*void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,col.gameObject.GetComponent<Rigidbody>().velocity.y,0);
        }
    }*/
}
