using AutumnBox.OpenFramework.Extension;
using AutumnBox.OpenFramework.Extension.Leaf;
using AutumnBox.OpenFramework.Open;

namespace AtmbExtDemo
{
    [ExtName("Hello world!")]
    [ExtRequiredDeviceStates(AutumnBoxExtension.NoMatter)]
    class EHelloAutumnBox : LeafExtensionBase
    {
        [LMain]
        public void Run(IUx ux)
        {
            ux.Message("你好，秋之盒");
        }
    }
}