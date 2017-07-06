using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;


namespace WPF_MediaPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String filePath = null;
        enum State { Play, Pause };
        State state;
        bool isUserDragging = false;
        Timer timer = new Timer();
        EqualizerWimdow windowEq = null;


        public MainWindow()
        {
            InitializeComponent();
            media.LoadedBehavior = MediaState.Manual; //по умолчанию задает вопспроизведение после загрузки или Manual для запуска кодом
            media.UnloadedBehavior = MediaState.Close;
            state = State.Play;
            timer.Interval = 400;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((media.Source != null) && (media.NaturalDuration.HasTimeSpan) && (!isUserDragging))
            { sld.Value = media.Position.TotalSeconds; }
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
           // if (windowEq == null)
           // {

                windowEq = new EqualizerWimdow(media);
                windowEq.Show();
                

           // }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Media Files|*.mp3;*.mpg;*.mpeg;*.avi;*.mp4;*.mov";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = open.FileName;
                media.Stop();
                media.Source = new Uri(filePath);
            }

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (state == State.Play)
            {
                media.Play();
                state = State.Pause;
            }
            else {
                media.Pause();
                state = State.Play;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            state = State.Play;
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (!media.HasAudio && !media.HasVideo) {
                System.Windows.MessageBox.Show("Error", "Error message", MessageBoxButton.OK, MessageBoxImage.Error);}
                else sld.Maximum=(int)media.NaturalDuration.TimeSpan.TotalSeconds;
            
        }

        private void btnRev_Click(object sender, RoutedEventArgs e)
        {
            if (media.Position > TimeSpan.FromSeconds(5))
            {
                media.Pause();
                media.Position -= TimeSpan.FromSeconds(5);
                media.Play();
            }
        }

        private void btnFF_Click(object sender, RoutedEventArgs e)
        {
            if (media.Position > TimeSpan.FromSeconds(5))
            {
                media.Pause();
                media.Position += TimeSpan.FromSeconds(5);
                media.Play();
            }
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbl.Content = TimeSpan.FromSeconds(sld.Value).ToString(@"hh\:mm\:ss");

        }

        private void sld_DragStarted_1(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isUserDragging = true;
        }

        private void sld_DragCompleted_1(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isUserDragging = true; media.Pause();
            media.Position = TimeSpan.FromSeconds(sld.Value);
            media.Play(); isUserDragging = false;
            
        }

        private void Grid_Unloaded_1(object sender, RoutedEventArgs e)
        {
            media.Close();//если не вызвать этот метод - то приложение будет закрывать уже система (это нехорошо)
            windowEq.Close();
        }
    }
}
