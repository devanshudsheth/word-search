
/*****************************************************


BY DEVANSHU D. SHETH
dds160030
CS6326


This is the MyObject class that is defined for the list of objects which hold the data

It can set/get values for line and linenumber



******************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg4_dds160030
{
    //Create a class of MyObjects
    //This will be used to maintain objects or in our case line records.

    public class MyObject
    {

        public MyObject()
        {

        }
        //Empty Constructor
        public MyObject(string linenumber, string line)
    {

    }
    private string linenumbervalue;

        //get or set the linenumber
    public string linenumber
    {
        get { return linenumbervalue; }
        set { linenumbervalue = value; }
    }

    private string linevalue;

        //get or set the line
    public string line
    {
        get { return linevalue; }
        set { linevalue = value; }
    }

}




}
