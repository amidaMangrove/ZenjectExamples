using System;
using UnityEngine;

namespace HxCx.Ex3 {
    public class DecoratorSimpleModel : ISimpleModel 
    {
        readonly ISimpleModel _decorated;

        public DecoratorSimpleModel(ISimpleModel decorated)
        {
            _decorated = decorated;
        }
        public void ChangeMessage(string message)
        {
            _decorated.ChangeMessage(message);
            Debug.Log($"変更したメッセージ：{message}");
        }

        public IObservable<string> OnChangeMessage()
        {
            return _decorated.OnChangeMessage();
        }       
    }
}