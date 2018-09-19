using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HitCollider : MonoBehaviour {
    public string punchName;
    public float damage;
    public Ghost me;
    
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (me.attacking)
        {
            Ghost otherGhost = other.gameObject.GetComponent<Ghost>();
            if (otherGhost != null && otherGhost != me)
            {
                otherGhost.hurt(damage);
                Debug.Log("I hit" + otherGhost);
               // Debug.Log(damage);

            }
        }
    }
}
