using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CubeCollisionCollider : MonoBehaviour {

	//外のクラスからはアクセス不可　エディターからはアクセス可
	[SerializeField]
	GameObject textObj;//テキストオブジェクトを参照


	//コライダーが接触した際一度必ず呼ばれる関数
	//引数はぶつかった相手
	void OnCollisionEnter (Collision other){
		//Destroy (other.gameObject);
		textObj.SetActive(true);//オブジェクトを活性にする
	}

	//isTriggerをチェックしているとき衝突判定はあるが、オブジェクトに影響をおよばさない
	void OnTriggerEnter(Collider other){
		textObj.SetActive (true);
		Text t = textObj.GetComponent<Text> ();
		t.text = "キューブが通過したんご";
	}

}
