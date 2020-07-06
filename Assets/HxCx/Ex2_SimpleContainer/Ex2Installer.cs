using UnityEngine;
using Zenject;

namespace HxCx.Ex2 {
    public class Ex2Installer : MonoInstaller {
        public override void InstallBindings()
        {
            Container.Bind<ISimpleModel>().To<SimpleModel>().AsCached();
        }
    }
}