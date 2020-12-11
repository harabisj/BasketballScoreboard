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

        private int startValue;
        private int counter;

        public TimerManager(Timer timer, int startValue, Func<int, bool> onTimerChange, Action onTimerStop)
        {
            this.timer = timer;
            Stop();
            timer.Tick += new EventHandler(timer_Tick);
            this.onTimerChange = onTimerChange;
            this.onTimerStop = onTimerStop;

            this.startValue = startValue;
            this.counter = startValue;

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
            counter = startValue;
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
