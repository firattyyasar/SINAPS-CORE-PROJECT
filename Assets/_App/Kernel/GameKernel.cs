using UnityEngine;

public sealed class GameKernel : MonoBehaviour
{
    public static GameKernel I { get; private set; }

    // Geliştirme aşamasında eklenecek sistemler için yer tutucular
    // Örnek: public EventBus Events { get; private set; }

    void Awake()
    {
        if (I != null) { Destroy(gameObject); return; }
        I = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("GameKernel başlatıldı.");
    }
}
