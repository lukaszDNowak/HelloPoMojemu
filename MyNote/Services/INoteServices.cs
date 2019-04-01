using MyNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNote.Services
{
    public interface INoteServices
    {
        List<Note> Notes { get; }
        void AddNote(Note note);
        void DeleteNote(int? id);
    }
}
