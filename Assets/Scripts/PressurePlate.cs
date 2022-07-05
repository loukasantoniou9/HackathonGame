using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
[SerializeField] private GameObject doorobject; 
private IDoor door;
 SpriteRenderer m_SpriteRenderer;
 Color m_NewColor;

 void  Start() {
    m_SpriteRenderer = GetComponent<SpriteRenderer>();
    //m_SpriteRenderer.color = Color.green;
 }
private void OnTriggerEnter2D(Collider2D collider) {
    if(collider.tag == "Ball"){
       m_SpriteRenderer.color = Color.green;
       doorobject.SetActive(false);
    }
}
private void OnTriggerExit2D(Collider2D collider) {
    if(collider.tag == "Ball"){
       m_SpriteRenderer.color = Color.red;
       doorobject.SetActive(true);
    }
}
}
