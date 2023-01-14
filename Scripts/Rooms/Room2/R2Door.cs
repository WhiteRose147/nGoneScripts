using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2Door : Room2Component
{
    [SerializeField] private GameObject door;



    public override void ActivateAction()
    {
        door.GetComponent<BoxCollider>().enabled = false;
        door.GetComponent<MeshRenderer>().enabled = false;
    }

    public override void DeActivateAction()
    {
        door.GetComponent<BoxCollider>().enabled = true;
        door.GetComponent<MeshRenderer>().enabled = true;
    }
}