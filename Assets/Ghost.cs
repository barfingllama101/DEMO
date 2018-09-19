using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
    public float health;
    Renderer currentRenderer;
    public Ghost me;
    bool hasChild;
    public static float MAXHEALTH;
   // public float damage;
    public GhostStates currentState = GhostStates.ATTACK;
    // Use this for initialization
    void Start () {
       this.health = 100;
        hasChild = false;
        
	}

    public float healthPercent{
        get{ return health / MAXHEALTH; }
    }
    public bool attacking{
        get{
            return currentState == GhostStates.ATTACK;
        }
    }
    private void OnCollisionEnter(Collision other)
    { //make sure you can only possess a child if you aren't possessing one already
        //makes child not visible and so you can't collide with it. 
        if(other.gameObject.tag == "child" && me.hasChild==false){
            other.transform.parent = transform;
            //other.gameObject.renderer.
            // currentRenderer = GetComponentInChildren<Renderer>();
            currentRenderer = other.gameObject.GetComponent<Renderer>();
            currentRenderer.enabled = false;
            other.collider.enabled = false;
            hasChild = true;
            //other.gameObject.SetActive(false);
        }else if(other.gameObject.tag == "child" && me.hasChild == true){
            //nope u already know what it is 
        }
      /*  else if(other.gameObject.tag == "ghost"){
            Ghost otherGhost = other.gameObject.GetComponent<Ghost>();
           /* if(other.transform.childCount > 0){
               this.health = this.health - 1;
                print(this.health + "hi");
            }*//*
            if(otherGhost != null && otherGhost != me && hasChild == true){
                Debug.Log("I hit" + otherGhost);
            }
        }*/
    }
    /*  private void OnTriggerEnter(Collider other)
      {
         //if(me.attacking){
              if (other.gameObject.tag == "ghost")
              {
                  Ghost otherGhost = other.gameObject.GetComponent<Ghost>();
                  /* if(other.transform.childCount > 0){
                      this.health = this.health - 1;
                       print(this.health + "hi");
                   }*//*
                  if (otherGhost != null && otherGhost != me && hasChild == true)
                  {
                     // otherGhost.hurt(damage);

                      Debug.Log("I hit" + otherGhost + "hkjhk");
                  }
              }
        //  }
      }*/
 //this is pretty self explanatory but you know like health n shit 
    public virtual void hurt(float damage)
    { 
        if (!invulnerable)
        {
            if (health >= damage)
            {
                //subscribe n d e l e t (not delete like just subtract tho)
                health -= damage;
            }
            else
            {
                health = 0;
            }
            if (health > 0)
            {
                //animation for later
            }
        }
    }
    //if not attack basically for now this stuff is mostly for animation purposes later on
    public bool invulnerable{
        get{
            return currentState == GhostStates.TAKE_HIT || currentState == GhostStates.DEFEND || currentState == GhostStates.DEAD;
        }
    }

}
