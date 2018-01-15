using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fountain : MonoBehaviour {
    public Rigidbody prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody instance = GameObject.Instantiate(prefab, transform.position + Vector3.up * 1, transform.rotation);
        instance.AddRelativeForce(new Vector3((Random.value - 0.5f) * 1000, 1000.0f, (Random.value - 0.5f) * 1000));
	}
}
