using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP1
{
    class Post
    {
        public string Title { get; }
        public string Description { get; }
        private int _votes = 0;
        public DateTime DateTime;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.DateTime = DateTime.Now;
            this._votes = 0;
        }

        public void UpVote()
        {
            this._votes += 1;
        }

        public void DownVote()
        {
            if (this._votes <= 0)
                throw new InvalidOperationException();
            this._votes--;
        }

        public int GetVotes()
        {
            return this._votes;
        }
    }
}
