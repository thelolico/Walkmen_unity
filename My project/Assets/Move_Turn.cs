using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Turn : MonoBehaviour
{
    // Start is called before the first frame update
    float firstvect;
    int bools = 1;
    void Start()
    {
        firstvect = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (bools == 0)
            {
                transform.Rotate(0, firstvect, 0);
                firstvect = 0;
                bools = 1;
            }
        }

        if ( Input.GetKey("left")) {  
            transform.Rotate( 0, -1, 0 );
            firstvect++;
            bools = 0;
        }
        // 按住 左鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 -1 度

        if ( Input.GetKey("right")) { 
            transform.Rotate( 0, 1, 0 );
            firstvect--;
            bools = 0;
        }


        //if ( Input.GetKey("up")) {  transform.Translate( 1, 0, 0 );  }
        // 按住 上鍵 時，物件每個 frame 朝自身 z 軸方向移動 0.1 公尺

        //if ( Input.GetKey("down")) {  transform.Translate( -1, 0, 0 );  }
    }
}
