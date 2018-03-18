using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datacollection : MonoBehaviour {
	//theta is the angle between the x axis and the target
	private float theta;
	//tg stands for target position
	private Vector2 tg;
	//s stands for start position
	private Vector2 s;
	//raycasting functions
	//private CalculatePositions raycaster;

	// Use this for initialization
	void Start () {
		//raycaster = new CalculatePositions();
	}

	// Update is called once per frame
	void Update () {
		//e stands for error position
		//Vector2 e = raycaster.getRayCollision();
		//psi stands for angle between x angle and e;
		//float psi = Mathf.atan(e.x / e.y);
		//delta stands for angle between target line and error line
		//float delta = psi - theta;
		//d stands for distance of error from start point
		//float d = Mathf.sqrt(Mathf.pow((e.x - s.x), 2) + Mathf.pow((e.y - s.y), 2));
		//width stands for perpindicular distance deviation from the target line
		//float width = d * Mathf.sin(delta);
	}

	void changeTarget(Vector3 position)  {

	}
}

