using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HxCx.Ex2 {

    /// <summary>
    /// 文字列の変更と変更通知を行うインターフェース
    /// </summary>
    public interface ISimpleModel {

        //  文字列の変更通知
        IObservable<string> OnChangeMessage();

        //  文字列を変更する
        void ChangeMessage(string message);
    }
}
