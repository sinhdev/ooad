using System;
using System.Collections.Generic;

namespace ObserverPatternDemo
{
    public abstract class MyObserver
    {
        protected Subject MyObserverSubject {set;get;}
        public abstract void Update();
    }

    public class BinaryObserver : MyObserver
    {
        public BinaryObserver(Subject subject)
        {
            this.MyObserverSubject = subject;
            this.MyObserverSubject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(MyObserverSubject.State,2));
        }
    }

    public class OctalObserver : MyObserver
    {
        public OctalObserver(Subject subject)
        {
            this.MyObserverSubject = subject;
            this.MyObserverSubject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(MyObserverSubject.State,8));
        }
    }

    public class HexaObserver : MyObserver
    {
        public HexaObserver(Subject subject)
        {
            this.MyObserverSubject = subject;
            this.MyObserverSubject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hexa String: " + Convert.ToString(MyObserverSubject.State, 16));
        }
    }
}