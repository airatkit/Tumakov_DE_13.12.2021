using System.Windows;

namespace PointRatingSystem.Windows
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            var entities = new PointRatingSystemEntities();

            MessageBox.Show(passwordTB.Text);

            foreach (var item in entities.Users)
            {
                if (loginTB.Text.Contains(item.Login) && passwordTB.Text.Contains(item.Password))
                {
                    Hide();

                    if (item.Role == "Студент")
                    {
                        new StudentWindow().Show();
                    }

                    else if (item.Role == "Преподаватель")
                    {
                        new TeacherWindow().Show();
                    }

                    else if (item.Role == "Администратор")
                    {
                        new AdminWindow().Show();
                    }

                    else if (item.Role == "СотрудникДирекции")
                    {
                        new DirectionWindow().Show();
                    }
                }
            }

            MessageBox.Show("O");
        }
    }
}
