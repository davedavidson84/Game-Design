using System.Collections;
using UnityEngine;

public class TriggerExamples : MonoBehaviour 
{
	void OnTriggerEnter ( Collider other )
	{
		Debug.Log ( "Object: " + other.name + " entered trigger." );
	}
}
