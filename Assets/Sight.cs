using UnityEngine;
using System.Collections;

public class Sight : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	

		
		
		// Update is called once per frame
		void Update () 
		{

		
		//GameObject Satellite; // the player
		//float fieldOfViewRange = 90.0f; // in degrees (I use 68, this gives the enemy a vision of 136 degrees)
		//float minPlayerDetectDistance = 5.0f; // the distance the player can come behind the enemy without being deteacted
		float rayRange = 10.0f; // distance the enemy can "see" in front of him
		//Vector3 rayDirection;


			RaycastHit hit;
			/*rayDirection = GameObject.FindGameObjectWithTag("Satellite").transform.position - transform.position;
		var distanceToPlayer = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Satellite").transform.position);
			*/
			
			/*if(Physics.Raycast (transform.position, rayDirection,out hit)){ // If the player is very close behind the enemy and not in view the enemy will detect the player
				if((hit.transform.tag == "Satellite") && (distanceToPlayer <= minPlayerDetectDistance)){
					Debug.Log("Caught player sneaking up behind!");
					//return true;
				}
			}*/
			//if((Vector3.Angle(rayDirection, transform.forward)) < fieldOfViewRange){ // Detect if player is within the field of view
		if (Physics.Raycast (transform.position, Vector3.right * Time.deltaTime, out hit, rayRange)) {
					if (hit.transform.tag == "Satellite") {
						Debug.Log("Can see satellite");
						//return true;
					}else{
						Debug.Log("Can not see satellite");
						//return false;
					}
				}
			}
			
		}
		
		
		/*function OnDrawGizmosSelected ()
		{
			// Draws a line in front of the player and one behind this is used to visually illustrate the detection ranges in front and behind the enemy
			Gizmos.color = Color.magenta; // the color used to detect the player in front
			Gizmos.DrawRay (transform.position, transform.forward - rayRange);
			Gizmos.color = Color.yellow; // the color used to detect the player from behind
			Gizmos.DrawRay (transform.position, transform.forward  -minPlayerDetectDistance);    
		}
}*/