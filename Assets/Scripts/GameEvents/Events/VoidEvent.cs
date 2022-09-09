using UnityEngine;

[CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/void", order = 0)]
public class VoidEvent : BaseGameEvent<Void>
{
    public void Raise() => Raise(new Void());
}
