using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public GameObject protal;
	public GameObject target;
	public GameObject bedspawn;
	public GameObject bathroomspawn;
	void OnCollisionEnter (Collision col)
	{   bool check = true;

		if(col.gameObject == protal)
		{
			//this.transform.position(-11, -1, 2);
			transform.position = bathroomspawn.transform.position;
		}
		else if(col.gameObject == target)
		{
			transform.position = bedspawn.transform.position;
		}
	}
}
