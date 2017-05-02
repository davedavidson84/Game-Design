using System.Collections;
using UnityEngine;

public class MouseClicks : MonoBehaviour 
{
	private Color originalColor = Color.white;

	void Awake ()
	{
		originalColor = this.GetComponent<Renderer> ().material.color;
	}

	void OnMouseEnter ()
	{
		this.GetComponent<Renderer> ().material.color = Color.red;
	}

	void OnMouseExit ()
	{
		this.GetComponent<Renderer> ().material.color = originalColor;
	}
}
