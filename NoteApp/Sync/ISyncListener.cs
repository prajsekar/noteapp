using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync
{
    public interface ISyncListener
    {
        void Start();
        void Stop();
        event SyncEventHandler EventReceived;
        bool IsRunning { get; }
        void OnEventReceived(SyncEvent syncEvent);                
        void OnStateChanged(AppState newState);        
    }

    public enum AppState
    {
        Online,
        Offline
    }

    public enum SyncMode
    {
        OneWay,
        TwoWay
    }

    public delegate void SyncEventHandler(object sender, SyncEvent e);
}
