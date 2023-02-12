using System;

namespace importee
{
    public class Proprty //properties
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        private string _city;
        private string _email;
        public int id { //properties getter and setters
            set
            {
                if (value <= 0)
                {
                    throw new Exception("ID cannot be a negative number!");
                }

                this._id = value;
            }

            get 
            { return _id; }
        }

        public string name  //properties getter and setters
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("name cannot be null or empty");
                }
                this._name= value;
            }
            get { 
                return string.IsNullOrEmpty(this._name)? "no name" : this._name;
            }
        }

        public int pass  //properties setters
        {
            get { 
                return this._passMark; 
            }
        }
        public string City { get => this._city; set => this._city = value; } //properties getter and setters
        public string Email { get => this._email; set => this._email = value; } //properties getter and setters

    }

    public class ProgramerProps
    {
        public static void Main11()
        {
            Proprty C1 =new Proprty(); //instantiating
            C1.id = 1;
            C1.name = "Jason";
            C1.City = "Lagos";
            C1.Email = "erisjason@gmail.com";

            Console.WriteLine($"{C1.name}, {C1.id}, {C1.pass}, {C1.Email}, {C1.City}");

        }
    }
}

