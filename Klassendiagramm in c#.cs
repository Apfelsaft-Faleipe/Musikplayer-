using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        UIController ui = new UIController();
        ui.OnPlayClicked();
    }
}

internal class UIController
{
    private MusicPlayer musicPlayer;

    public UIController()
    {
        musicPlayer = new MusicPlayer();
    }

    public void OnPlayClicked()
    {
        musicPlayer.Play();
    }

    public void OnPauseClicked()
    {
        musicPlayer.Pause();
    }

    public void OnNextClicked()
    {
        musicPlayer.Stop();
        musicPlayer.Play();
    }
}

internal class MusicPlayer
{
    private Track currentTrack;
    private AudioOutput audioOutput;

    public MusicPlayer()
    {
        audioOutput = new AudioOutput();
        currentTrack = new Track();
    }

    public void Play()
    {
        currentTrack.GetMetadata();
        audioOutput.Start();
    }

    public void Pause()
    {
        audioOutput.Stop();
    }

    public void Stop()
    {
        audioOutput.Stop();
    }

    public void SetVolume(float c)
    {
        // Lautstärke setzen (Platzhalter)
    }
}

internal class Track
{
    private string id;
    private string title;
    private string artist;
    private string album;
    private int duration;
    private AudioFile source;

    public Track()
    {
        source = new AudioFile();
    }

    public void GetMetadata()
    {
        source.Open();
        source.ReadChunk();
    }
}

internal class AudioOutput
{
    public void Start()
    {
        // Wiedergabe starten
    }

    public void Stop()
    {
        // Wiedergabe stoppen
    }

    public void Write(byte[] buffer)
    {
        // Audio-Daten schreiben
    }
}