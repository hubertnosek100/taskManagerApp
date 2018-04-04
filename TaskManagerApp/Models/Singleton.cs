using System;
namespace TaskManagerApp.Models
{

        using System;
        using System.Collections.Generic;

        public class Singleton
        {
            private static Singleton _instance;

            private Singleton()
            {
                List = new List<string>();
            }
            public static Singleton Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Fullname => FirstName + " " + LastName;

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
            public List<string> List { get; set; }
        }

}
