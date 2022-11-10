using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Polymorphism / inheritance
//Zone --> WinZone 
//     --> LoseZone
//     --> PowerUp

//Abstract means, we cant create a instance/component of this class
public abstract class Zone : MonoBehaviour
{
    //Code for this function is written in child/derived classes
    protected abstract void ZoneTrigger(GameObject marble);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Marble")
        {
            ZoneTrigger(other.gameObject);
        }
    }
}
