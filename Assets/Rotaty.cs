using UnityEngine;
using System.Collections;

public class Rotaty : MonoBehaviour {

    public float turnSpeed = 80.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
            transform.RotateAround(Vector3.zero, Vector3.up, turnSpeed * Time.deltaTime);
	}
}
