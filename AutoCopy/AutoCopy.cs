using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Arbyter
{
    public class AutoCopy
    {
        private Timer _timer;
        private ArbyterCoreCopy _arbyterCopyInstance;
        private TransferLocations _transferLocations;
        public double CopyInterval { get; set; }

 
        public AutoCopy(TransferLocations transferLocations)
        {
            //default copy interval
            CopyInterval = 5 * 60 * 1000;
            _arbyterCopyInstance = ArbyterCoreFactory.Instance.GetArbyterCopy();
            _transferLocations = transferLocations;
            _timer = new Timer();
            _timer.AutoReset = true;
            _timer.Elapsed += new ElapsedEventHandler(TimerElapsedEvent);

        }

        public void StartIntervalCopy()
        {
            _timer.Interval = CopyInterval;
            _timer.Start();
        }

        public void StopIntervalCopy()
        {
            _timer.Stop();
        }

        public void TimerElapsedEvent(object sender, EventArgs args)
        {
            var syncResult = _arbyterCopyInstance.RunCopy(_transferLocations);
            if (syncResult.Result == ActionResult.Failure)
                ErrorManager.Appologise(syncResult.Exception);
        } 
    }
}
