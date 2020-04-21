using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Piante_e_Fiori.Models
{
    [DataContract]
    public class MyAlarm
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public TimeSpan TimeOfDay { get; set; }

        [DataMember]
        public DayOfWeek[] DaysOfWeek { get; set; }

        public bool IsOneTime()
        {
            return SingleFireTime != DateTime.MinValue;
        }

        [DataMember]
        public DateTime SingleFireTime { get; set; }
    }
}
