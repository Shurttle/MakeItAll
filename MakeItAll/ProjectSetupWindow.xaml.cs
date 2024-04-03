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

namespace MakeItAll
{
    /// <summary>
    /// Логика взаимодействия для ProjectSetupWindow.xaml
    /// </summary>
    public partial class ProjectSetupWindow : Window
    {
        public ProjectSetupWindow()
        {
            InitializeComponent();
            //UpdateMethodologies(true);
        }

        //private void RbSingleUser_Checked(object sender, RoutedEventArgs e)
        //{
        //    UpdateMethodologies(true);
        //}

        //private void RbMultipleUsers_Checked(object sender, RoutedEventArgs e)
        //{
        //    UpdateMethodologies(false);
        //}

        //private void UpdateMethodologies(bool isSingleUser)
        //{
        //    panelMethodologies.Children.Clear(); 
        //    panelMethodologies.Children.Add(CreateMethodologyButton("Скрам", typeof(ScrumWindow)));
        //    panelMethodologies.Children.Add(CreateMethodologyButton("Диаграмма Ганта", typeof(GanttChartWindow)));

        //    if (!isSingleUser)
        //    {
        //        panelMethodologies.Children.Add(CreateMethodologyButton("Канбан-доска", typeof(KanbanBoardWindow)));
        //    }
        //}

        //private Button CreateMethodologyButton(string content, Type windowType)
        //{
        //    Button button = new Button
        //    {
        //        Content = content,
        //        Margin = new Thickness(2),
        //        Padding = new Thickness(10)
        //    };
        //    button.Click += (sender, e) =>
        //    {
        //        var window = (Window)Activator.CreateInstance(windowType);
        //        window?.ShowDialog(); 
        //    };
        //    return button;
        //}
    }
}
