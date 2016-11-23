using UnityEngine;
using System.Collections;

public class Boss{

    // 発展課題1.nt型の変数mpを宣言し、53で初期化してください
    int mp = 53;

    // 発展課題2.mpを消費して魔法攻撃をするMagic関数を作ってください
    // 発展課題3.Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
    // 発展課題3.mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
    // 変数mpが足りているかどうかをif文で判断し、それぞれの場合の出力を行いました。
    public void Magic(){
        if(this.mp >= 5){
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour {

    // 課題1.要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
    // 配列arrayにそれぞれの数値を代入しました。数値はとりあえず1～5を2乗したものを代入してみました。
    int[] array = {1, 4, 9, 16, 25 }; 

	// Use this for initialization
	void Start () {
        // 課題2.配列の各要素の値を順番に表示してください
        // for文でint型のiを回す回数として代入、昇順で配列内を表示するために初期値を0にしています。
        // 回す回数はarrayの値をLengthで配列内の最後まで回すようにしています。
        // Lengthは5個と数えますが配列arrayは[4]までになりますので、iが5以上になるまで回すように設定しました。
        for (int i =0; i < array.Length;  i++) {
            Debug.Log(array[i]);
        }

        // 課題3.for文を使い、配列の各要素の値を逆順に表示してください
        // 先ほどとは逆に降順で設定しますので、変数iはarray.Length-1を代入しました、-1としましたのは配列の数は5つですが[4]までしかないので-1にしないとエラーになる為です。
        // そしてiを0未満になるまでfor文で配列arrayの中身を順番に出力しました。
        for (int i = array.Length-1; i >=0; i--){
            Debug.Log(array[i]);
        }

        // Bossクラス内のMagic関数を呼び出して実行しています。
        // mpが足りないメッセージが表示されることを確認する為にfor文で回しています。
        Boss thisBoss = new Boss();

            for(int i=0; i<= 10; i++){
            thisBoss.Magic();
        }


    }

    // Update is called once per frame
    void Update () {
	
	}
}
