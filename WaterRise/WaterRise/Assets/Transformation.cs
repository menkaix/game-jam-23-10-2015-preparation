using UnityEngine;
using System.Collections;

public class Transformation : MonoBehaviour {

	public const byte STATUS_NONE = 0 ;
	public const byte STATUS_LEFT = 0 ;
	public const byte STATUS_RIGHT = 0 ;
	public const byte STATUS_DOWN = 0 ;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetKey(KeyCode.Alpha1)) {
			Trigger trigger =other.gameObject.GetComponent<Trigger>();

			if(trigger !=null){
				transform.position = trigger.target.transform.position + Vector3.up ;
			}
		}
	}
}
