using System;
namespace NoteApp.Core.Model.Service
{
    public interface INoteAppService
    {
        NotebookService bookService { get; }
        NoteService noteService { get; }
        UserService userService { get; }
    }
}
