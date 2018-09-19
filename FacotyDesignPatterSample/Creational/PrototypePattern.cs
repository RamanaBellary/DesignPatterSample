using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Creational
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }

    public class Developer : IEmployee
    {
        AdditionalDetails m_details = new AdditionalDetails();

        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PreferredLanguage { get; set; }
        public AdditionalDetails AdditionalDetails { get { return m_details; } set { m_details = value; } }

        public IEmployee Clone()
        {
            Developer dev = (Developer)this.MemberwiseClone();
            dev.AdditionalDetails = m_details.Clone();
            //dev.AdditionalDetails = new AdditionalDetails();
            //dev.AdditionalDetails.Fitness = this.m_details.Fitness;
            //dev.AdditionalDetails.Charisma = this.m_details.Charisma;
            return dev;
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }

    public class AdditionalDetails
    {
        int m_charisma;
        int m_fitness;

        public int Charisma
        {
            get { return m_charisma; }
            set { m_charisma = value; }
        }

        public int Fitness
        {
            get { return m_fitness; }
            set { m_fitness = value; }
        }

        public AdditionalDetails Clone()
        {
            return (AdditionalDetails)this.MemberwiseClone();
        }
    }

}
