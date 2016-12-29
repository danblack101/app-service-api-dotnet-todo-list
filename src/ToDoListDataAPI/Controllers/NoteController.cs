using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ToDoListDataAPI.Controllers
{
    public class NoteController : ApiController
    {

        public IEnumerable<Note> Get()
        {
            var list = new List<Note>()
            {
                new Note {content = "Hello World" },
                 new Note {content = "again" }
            };

            return list;
        }


    }

    public class Note
    {
        public string content { get; set; }
    }
}
