using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character : MonoBehaviour {

    public int lifecount;
    private characterchoice cchoice;
   // private List<string> characterChoice = new List<string>();
	void Start () {
        //   string character = characterChoice[Random.Range(0, characterChoice.Count)];
        // get the random and evaluate 
        cchoice = (characterchoice)Random.Range(0, 3);
        //where we evaluate
        switch (cchoice){
            //the cases will eventually be evaluated jsut by selecting random on an arraylist of the subclasses 
            //lifecount doesn't mean much now and will be moved to the subclasses later on. This was pretty much for debugging stuff
            //if selected (s) from the enum, create new obj of the costume 
            case characterchoice.bat:
                lifecount = 10;
                print(lifecount);
                Bat b = new Bat();
                b.printme();
                break;
            case characterchoice.ghost:
                lifecount = 20;
                print(lifecount);
                GhostCostume gc = new GhostCostume();
                gc.printme();
                break;
            case characterchoice.liam:
                lifecount = 30;
                print(lifecount);
                Liam l = new Liam();
                l.printme();
                break;
            case characterchoice.pizza:
                lifecount = 40;
                print(lifecount);
                Pizza p = new Pizza();
                p.printme();
                break;
        }
        print(this.gameObject.GetComponent<Character>().GetInstanceID());
    }
    private void Update()
    {
       
    }
}
public enum characterchoice{
    ghost,
    liam, 
    bat, 
    pizza

}

