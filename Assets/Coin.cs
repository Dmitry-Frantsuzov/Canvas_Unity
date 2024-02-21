using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(5, 0, 0);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
