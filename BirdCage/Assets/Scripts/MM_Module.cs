using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_Module : MonoBehaviour {

    public float Move_Speed;

	void Update () {
        transform.position -= transform.right * Time.deltaTime * Move_Speed;
        if (transform.position.x < -54f) Destroy(gameObject);
    }
}
