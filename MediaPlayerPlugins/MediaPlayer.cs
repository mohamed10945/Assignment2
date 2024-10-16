public class MediaPlayer
{
    private IMedia _media;

    // Constructor to inject the media type
    public MediaPlayer(IMedia media)
    {
        _media = media;
    }

    public void PlayMedia()
    {
        _media.Play();
    }

    public void StopMedia()
    {
        _media.Stop();
    }
}
