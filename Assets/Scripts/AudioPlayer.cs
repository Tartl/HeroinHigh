using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Initialize the AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayAudio(string fileName)
    {
        // Load the audio clip from Addressables
        Addressables.LoadAssetAsync<AudioClip>(fileName).Completed += OnAudioClipLoaded;
    }

    private void OnAudioClipLoaded(AsyncOperationHandle<AudioClip> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            AudioClip clip = handle.Result;
            if (clip != null)
            {
                // Assign the clip to the AudioSource and play it
                audioSource.clip = clip;
                audioSource.Play();
            }
            else
            {
                Debug.LogError("Audio clip not found: " + handle.Result);
            }
        }
        else
        {
            Debug.LogError("Failed to load audio clip: " + handle.OperationException);
        }
    }
}
