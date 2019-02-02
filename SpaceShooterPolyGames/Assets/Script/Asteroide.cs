using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour {

    [SerializeField] float minScale = 3.0f;
    [SerializeField] float maxScale = 3.5f;

    [SerializeField] int angleRotation = 45;

    Vector3 rotation;

    // Use this for initialization
    void Start () {

        //Changer la taille entre 3 et 3.5 de manière aléatoire
        transform.localScale = new Vector3(Random.Range(minScale,maxScale), Random.Range(minScale, maxScale), Random.Range(minScale, maxScale));
        rotation = new Vector3(Random.Range(-angleRotation, angleRotation), Random.Range(-angleRotation, angleRotation), Random.Range(-angleRotation, angleRotation));
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotation * Time.deltaTime);
	}
}
