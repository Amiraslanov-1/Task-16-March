using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class User
    {
        private string _username;
        private string _password;

        public User(string username ,string password)
        {

            _username = username;
            _password = password;   
        }

        public User()
        {
        }

        public string UserName
        {
            get => this._username;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 6 && value.Length <= 25)
                {
                    this._username = value;
                }
                
            }
        }
        public string Password
        {
            get => this._password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value)&&(value.Length >= 8) && (value.Length <= 25) && char.IsUpper(value[0]) && char.IsLower(value[0]) && char.IsDigit(value[0]))
                {
                    this._password = value;
                }

            }
        }


        User Username = new User()
        {
            _password = Console.ReadLine(),
            _username = Console.ReadLine(),
        };



            private static bool HasUpper(string Pass)
             { 
             bool Upper=false;

            for (int i = 0; i <Pass.Length; i++)
            {
                if(char.IsUpper(Pass[i]))
                    Upper=true;
            }
                return Upper;
            }


            private static bool HasLower(string Pass)
            {
            bool Lower = false;

            for (int i = 0; i < Pass.Length; i++)
            {
                if (char.IsLower(Pass[i]))
                    Lower = true;
            }
            return Lower;
            }


            private static bool HasDigit(string Pass)
            {
                bool Digit = false;

                for (int i = 0; i < Pass.Length; i++)
                {
                    if (char.IsDigit(Pass[i]))
                        Digit = true;
                }
                return Digit;
            }
        }
        //private static bool CheckValidation(string Password)
        //{
        //    bool Upper = false;
        //    bool Lower = false;
        //    bool Digit = false;
        //    for (int i = 0; i < Password.Length; i++)
        //    {
        //        if(char.IsUpper(Password[i]))
        //            Upper = true;
        //        else if (char.IsLower(Password[i]))
        //            Lower = true;
        //        else if (char.IsDigit(Password[i]))
        //            Digit = true;
        //        if (Upper&&Lower&&Digit)
        //            return true;
        //    }
        //    return false;
        //}
    }

    
