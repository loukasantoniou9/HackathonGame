using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoukasDialogueTrigger : MonoBehaviour
{
   public LoukasDialogue dialogue;

   public void LoukasTriggerDialogue () {
       FindObjectOfType<LoukasDialogueManager>().StartDialogue(dialogue);
   }
}
