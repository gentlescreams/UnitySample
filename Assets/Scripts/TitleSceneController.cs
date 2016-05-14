using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//シーンの移行
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("Testgame");
		}
	}
}
