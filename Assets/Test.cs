using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください//
        int[] array = {1,2,3,4,5};

        //for文を使い、配列の各要素の値を順番に表示してください//
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示してください//
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう//
        Boss lastboss = new Boss();
        for (int i = 0; i <= 10; i++)
        {
            int kaisuu = i + 1;
            Debug.Log(kaisuu + "回目");
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
