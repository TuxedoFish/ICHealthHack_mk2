using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLogic : MonoBehaviour {

    public AudioSource laserSource;

	private float radius;
	private Vector3 origin;

	// Use this for initialization
	void Start () {
		GameObject[] reach = GameObject.FindGameObjectsWithTag ("reach");
		radius = reach [0].GetComponent<Renderer>().GetComponent<SphereCollider>().radius*
			reach [0].GetComponent<Renderer>().GetComponent<SphereCollider>().transform.lossyScale.x;
		origin = reach [0].transform.position;

		setPosition ();

        laserSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void setPosition() {
		var theta = Random.Range (0.0f, Mathf.PI/2.0f);
		var psi = Random.Range (Mathf.PI/3.0f, Mathf.PI * (4.0f / 6.0f));

		transform.SetPositionAndRotation (
			new Vector3 (origin.x + (radius * Mathf.Cos (theta) * Mathf.Cos (psi)),
				origin.y + (radius * Mathf.Sin (theta)),
				origin.z + (radius * Mathf.Cos (theta) * Mathf.Sin (psi))) 
				, transform.rotation);
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "player")
		{
			setPosition ();

            laserSource.Play();

        }
	}

}
