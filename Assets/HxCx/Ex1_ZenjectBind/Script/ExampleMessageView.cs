using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HxCx {

    /// <summary>
    /// 
    /// </summary>
    public class ExampleMessageView : MonoBehaviour {

        Text _message;
        Text Message
        {
            get { return _message ?? GetComponent<Text>(); }
        }

        /// <summary>
        /// メッセージを更新する
        /// </summary>
        /// <param name="message"></param>
        public void SetMessage(string message)
        {
            Message.text = message;
        }
    }
}