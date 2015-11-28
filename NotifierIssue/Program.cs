using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;

namespace NotifierIssue
{
    public class NotifierTest : IterativeRobot
    {
        Notifier notifier;

        public override void RobotInit()
        {
            DateTime old = DateTime.Now;

            notifier = new Notifier(() =>
            {
                DateTime current = DateTime.Now;
                var delta = current - old;
                Console.WriteLine(delta);
                old = current;
            });

            notifier.StartPeriodic(0.1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RobotBase.Main(null, typeof(NotifierTest));
        }
    }
}
