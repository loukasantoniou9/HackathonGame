using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{

    public string dialogue;
    private string[]  dialog1 =new string[]{ "Deep Thought: Good morning,","Allien: Er . . . Good morning, O Deep Thought, do you have . . . er, that is . . . ","Deep Thought: An answer for you? Yes. I have.",
                                            "Allien: There really is one?","Deep Thought: There really is one,","Allien: To Everything? To the great Question of Life, the Universe and Everything?",
                                            "Deep Thought: Yes.","Man A: And you’re ready to give it to us?","Deep Thought: I am. But there is something else that you still need to figure out... have a look around"};
    private string  dialog2 = "Allien: Er . . . Good morning, O Deep Thought, do you have . . . er, that is . . . ";
    private string  dialog3 = "Deep Thought: An answer for you? Yes. I have.";
    private string  dialog4 = "Allien: There really is one?";
    private string  dialog5 = "Deep Thought: There really is one,";
    private string  dialog6 = "Allien: To Everything? To the great Question of Life, the Universe and Everything?";
    private string  dialog7 = "Deep Thought: Yes.";
    private string  dialog8 = "Man A: And you’re ready to give it to us?";
    private string  dialog9 = "Deep Thought: I am. But there is something else that you still need to figure out... have a look around";
    private dialogScript dManager;
    // Start is called before the first frame update
    void Start()
    {
        dManager = FindObjectOfType<dialogScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player"){
               // dManager.ShowBox(dialogue);
                for (int i=0; i< 9;i++){
                    dManager.ShowBox(dialog1[i]);
                    WaitOnEnterMethod();
                }
            }
    }

    void WaitOnEnterMethod(){
        Input.GetKeyDown(KeyCode.Return);
    }
}


