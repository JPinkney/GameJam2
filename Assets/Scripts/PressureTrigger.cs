using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A pressure trigger is one of the ways to activate the invisible door in a
 * given room
 */
public class PressureTrigger : MonoBehaviour
{

    public bool hasBeenPressed = false;

    void OnTriggerExit(Collider other)
    {
        Destroy(this.gameObject);
        GameObject door_obj = GameObject.FindGameObjectWithTag("InvisibleDoor");
        if (door_obj)
        {
            door_obj.SetActive(false);
            hasBeenPressed = true;
        }
    }
}
