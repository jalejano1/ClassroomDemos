using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConsoleDriver
{
    //the default of a class is private
    //you will need to change the access default
    //for an outsider user to use the class
    public class Die
    {
        //data members to hold data values
        //the data members will be used in
        //fully implement properties, constructors
        // and/or methods
        private int _Sides;
        private string _Color;

        //fully implemented property
        //properties DO NOT have parameters
        public int Sides
        {
            //get returns the value of the property
            //to the requests call
            get
            {
                //returns the contents of the
                //associated data member
                return _Sides;
            }
            set
            {
                //receives a piece of data
                //and places the data value
                //into the data member

                //remember, properties DO NOT
                //have parameters
                //How does one reference the incoming data?
                //the data is contained in the keyword value
                _Sides = value;

            }
        }//eop

        //auto-implemented property
        //DOES NOT have an associate explicitly coded data member
        //there is a data field created, but it is by the system
        // and managed by the system
        public int FaceValue { get; private set; }

        //validation inside a property
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                //data value cannot be null
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("You must supply a color");
                }
                else
                {
                    _Color = value;
                }

            }
        }//eop

        //contructors
        //you may have any number of constructors
        //if you code a constructor, you become responsible for
        // all constructors of the class
        //two typical constructors are the default and greedy constructor

        //NOTE: CONSTRUCTORS DO NOT HAVE A RETURN DATATYPE

        //default constructor general mimics the system default
        //the constructor name is the class name
        public Die()
        {
            //this constructor would be used when no values are
            //supplied at the time of instantiation
            //  public Die thedice = new Die();

            //you can override the system datatype values
            //by supplying your own default values
            _Sides = 6;
            Color = "White";
        }
    }//eoc
}//eon
