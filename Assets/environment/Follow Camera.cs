using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    public Transform Player;
    private Vector3 offset;

    private bool lookAt = true;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Player.TransformPoint(offset);
        if(lookAt){
            transform.LookAt(Player);
        }
	}
}
