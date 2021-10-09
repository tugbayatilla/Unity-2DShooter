using UnityEngine;

public abstract class GameWinLooseCondition : MonoBehaviour
{
    public enum WinLostStatus
    {
        Unknown,
        Win,
        Lost
    }
    public WinLostStatus status;
    public string message;

    public abstract bool CheckCondition();
}
