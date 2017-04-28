using System.Collections;
using UnityEngine;
using UnityEditor;

public class PlayerMovement : MonoBehaviour 
{
	public float moveSpeed = 5.0f;
	public float rotateSpeed = 100.0f;
	public bool canMoveSideways = false;

	void Update ()
	{
		Movement ();
	}

	void Movement ()
	{
		if ( Input.GetKey ( KeyCode.UpArrow ) )
		{
			Debug.Log ( "Key up arrow has been pressed." );

			this.transform.Translate ( new Vector3 ( 0, 0, moveSpeed * Time.deltaTime ) );
		}
		else if ( Input.GetKey ( KeyCode.DownArrow ) )
		{
			Debug.Log ( "Key down arrow has been pressed." );

			this.transform.Translate ( new Vector3 ( 0, 0, -moveSpeed * Time.deltaTime ) );
		}

		if ( Input.GetKey ( KeyCode.LeftArrow ) )
		{
			if ( canMoveSideways )
			{
				Debug.Log ( "Key left arrow has been pressed." );

				this.transform.Translate ( new Vector3 ( -moveSpeed * Time.deltaTime, 0, 0 ) );
			}
			else
			{
				Debug.Log ( "Key LeftArrrow Pressed: Rotate" );

				this.transform.Rotate ( new Vector3 ( 0, -rotateSpeed * Time.deltaTime, 0 ) );
			}
		}
		else if ( Input.GetKey ( KeyCode.RightArrow ) )
		{
			if ( canMoveSideways )
			{
				Debug.Log ( "Key right arrow has been pressed." );

				this.transform.Translate ( new Vector3 ( moveSpeed * Time.deltaTime, 0, 0 ) );
			}
			else
			{
				Debug.Log ( "Key RightArrow Pressed: Rotate" );

				this.transform.Rotate ( new Vector3 ( 0, rotateSpeed * Time.deltaTime, 0 ) );
			}
		}

		if ( Input.GetKey ( KeyCode.W ) )
		{
			Debug.Log ( "Key W has been pressed." );

			this.transform.Translate ( new Vector3 ( 0, moveSpeed * Time.deltaTime, 0 ) );
		}
		else if ( Input.GetKey ( KeyCode.S ) )
		{
			Debug.Log ( "Key S has been pressed." );

			this.transform.Translate ( new Vector3 ( 0, -moveSpeed * Time.deltaTime, 0 ) );
		}
	}
}