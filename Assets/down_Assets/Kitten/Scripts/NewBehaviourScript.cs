using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	Transform Player;
	float f_RotSpeed=3.0f, f_MoveSpeed=3.0f;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		/* Look at Player */
		transform.rotation = Quaternion.Slerp(transform.rotation
												,Quaternion.LookRotation(Player.position - transform.position)
												,f_RotSpeed * Time.deltaTime);
		/* Move at Player */
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
}
