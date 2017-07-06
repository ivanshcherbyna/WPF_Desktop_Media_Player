using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_MediaPlayer
{
    /// <summary>
    /// Логика взаимодействия для EqualizerWimdow.xaml
    /// </summary>
    public partial class EqualizerWimdow : Window
    {
        MediaElement media_element;
        public EqualizerWimdow(MediaElement media)
        {
            InitializeComponent();
            this.media_element = media;
            
        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try { media_element.Volume = sldVolume.Value; }// тут ошибка на экземпляре класса НО РАБОТАЕТ!!
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.TargetSite.ToString()); }

        }

        private void sldBalance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try { media_element.Balance = sldBalance.Value; }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.TargetSite.ToString()); }
           
        }

        private void sldSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try { media_element.SpeedRatio = sldSpeed.Value; }// тут ошибка на экземпляре класса НО РАБОТАЕТ!
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.TargetSite.ToString()); }
        }
    }
}
