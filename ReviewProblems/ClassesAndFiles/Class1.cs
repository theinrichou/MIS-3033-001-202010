using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndFiles
{
    class Class1
    {
        public string name { get; set; }

        public int id {get;}

        public DateTime enrollDate { get; set; }

        public static int totalStudents { get; set; }

        public Class1 (string name, int id)
        {
            this.name = name;
            this.id = id;
            enrollDate = DateTime.Now;

        }

        public Class1()
        {
            name = string.Empty;
            id = -1;
            enrollDate = DateTime.Now;
        }

        public string getName ()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }


    }
}
