using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform targetTransform;

    // Start is called before the first frame update
    void Start()
    {
        if (targetTransform == null)
        {
            Debug.LogError(this.name + " on " + this.gameObject + " has not been setup correctly!");
            this.enabled = false;
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(targetTransform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
