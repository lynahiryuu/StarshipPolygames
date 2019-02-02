using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] Vector3 initPosCamera = new Vector3(0, 2, -10);
    [SerializeField] float interpolationFactor = 0.3f;


    Vector3 velocity = Vector3.one;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //Le calcul de la caméra doit être mis à jour après tous les updates
	void LateUpdate () {

        //Calcul de la position de la caméra
        Vector3 nextPosition = target.position + (target.rotation * initPosCamera);

        //interpolation linéaire pour la position
        transform.position = Vector3.SmoothDamp(transform.position, nextPosition, ref velocity, interpolationFactor);

        //Rotation de la caméra
        transform.LookAt(target, target.up);
	}
}
