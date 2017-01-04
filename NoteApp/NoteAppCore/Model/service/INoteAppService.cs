using NoteApp.Core.Model.Entity;
using System;
namespace NoteApp.Core.Model.Service
{
    public interface INoteAppService
    {
        NotebookService bookService { get; }
        NoteService noteService { get; }
        UserService userService { get; }
        User user { get; set; }
        void init();
    }
}
