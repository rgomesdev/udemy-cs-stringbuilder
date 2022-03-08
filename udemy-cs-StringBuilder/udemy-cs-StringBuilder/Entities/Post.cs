using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_cs_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes.ToString());
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();

            //sem o stringbuilder
            /*string txt = Title + Environment.NewLine;
            txt += $"{Likes} Likes - " + Moment.ToString() + Environment.NewLine;
            txt += Content + Environment.NewLine;
            txt += "Comments: " + Environment.NewLine;
            foreach(Comment comment in Comments)
            {
                txt += comment.Text+Environment.NewLine;
            }
            return txt;*/
        }
    }
}
