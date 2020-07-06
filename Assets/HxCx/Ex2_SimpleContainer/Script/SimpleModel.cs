using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace HxCx.Ex2 {

    /// <summary>
    /// 文字列を更新する単純なクラス
    /// </summary>
    public class SimpleModel : ISimpleModel {

        StringReactiveProperty _message = new StringReactiveProperty();

        /// <summary>
        /// 文字列の変更通知
        /// </summary>
        /// <returns></returns>
        public IObservable<string> OnChangeMessage() => _message.AsObservable();


        SimpleModel()
        {
            _message.Value = "Master of...";
        }
        /// <summary>
        /// 文字列の更新
        /// </summary>
        /// <param name="message"></param>
        public void ChangeMessage(string message)
        {
            _message.Value = message;
        }
    }
}