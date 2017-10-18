using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Camera MainCamera;
	public Camera SubCamera; 


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && Input.mousePosition.x >= Screen.width * 0.75f && Input.mousePosition.y >= Screen.height * 0.75f){
			Debug.Log("Sub Camera Clicked!!");
			SubCamera.rect = new Rect(0f, 0f, 1f, 1f); //カメラのビューポートを変更
			MainCamera.rect = new Rect(0.78f, 0.78f, 0.2f, 0.2f); //カメラのビューポートを変更
			MainCamera.depth = '2';


		}
	}
}
