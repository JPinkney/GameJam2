using UnityEngine;
using System.Collections;

/*
 * Contains information about the room and whether or not it has been completed.
 * You can attach this script to one of the prefab rooms.
 */
public class Room : MonoBehaviour
{

    public bool isComplete = false;
    public PressureTrigger pressure_trigger;

    // Update is called once per frame
    void Update()
    {
        if (pressure_trigger.hasBeenPressed) {
            isComplete = true;
        }
    }
}
