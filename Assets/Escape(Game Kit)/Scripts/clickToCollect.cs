using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToCollect : MonoBehaviour {
	public static string nameofobj;
	public GameObject objnametxt;
	void OnMouseDown() {
		nameofobj = gameObject.name;
		Destroy(gameObject);
		Destroy (objnametxt);
	}
}
