using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Voice_Project_0
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_read_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            ss.Rate = trkSpeed.Value;
            ss.Volume = trkValume.Value;
            ss.SpeakAsync(textBox1.Text);
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files|*.txt";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            StreamReader streamReader = new StreamReader(filename);
            textBox1.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Wave Files| *.wav";
            saveFileDialog.ShowDialog();
            string filename;
            filename = saveFileDialog.FileName;
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = trkSpeed.Value;
            ss.Volume = trkValume.Value;
            ss.SetOutputToWaveFile(filename);
            ss.Speak(textBox1.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Text recorded as wave file");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
