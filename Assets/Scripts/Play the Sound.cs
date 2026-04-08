using UnityEngine;

public class PlaytheSound : MonoBehaviour
{
    public AudioSource source;
    
    public void PlaySound()
    {
        source.Play();
    }
}
