using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log_movement : MonoBehaviour {
	public GameObject idealPosition; 
	private Color colorIdeal = new Color(0,1,0,0.1f);


	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		//if (  (gameObject.transform.position-0.1f) <= idealPosition.transform.position.x <= (gameObject.transform.position+0.1f)) {
		//	Debug.Log ("correct!");
		//}

		if ((gameObject.transform.position.x-0.1f <= idealPosition.transform.position.x 
			&& idealPosition.transform.position.x <= gameObject.transform.position.x+0.1f)&&
			(gameObject.transform.position.y-0.1f <= idealPosition.transform.position.y
			&& idealPosition.transform.position.y <= gameObject.transform.position.y+0.1f)&&
			(gameObject.transform.position.z-0.1f <= idealPosition.transform.position.z 
			&& idealPosition.transform.position.z <= gameObject.transform.position.z+0.1f)) {
			gameObject.transform.position = idealPosition.transform.position;
		
			idealPosition.GetComponent<Renderer> ().material.color = colorIdeal;	}
	}

	void OnMouseDrag()
	{
		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
			Input.mousePosition.y, distance_to_screen ));

	}



}
