using UnityEngine;
using System.Collections;


//プレイヤーの動きの処理
//
//

public class PlayerController : MonoBehaviour {

    Rigidbody rigid;

	
	void Start () {
        //とりたいコンポーネントを中身に書く　取得できる
        rigid = GetComponent<Rigidbody> ();

	}


	// Update is called once per frame
	void Update () {

		//左右
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//上下
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.01f, moveVertical);

		rigid.AddForce (movement * 10);

	//	if (Input.GetKeyDown (KeyCode.arr)) {
	//		rigid.AddForce (new Vector3 (0f, 500f, 500f));
	//	}

	}

}
