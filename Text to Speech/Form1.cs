using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Text_to_Speech
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            SelectBox.Items.Add("Male");
            SelectBox.Items.Add("Female");
            SelectBox.Text = "Please Select a Voice";
        }
    
        private void Convert_btn_Click(object sender, EventArgs e)
        {
            
            if (SelectBox.SelectedItem=="Male")
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                synthesizer.Speak(textBox1.Text);
            }
            else if (SelectBox.SelectedItem=="Female")
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                synthesizer.Speak(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Please Select a Voice", "Error",MessageBoxButtons.OK
                ,MessageBoxIcon.Error);
            }
          
           

        }

    
        
        
    }
}
