
using UnityEngine;

public class END : MonoBehaviour
{
    public GameManager GM;

    void OnTriggerEnter()
    {
        GM.CompleteLevel();
    }
}
