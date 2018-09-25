using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterTagSetter : MonoBehaviour {

    [SerializeField]
    private string invalidTag;
    [SerializeField]
    private string validTag;
    [SerializeField]
    private Material validMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == invalidTag)
        {
            collision.transform.tag = validTag;
            collision.gameObject.GetComponent<Renderer>().sharedMaterial = validMaterial;
        }
    }

}
