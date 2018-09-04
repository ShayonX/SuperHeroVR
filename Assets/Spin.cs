using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	public float spinValue = 90;
	public int option = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (option == 1) {
			transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
		}else if (option == 2) {
			transform.Rotate(Vector3.down * spinValue * Time.deltaTime);
		}else if (option == 3) {
			transform.Rotate(Vector3.left * spinValue * Time.deltaTime);
		}else {
			transform.Rotate(Vector3.right * spinValue * Time.deltaTime);
		}

	}

	public void flipSpin(){
		spinValue = -spinValue;
		option = Random.Range (1, 4);
	}
}
