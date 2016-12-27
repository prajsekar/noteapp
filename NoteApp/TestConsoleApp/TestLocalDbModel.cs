using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class TestLocalDbModel
    {
        public static void TestModifiedData()
        {
            var ticks =  DateTime.Parse(@"12/22/2016 12:14:10 AM").Ticks;
            var service = new NoteAppService();
            var modifiedEntries = service.bookService.getModified(ticks, 1);
            foreach (var book in modifiedEntries)
            {
                Console.WriteLine("Book Name : " + book.name);
            }
        }
    }
}
