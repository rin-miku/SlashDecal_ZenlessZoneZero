using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject decalPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject temp = Instantiate(decalPrefab);
        temp.transform.position = collision.contacts[0].point;
    }
}
