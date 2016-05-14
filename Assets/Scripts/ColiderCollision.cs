using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColiderCollision : MonoBehaviour {

	[SerializeField]
	GameObject textObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		textObj.SetActive (true);
		Text t = textObj.GetComponent<Text> ();
		t.text = "ゴールしたンゴ";
	}

}
