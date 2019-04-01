using MyNote.Data;
using MyNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNote.Services
{
    public class NoteServices : INoteServices
    {
        private readonly ApplicationDbContext context;

        public NoteServices(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Note> Notes => context.Notes.ToList();

        public void AddNote(Note note)
        {
            note.dataTime = DateTime.Now;
            context.Notes.Add(note);
            context.SaveChanges();
        }
        public void DeleteNote(int? id)
        {
            var note = context.Notes.Find(id);
            context.Notes.Remove(note);
            context.SaveChanges();
        }
    }
}
