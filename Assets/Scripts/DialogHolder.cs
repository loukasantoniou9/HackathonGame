using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogHolder : MonoBehaviour
{
    public LoukasDialogue dialogue;
    public GameObject trigger;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //dManager = FindObjectOfType<dialogScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player"){
                FindObjectOfType<LoukasDialogueManager>().StartDialogue(dialogue);
                
                Destroy(trigger);
                //FindObjectOfType<LindaDialogueManager>().StartDialogue(dialogue);
            }
    }

}


