using efc3.Models;
using System;

namespace efc3
{
    class App
    {
        public ContosouniversityContext _contosouniversityContext { get; private set; }
     
        public App(ContosouniversityContext contosouniversityContext)
        {
            _contosouniversityContext =  contosouniversityContext;
        }


        public void AddItem()
        {
                 using (var db = _contosouniversityContext)
                 {
                     var todo = new Todos();
                     todo.Item = "sdsd";

                     db.Todos.Add(todo);
                     db.SaveChanges();
                 }
                 Console.WriteLine("Data Created!");
                 Console.ReadLine(); 
        }
    }
}
