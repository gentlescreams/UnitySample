using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	//キャラクターのトランスフォームを取得
	[SerializeField]
	Transform charatransform;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - charatransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = charatransform.position + offset;

	}
}
