using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigDoor : MonoBehaviour
{
    public GameObject bigDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isEnterCLicked() {
        Destroy(bigDoor);
    }
}
