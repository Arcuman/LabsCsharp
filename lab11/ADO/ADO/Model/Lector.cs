using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Lector
    {
        public string SNP { get;  set; }
        public string Pulpit { get;  set; }
        public int Auditory { get;  set; }
        public byte[] Data { get;  set; }

        public Lector(string sNP, string pulpit, int auditory, byte[] data)
        {
            SNP = sNP;
            Pulpit = pulpit;
            Auditory = auditory;
            Data = data;
        }

    }
}
