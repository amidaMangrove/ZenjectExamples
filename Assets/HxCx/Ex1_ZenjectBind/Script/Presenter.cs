using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace HxCx {
    public class Presenter : MonoBehaviour {

        Button _changeButton;
        ExampleMessageView _exampleView;

        [Inject]
        public void Constructor(Button button, ExampleMessageView exampleView)
        {
            _changeButton = button;
            _exampleView = exampleView;
        }
        // Start is called before the first frame update
        void Start()
        {
            _changeButton.onClick.AddListener(() =>
            {
                _exampleView.SetMessage("Fuga!");
            });
        }
    }
}