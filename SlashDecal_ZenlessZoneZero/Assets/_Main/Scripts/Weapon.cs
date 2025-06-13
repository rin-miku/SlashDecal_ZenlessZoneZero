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
        foreach (ContactPoint contact in collision.contacts)
        {
            Vector3 hitPoint = contact.point;
            Vector3 hitNormal = contact.normal;

            Debug.Log("Hit point: " + hitPoint);
            Debug.DrawRay(hitPoint, hitNormal, Color.red, 1f);
        }
    }
}
