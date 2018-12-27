using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub_Door : MonoBehaviour {

    public GameObject DoorPivot;
    bool Opened;
    float timer;

    void Update()
    {
        if (Opened)
        {
            timer += Time.deltaTime;
            if (timer <2f) DoorPivot.transform.Rotate(0, 0, 0.7f);
        }
    }
    public void Open()
    {
        Opened = true;
    }
}
