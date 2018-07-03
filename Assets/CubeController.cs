using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadline = -10;

	//音声ファイルを取得
	public AudioClip block;
	AudioSource audioSource;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブ移動させる
		transform.Translate (this.speed, 0, 0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadline) {
			Destroy (gameObject);
		}
		
	}

	//他のオブジェクトに衝突したときに音を鳴らす
	void OnCollisionEnter2D (Collision2D other) {
		//Debug.Log (other.gameObject.name);
		//キューブが地面に接触するときとキューブ同士が積み重なるときに効果音を鳴らす
		if (other.gameObject.name == "CubePrefab(Clone)" || other.gameObject.name == "ground") {
			//Debug.Log ("衝突したよ");
			//音を鳴らす
			gameObject.GetComponent<AudioSource> ().Play();
			//gameObject.GetComponent<AudioSource> ().PlayOneShot (block, 1F);
		}
	}


}
