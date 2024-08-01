/* レベルローダーのサンプルコード */
using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
            
    void OnGUI ()
    {
        // 背景のボックスを作成
        GUI.Box(new Rect(10,10,100,90), "Loader Menu");
    
        // 最初のボタンを作成。これを押すと、Application.Loadlevel (1) が実行されます。
        if(GUI.Button(new Rect(20,40,80,20), "Level 1"))
        {
            //Application.LoadLevel(2);
            Debug.Log("Level 1");
        }
    
        // 2 番目のボタンを作成。
        if(GUI.Button(new Rect(20,70,80,20), "Level 2")) 
        {
            //Application.LoadLevel(2);
            Debug.Log("Level 2");
        }
    }
}