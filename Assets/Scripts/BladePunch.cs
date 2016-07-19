using UnityEngine;
using System.Collections;

public class BladePunch : MonoBehaviour {


	void OnCollisionEnter(Collision collision){

		collision.gameObject.transform.TransformDirection (Vector3.forward * 1000000);
	}

}
