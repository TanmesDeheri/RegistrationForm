using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PratciceWebApplication.ModelLayer
{
    public class ModelLayer
    {
        private int _pid;
        private string _pname;
        private decimal _pcost;
        private string _pdec;
        private string _pimage;
        public int Productid
        {
            get { return _pid; }
            set { _pid = value; }
        }
        public string ProductName
        {
            get { return _pname; }
            set { _pname = value; }
        }
        public decimal ProductCost
        {
            get { return _pcost; }
            set { _pcost = value; }
        }
        public string ProductDescription
        {
            get { return _pdec; }
            set { _pdec = value; }
        }
        public string Productimage
        {
            get { return _pimage; }
            set { _pimage = value; }
        }
    }
}
