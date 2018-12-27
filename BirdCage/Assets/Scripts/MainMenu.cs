using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public List<GameObject> RepeatModules = new List<GameObject>(); // Biblioteca de modulos spawneables
    Vector3 StartPoint = new Vector3(8.7f, -5.1426f, 6.086f); // Donde spawnean los modulos nuevos

    void FixedUpdate()
    {
        RaycastHit hit; // Raycast que detecta cuando spawnear el proximo modulo
        if (!Physics.Raycast(transform.position, transform.forward, out hit, 20f))
        {
            var RepeatModule = Instantiate(RepeatModules[Random.Range(0, RepeatModules.Count)]);
            RepeatModule.transform.position = StartPoint;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Hub");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
