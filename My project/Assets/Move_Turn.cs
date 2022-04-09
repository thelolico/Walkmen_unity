using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Turn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey("left")) {  transform.Rotate( 0, -1, 0 );  }
        // 按住 左鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 -1 度

        if ( Input.GetKey("right")) {  transform.Rotate( 0, 1, 0 );  }

        if ( Input.GetKey("up")) {  transform.Translate( 1, 0, 0 );  }
        // 按住 上鍵 時，物件每個 frame 朝自身 z 軸方向移動 0.1 公尺

        if ( Input.GetKey("down")) {  transform.Translate( -1, 0, 0 );  }
    }
}
