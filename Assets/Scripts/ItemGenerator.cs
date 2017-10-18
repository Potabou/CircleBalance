using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	public GameObject[] Train;
	private GameObject go;
	private Rigidbody rb;
	private int number ;
	private int kg;

	// Use this for initialization
	void Start () {
		number = Random.Range (0, Train.Length);
		kg = Random.Range (1, 4);
		//Instantiate(Train[number]);
		go = Instantiate(Train[number]);

		rb = go.GetComponent<Rigidbody>();

		rb.mass = kg;
		Debug.Log ("massは" + kg);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
