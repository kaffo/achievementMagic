using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParentOnStart : MonoBehaviour
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

        transform.parent = targetTransform;
    }
}
