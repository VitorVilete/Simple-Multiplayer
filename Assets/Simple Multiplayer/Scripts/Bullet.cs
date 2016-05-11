using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    void OnCollisionEnter(Collision col) {
        GameObject hit = col.gameObject;
        Health health = hit.GetComponent<Health>();
        //if bullet hits something that has health
        if (health != null)
        {
            health.TakeDamage(10);
        }
        Destroy(gameObject);
    }
}
