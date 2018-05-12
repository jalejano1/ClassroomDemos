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
        //create a new instance of the math object Random
        //this will be shared by each instance of Die
        //the instance of the math object will be created on the
        //   creation of the first Die instance
        //the death of the math object will be with the death
        //   of the last existing Die instance
        private static Random _rnd = new Random();


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

        //default constructor generally mimics the system default
        //the constructor name is the class name
        public Die()
        {
            //this constructor would be used when no values are
            //supplied at the time of instantiation
            //  public Die thedice = new Die();

            //you can override the system datatype values
            //by supplying your own default values
            SetSides(6);
            Color = "White";
        }

        //greedy constructor generally allows the user to pass in
        //a value for all fields at the time of instantiation
        public Die(int sides, int facevalue, string color)
        {
            //although you can place values directly into private
            //data members, it is best to use the Properties
            //incase there is some validation within the property

            // public Die theDie = new Die(6,3,"White");

            Sides = sides;
            FaceValue = facevalue;
            Color = color;
        }

        //Behaviors (methods)
        //a behaviors is called directly by the user program
        //behaviors can be functions or subroutines
        //behaviors differ from properties in that they can manipulate
        //  multiple data members
        //behaviors are generally used by the outside user therefore public
        //behaviors can be used within the object definitin itself

        public void SetSides(int sides)
        {
            //restrict the number of sides to either 6 or 12
            if (!(sides == 6 || sides == 12))
            {
                throw new Exception("Invalid number of sides for the die. Only 6 or 12 sided dice allowed.");
            }
            else
            {
                Sides = sides;
                Roll();
            }
        }

        public void Roll()
        {
            //will be used to generate a new face value for the instance
            //the method will use the Random math class to generate the value
            // the method .Next(inclusive lowest range value, exclusive highest range value)
            // will be used out of the Random math class
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }//eoc
}//eon
