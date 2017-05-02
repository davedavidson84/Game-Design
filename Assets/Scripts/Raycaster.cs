using System.Collections;
using UnityEngine;

public class Raycaster : MonoBehaviour 
{
	public Camera camera;

	private Ray ray;
	private RaycastHit hit;

	void Update ()
	{
		if ( Input.GetMouseButtonDown ( 0 ) ) 
		{
			ray = camera.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray)) 
			{
				Debug.Log ("Hit something.");
			}
		}
	}
}
