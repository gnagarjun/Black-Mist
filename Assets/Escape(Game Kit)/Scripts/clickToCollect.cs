using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToCollect : MonoBehaviour {

	void OnMouseDown() {
		Destroy(gameObject);
	}
}
