using Reflex.Core;
using UnityEngine;

public class MainSceneInstaller : MonoBehaviour, IInstaller
{
    public void InstallBindings(ContainerBuilder builder)
    {
        // builder.AddSingleton<IInputManager, InputManager>();
        // builder.AddSingleton<IManager, ManagerA>();
    }
}