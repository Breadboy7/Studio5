using UnityEngine;
using DG.Tweening;

public class CameraShake : SingletonMonoBehavior<CameraShake>
{
    public void Shake(float duration, float strength)
    {
        if (Instance == null)
        {
            Debug.LogError("CameraShake Instance is null! Make sure CameraShake is in the scene.");
            return;
        }

        Instance.OnShake(duration, strength);
    }

    private void OnShake(float duration, float strength)
    {
        transform.DOShakePosition(duration, strength);
        transform.DOShakeRotation(duration, strength);
    }
}
