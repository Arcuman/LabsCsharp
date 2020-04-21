using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Discipline
    {
        public string Name { get; set; }
        public int Term { get; set; }
        public int Course { get; set; }
        public string Specialization { get; set; }
        public float LecturesCount { get; set; }
        public float LabsCount { get; set; }
        public string ControlType { get; set; }
        public Discipline(string name, int term, int course, string spec, float lect, float labs, string control)
        {
            Name = name;
            Term = term;
            Course = course;
            Specialization = spec;
            LecturesCount = lect;
            LabsCount = labs;
            ControlType = control;
        }
    }
}
