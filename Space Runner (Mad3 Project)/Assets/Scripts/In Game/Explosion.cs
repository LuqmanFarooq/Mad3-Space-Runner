using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    
    void IveBeenHit(Vector3 pos)
    {
        GameObject go = Instantiate(explosion, pos, Quaternion.identity, transform) as GameObject;
        Destroy(go, 6f);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Asteroid"))
        {
            foreach (ContactPoint contact in collision.contacts)
                IveBeenHit(contact.point);
            Destroy(gameObject, 2);
        }

    }
}
