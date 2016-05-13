using UnityEngine;
using System.Collections;

public class InlineOfTarget : MonoBehaviour {

	/********************************Sunlight/Shadow****************************************/
	
	public float inbetweenDistance =100.0f;
	private bool rayShines;
	GameObject satelliteObject;
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	
	// Update is called once per second
	void FixedUpdate()
	{		
		RaycastHit hit;
		//Debug.DrawRay(transform.position, Vector3.right * inbetweenDistance, Color.red, Time.deltaTime, false);




		var directionOfRay = satelliteObject.transform.position - transform.position;

		/*if(Physics.Raycast (transform.position, directionOfRay, hit)){ // If the player is very close behind the player and in view the enemy will detect the player
			if((hit.transform.tag == "Satellite") && (distanceToSatellite &lt;= minPlayerDetectDistance)){
				return true;
			}
		}*/
		
		//if((Vector3.Angle(directionOfRay, transform.forward)) < fieldOfViewRange){ // Detect if player is within the field of view







		              
		/*if(!rayShines)
		{*/
			if(Physics.Raycast(transform.position, directionOfRay, out hit, inbetweenDistance))
		    {
				if(hit.collider.tag == "Satellite")
				{
					// Sun can see the satellite
					Debug.Log("Satellite is in sunlight!!!!!");
				}
				else
				{
					// there is something obstructing the view
					Debug.Log("Satellite is in shadow");
				}
			}
			
		/*}*/			
	}
}