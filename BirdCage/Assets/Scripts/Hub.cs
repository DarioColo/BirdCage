using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub : MonoBehaviour {

    List<Hub_Door> Doors = new List<Hub_Door>();
    List<GameObject> Spears = new List<GameObject>();
    GameObject Character;

    void Start () {
        Character = GameObject.FindGameObjectWithTag("Player");
        Spears.AddRange(GameObject.FindGameObjectsWithTag("Spear"));
        var DoorsGO = GameObject.FindGameObjectsWithTag("Door");
        foreach (var item in DoorsGO)
        {
            Doors.Add(item.GetComponent<Hub_Door>());
        }
	}
    public void OpenDoor()
    {
        foreach (var Door in Doors)
        {
            if (Vector3.Distance(Door.transform.position, Character.transform.position) < 5f) Door.Open();
        }
    }
    public void OpenSpear()
    {
        if (Spears.Count > 0)
        {
            for (int i = 0; i < 2; i++)
            {
                Destroy(Spears[Spears.Count - 1]);
                Spears.RemoveAt(Spears.Count - 1);
            }
        }
    }
    public void FinishLevel() // temporal
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
