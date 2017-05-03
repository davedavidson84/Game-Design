using System.Collections;
using UnityEngine;

public class Raycaster : MonoBehaviour 
{
	public Camera camera;
	public GameObject obj;
	public Transform origin;
	public float rayLength = 2.0f;

	private Ray ray;
	private RaycastHit hit;

	void Update ()
	{
		if ( Input.GetMouseButtonDown ( 0 ) ) 
		{
			//ray = camera.ScreenPointToRay (Input.mousePosition);

			//if (Physics.Raycast (ray)) 
			//{
			//	Debug.Log ("Hit something.");
			//}

			//if ( Physics.Raycast ( ray, out hit ) )
			//{
			//	if ( hit.collider )
			//	{
			//		Debug.Log ( "Hit object named: " + hit.collider.name );
			//
			//		Instantiate ( obj, hit.point, hit.transform.rotation );
			//	}
			//}

			/*
			RaycastHit[] hits = null;

			hits = Physics.RaycastAll ( ray );

			if ( hits.Length > 0 )
			{
				for ( int i = 0; i < hits.Length; i++ )
				{
					RaycastHit hit = hits [i];

					Debug.Log ( "Hit: " + hit.collider.name );
				}
			}
			*/

			RaycastHit[] hits = null;

			hits = Physics.RaycastAll ( origin.position, Vector3.forward, rayLength );

			if ( hits.Length > 0 )
			{
				for ( int i = 0; i < hits.Length; i++ )
				{
					if ( hits[i].collider )
					{
						Debug.Log ( "Hit: " + hits[i].collider.name );
					}
				}
			}

			Debug.DrawRay ( origin.position, Vector3.forward * rayLength, Color.red, 3 );
		}

		//Debug.DrawRay ( origin.position, Vector3.forward * rayLength, Color.red, 3 );
		//Debug.DrawLine ( ray.origin, hit.point, Color.red );
	}
}
