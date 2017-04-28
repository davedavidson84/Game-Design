using System.Collections;
using UnityEngine;

public class Cameras : MonoBehaviour 
{
	public Transform player = null;
	public Transform target = null;


	void LateUpdate ()
	{
		//this.transform.LookAt ( player.position );

		this.transform.position = target.position;
	}


}
