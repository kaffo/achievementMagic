using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceParent : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (transform.parent == null)
        {
            Debug.LogError(this.name + " on " + this.gameObject + " has not been setup correctly!");
            this.enabled = false;
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent)
        {
            transform.rotation = Quaternion.LookRotation(transform.position - transform.parent.position, Vector3.up);
        }
    }
}
