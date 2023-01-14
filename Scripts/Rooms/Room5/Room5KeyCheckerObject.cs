using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room5KeyCheckerObject : MonoBehaviour
{
    public List<Room5Component> components;
    public LevelUI postTime;

    public int roomGoal = 3;
    private int counter;
    private bool bSendTimeOnce = true;

    public void Trigger(int value)
    {

        counter += value;
        counter = Mathf.Clamp(counter, 0, 3); // have to clamp it otherwise it will go over threshold

        if (counter == roomGoal)
        {

            Activate(); // activate all the objects in the room, such as: unlocking door, changing button color, etc

            if (bSendTimeOnce == true)
            {
                postTime.PostTime();
                bSendTimeOnce = false;
            }
        }

        else
            DeActivate();
    }



    // this is the equivalent of the player completing the room's challenge
    private void Activate()
    {
        foreach (Room5Component item in components)
            item.ActivateAction();
    }

    private void DeActivate()
    {
        foreach (Room5Component item in components)
        {
            item.DeActivateAction();
        }
    }
}
