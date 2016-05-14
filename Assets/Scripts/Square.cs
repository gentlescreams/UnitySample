using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {

    //繰り返す回数の最大値
    int max = 5;
    //合計値を格納する変数
    int ans = 0;
 
    string s1 = "";
    // .tostring()で数値を文字列にできる
    void Start () {


        //最初にやりたい小さいループ文をつくり、最後に全体的なループ文をつくる
        //合計値を出力する
        for (int i = 1; i <= max; i++)
        {
            string s = "";
            //合計値を算出するループ文
            for (int x = 0; x <= max; x++)
            {
                s += "□";
                Debug.Log(s);
               
            }


        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
