using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    int mp = 53;

    //魔法攻撃の関数
    public void Magic(int cost)
    {

        //残りmpをチェック
        if (this.mp > cost)
        {
            //残りmpを減らす
            this.mp -= cost;

            //残りのmpを表示
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }
}


public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        //攻撃用の関数を呼び出す

        //魔法を10回使い、11回目でMP切れを起こさせる。
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }


        //要素数５の配列を初期化、値を代入する
        int[] array = { 1, 2, 3, 4, 5 };

        //配列の要素数の分だけ表示を繰り返す（昇順）
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素数の分だけ表示を繰り返す（降順）
        for (int i = 4; i < array.Length; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
