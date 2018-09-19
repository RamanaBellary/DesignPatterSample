using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Creational
{
    public interface RobotPlan
    {
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void SetRobotArms(string arms);
        void SetRobotLegs(string legs);
    }

    public class Robot : RobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;

        public void SetRobotHead(string head)
        {
            robotHead = head;
        }
        public string GetRobotHead() { return robotHead; }

        public void SetRobotTorso(string torso)
        {
            robotTorso = torso;
        }
        public string GetRobotTorso() { return robotTorso; }

        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }
        public string GetRobotArms() { return robotArms; }

        public void SetRobotLegs(string legs)
        {
            robotLegs = legs;
        }
        public string GetRobotLegs() { return robotLegs; }
    }

    public interface RobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
        Robot GetRobot();
    }

    public class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            robot = new Robot();
        }

        public void BuildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void BuildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }

        public void BuildRobotArms()
        {
            robot.SetRobotArms("Blow torch Arms");
        }

        public void BuildRobotLegs()
        {
            robot.SetRobotLegs("Roller Legs");
        } 

        public Robot GetRobot()
        {
            return this.robot;
        }
    }

    public class RobotEngineer
    {
        private RobotBuilder robotBuilder;

        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            this.robotBuilder.BuildRobotHead();
            this.robotBuilder.BuildRobotTorso();
            this.robotBuilder.BuildRobotArms();
            this.robotBuilder.BuildRobotLegs();
        }
    }
}
