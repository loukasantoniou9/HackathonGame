using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDialog : MonoBehaviour
{

    public GameObject panel;
    public void HideTheDialog() {
        panel.SetActive(false);
    }
}
