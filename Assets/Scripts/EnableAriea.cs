using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAriea : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerStay2D(Collider2D other) {
            if(other.tag == "Player") {
                obj.SetActive(true);
                Debug.Log("testingefnwoieujwe");
            
        }   
    }
}
