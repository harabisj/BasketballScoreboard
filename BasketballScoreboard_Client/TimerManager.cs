using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Client
{
    class TimerManager
    {
        private Timer timer;
        private Func<int, bool> onTimerChange;
        private Action onTimerStop;

        private int start_value;
        private int counter;

        public TimerManager(Timer timer, int start_value, Func<int, bool> onTimerChange, Action onTimerStop)
        {
            this.timer = timer;
            Stop();
            timer.Tick += new EventHandler(timer_Tick);
            this.onTimerChange = onTimerChange;
            this.onTimerStop = onTimerStop;

            this.start_value = start_value;
            this.counter = start_value;

            onTimerChange.Invoke(counter);
        }

        public void Start()
        {
            if (counter != 0)
                timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Reset()
        {
            timer.Stop();
            counter = start_value;
            onTimerChange.Invoke(counter);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            onTimerChange.Invoke(counter);
            if (counter == 0)
            {
                Stop();
                onTimerStop.Invoke();
            }
        }
    }
}
