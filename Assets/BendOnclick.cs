using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendOnclick : MonoBehaviour {

	public Material material;

	public float dampingSpeed = 0.02f, streachDistance = 2;

	float streach;

	
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit)) {
				material.SetVector("_point_of_bend", hit.point);
				streach = streachDistance;
			}
		}

		streach = Mathf.Clamp(streach - dampingSpeed, 0, 20);
		material.SetFloat("_streach", streach);
	}
}
