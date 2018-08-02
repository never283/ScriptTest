using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //配列の各要素を表示する
        for (int i = 0; i < 5; i++)
        {

            Debug.Log(array[i]);

        }


        {
            //要素数5の配列を初期化する
            int[] array2 = new int[5];

            //配列の各要素に代入する
            array2[0] = 10;
            array2[1] = 20;
            array2[2] = 30;
            array2[3] = 40;
            array2[4] = 50;

            //配列の各要素を逆順に表示する
            for (int j = 4; (j > 0) || (j == 0); j--)
            {

                Debug.Log(array2[j]);
            }

        }

    }

}

