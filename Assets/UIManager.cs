using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public Text p1;
    public Text p2;
    public Ghost g1;
    public Ghost g2;

    //I love you guys but if I have to explain this then idk what to tell you 
    //plz 
	
	void Update () {
        p1.text = "health: "+ g1.health.ToString();
        p2.text ="health: "+ g2.health.ToString();
       

    }
}
