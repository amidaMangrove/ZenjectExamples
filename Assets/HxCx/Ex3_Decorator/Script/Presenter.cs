using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using Zenject;

namespace HxCx.Ex3 {

    /// <summary>
    /// プレゼンタ
    /// </summary>
    public class Presenter : MonoBehaviour {

        //  Zenject Bindingから
        Text _message;

        //  Zenject Bindingから
        Button _button;

        //  Containerから
        ISimpleModel _simpleModel;

        /// <summary>
        /// メソッドインジェクション
        /// </summary>
        /// <param name="message"></param>
        /// <param name="button"></param>
        /// <param name="simpleModel"></param>
        [Inject]
        void Constructor(Text message, Button button, ISimpleModel simpleModel )
        {
            _message = message;
            _button = button;
            _simpleModel = simpleModel;
        }

        // Start is called before the first frame update
        void Start()
        {
            //  モデルの値の変更を検知
            _simpleModel.OnChangeMessage().Subscribe(message =>
            {
                _message.text = message;
            }).AddTo(this);

            //  ボタンクリック
            _button.OnClickAsObservable().Subscribe(_ =>
            {
                _simpleModel.ChangeMessage("With Fire");
            }).AddTo(this);
        }
    }

}