using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
    public Canvas InfoCanvas;

    public GameObject Sun { get; private set; }

    void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 60*target.transform.localScale.x;
        if(gameObject == Sun)
        {
            InfoCanvas.gameObject.SetActive(true);
        }
    }
}
