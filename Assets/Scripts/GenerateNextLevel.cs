using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GenerateNextLevel is a script that takes a trigger object, and checks if the
 * room is complete.
 * 
 *  If the room is complete then generate the next level when they walk into
 *  the door
 * 
 *  If the room is NOT complete then don't do anything
 * 
 */
public class GenerateNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public Room thisRoom;

    private string[] available_scenes;
    private bool triggered_ending = false;

    void Start()
    {
        // Set the available scenes you can move to
        string[] possible_names = new string[] { "test", "test", "test", "Small Room" };
        int index = 0;
        available_scenes = new string[3];
        foreach(string scene_name in possible_names)
        {
            // Debug.Log(this.thisRoom.name);
            if (this.thisRoom.name != scene_name)
            {
                available_scenes[index] = scene_name;
                index++;
            }
        }

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (thisRoom.isComplete && !triggered_ending)
        {
            // Generate the next level!!!!!
            int rand_num = Random.Range(0, 3);
            var new_scene_name = available_scenes[rand_num];
            SceneManager.LoadSceneAsync(new_scene_name);
            triggered_ending = true;
        }
    }
}
