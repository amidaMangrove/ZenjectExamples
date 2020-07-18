using UnityEngine;
using Zenject;

namespace HxCx.Ex3 {
    public class Ex3Installer : MonoInstaller {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<SimpleModel>().AsCached();

            Container.Decorate<ISimpleModel>().With<DecoratorSimpleModel>().AsCached();
        }
    }
}