using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//課題：配列を宣言して出力しましょう
		// 課題関数呼び出し
		kadai1();

		//発展課題:Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
		// Bossクラスの生成
		Boss bossEx = new Boss();

		// Magic関数を10回呼び出し
		for(int i = 1; i <= 10; i++){
			Debug.Log("Start " + i + "回目:Magic関数呼び出し");
			bossEx.Magic();
		}

		//11回目Magic関数呼び出し
		Debug.Log("Start 11回目:Magic関数呼び出し");
		bossEx.Magic();

	}

	// Update is called once per frame
	void Update () {
		
	}

	void kadai1(){
		// 配列初期化
		int[] myArray = {1,2,3,4,5};

		// 開始ログ
		Debug.Log("Start 配列の各要素の値を順番に表示");
		// 配列の各要素の値を順番に表示
		for(int i = 0; i < myArray.Length; i++){
			Debug.Log("配列["+ i + "] = " + myArray[i]);
		}

		// 開始ログ
		Debug.Log("Start 配列の各要素の値を逆順に表示");
		// 配列の各要素の値を逆順に表示
		for(int i = myArray.Length - 1; i >= 0; i--){
			Debug.Log("配列["+ i + "]:" + myArray[i]);
		}

	}
}

public class Boss {
	private int mp = 53;

	public void Magic(){
		// 消費するMP
		int mpCost = 5;

		// MPが消費コスト以上残っている場合
		if(this.mp >= mpCost){
			// MP = MP - 消費コスト
			this.mp -=mpCost;
			// コンソール出力
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

		// 上記以外の場合	
		} else {
			// コンソール出力
			Debug.Log("MPが足りないため魔法が使えない。");
		}

	}


}