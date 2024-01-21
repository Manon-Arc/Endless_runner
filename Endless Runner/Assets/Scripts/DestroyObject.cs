using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("obstacle"))
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("coin"))
        {
            Destroy(col.gameObject);
        }
    }
}
