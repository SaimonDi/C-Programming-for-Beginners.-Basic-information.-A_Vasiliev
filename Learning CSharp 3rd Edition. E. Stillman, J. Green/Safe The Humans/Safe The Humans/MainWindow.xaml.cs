using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Safe_The_Humans {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCaptured = false;


        public MainWindow() {
            InitializeComponent();

            imageLogo.Visibility = Visibility.Visible;
            enemyTimer.Tick += EnemyTimer_Tick; //Таймер противников
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += TargetTimer_Tick;//Основной таймер
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
        }

        //Настройка таймера врагов

        private void EnemyTimer_Tick(object sender, EventArgs e) {
            AddEnemy();
        }

        //Настройка таймера прогрессбара

        private void TargetTimer_Tick(object sender, EventArgs e) {

            progressBar.Value += 1;
            if (progressBar.Value >= progressBar.Maximum) {
                EndTheGame();
            }

        }

        //Конец игры

        private void EndTheGame() {

            if (!playArena.Children.Contains(gameOverText)) {
                enemyTimer.Stop();
                targetTimer.Stop();
                humanCaptured = false;
                startButton.Visibility = Visibility.Visible;
                playArena.Children.Add(gameOverText);
            }
        }

        //Щелчок по кнопке Старт!

        private void startButton_Click(object sender, RoutedEventArgs e) {
            StartGame();
            imageLogo.Visibility = Visibility.Collapsed;
        }

        //Настройка старта игры

        private void StartGame() {

            human.IsHitTestVisible = true;
            humanCaptured = false;
            progressBar.Value = 0;
            startButton.Visibility = Visibility.Collapsed;
            playArena.Children.Clear();
            playArena.Children.Add(target);
            playArena.Children.Add(human);
            enemyTimer.Start();
            targetTimer.Start();

        }

        //Алгоритм создания врагов в случайных местах

        private void AddEnemy() {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["enemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArena.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArena.ActualHeight - 100), random.Next((int)playArena.ActualHeight - 100), "(Canvas.Top)");
            playArena.Children.Add(enemy);

            enemy.MouseEnter += Enemy_MouseEnter;
        }

        private void Enemy_MouseEnter(object sender, MouseEventArgs e) {
            if (humanCaptured) {
                EndTheGame();
            }
        }

        //Алгоритм анимации противников

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate) {

            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation() {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
            };
            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            storyboard.Children.Add(animation);
            storyboard.Begin();

        }

        private void human_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if (enemyTimer.IsEnabled) {
                humanCaptured = true;
                human.IsHitTestVisible = false;
            }
        }

        private void human_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if (humanCaptured) {
                humanCaptured = false;
                human.IsHitTestVisible = true;
            }
        }


        private void target_MouseEnter(object sender, MouseEventArgs e) {
            if (targetTimer.IsEnabled && humanCaptured) {
                progressBar.Value = 0;
                Canvas.SetLeft(target, random.Next(100, (int)playArena.ActualWidth - 100));
                Canvas.SetTop(target, random.Next(100, (int)playArena.ActualHeight - 100));
                Canvas.SetLeft(human, random.Next(100, (int)playArena.ActualWidth - 100));
                Canvas.SetTop(human, random.Next(100, (int)playArena.ActualHeight - 100));
                humanCaptured = false;
                human.IsHitTestVisible = true;
            }
        }


        private void playArena_MouseMove(object sender, MouseEventArgs e) {

            if (humanCaptured) {
                Point pointerPosition = e.GetPosition(null);
                Point relativePosition = grid.TransformToVisual(playArena).Transform(pointerPosition);
                playArena.MouseLeave += PlayArena_MouseLeave;
                if ((Math.Abs(relativePosition.X - Canvas.GetLeft(human)) > human.ActualWidth * 3) || (Math.Abs(relativePosition.Y - Canvas.GetTop(human)) > human.ActualHeight * 3)) {
                    humanCaptured = false;
                    human.IsHitTestVisible = true;
                } else {
                    Canvas.SetLeft(human, relativePosition.X - human.ActualWidth / 2);
                    Canvas.SetTop(human, relativePosition.Y - human.ActualHeight / 2);
                }
            }
        }

        private void PlayArena_MouseLeave(object sender, MouseEventArgs e) {
            if (humanCaptured) {
                EndTheGame();
            }
        }
    }
}
