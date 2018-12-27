using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub_Character : MonoBehaviour {

    Hub GameManager;

	void Start () {
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Hub>();
	}
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (other.tag == "DoorTrigger") GameManager.OpenDoor();
            else if (other.tag == "SpearTrigger") GameManager.OpenSpear();
            else if (other.tag == "EndLevel") GameManager.FinishLevel();
        }
    }
}
