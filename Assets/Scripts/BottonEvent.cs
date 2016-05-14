using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BottonEvent : MonoBehaviour {

	public void OnClickScene(){
		SceneManager.LoadScene ("Testgame");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
