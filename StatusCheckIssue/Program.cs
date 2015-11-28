using System;
using HAL_Base;
using WPILib;

namespace StatusCheckIssue
{
    public class StatusCheckTest : IterativeRobot
    {
        public override void RobotInit()
        {
            int status = 0;
            uint value = HAL.GetFPGARevision(ref status);
            Utility.CheckStatus(status);
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RobotBase.Main(null, typeof(StatusCheckTest));
        }
    }
}
