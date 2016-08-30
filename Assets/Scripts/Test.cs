using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	public GameObject dirLi;
	bool activeLi = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("z")) {
			if (activeLi) {
				dirLi.SetActive (false);
				activeLi = false;
			} else {
				dirLi.SetActive (true);
				activeLi = true;
			}

		}
	}
}
