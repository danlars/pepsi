using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class APIContext
    {
        public List<Board> Boards()
        {
            List<Board> board = new List<Board>();
            board.Add(new Board() { id = 1, title = "Kanbas", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. Nulla ultrices odio. " });
            board.Add(new Board() { id = 2, title = "Test", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. Nulla ultrices odio. " });
            board.Add(new Board() { id = 3, title = "Projekt", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. Nulla ultrices odio. " });
            return board;
        }

        public List<Job> Jobs()
        {
            List<Job> jobs = new List<Job>();
            //Board 1
            jobs.Add(new Job() { id = 1, title = "Job titel", BoardId = 1, weight_id =  1 });
            jobs.Add(new Job() { id = 2, title = "Job titel2", BoardId = 1, weight_id = 2 });
            jobs.Add(new Job() { id = 3, title = "Job titel3", BoardId = 1, weight_id = 3 });

            //Board2
            jobs.Add(new Job() { id = 4, title = "Job titel 1", BoardId = 2, weight_id = 1 });
            jobs.Add(new Job() { id = 5, title = "Job title 2", BoardId = 2, weight_id = 2 });
            jobs.Add(new Job() { id = 6, title = "Job title 3", BoardId = 2, weight_id = 3 });

            return jobs;
        }

        public List<Card> Cards()
        {
            List<Card> cards = new List<Card>();
            //Job 1
            cards.Add(new Card() { id = 1, title = "Card 1", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. ", job_id = 1, weight_id = 1, color = "536266", date = DateTime.Today});
            cards.Add(new Card() { id = 2, title = "Card 2", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. ", job_id = 1, weight_id = 2, color = "555555", date = DateTime.Now.AddDays(-1) });

            //Job 2
            cards.Add(new Card() { id = 3, title = "Card 1", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. ", job_id = 2, weight_id = 1, color = "333333", date = DateTime.Now.AddDays(-2) });
            cards.Add(new Card() { id = 4, title = "Card 2", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce quis lectus quis sem lacinia nonummy. Proin mollis lorem non dolor. In hac habitasse platea dictumst. ", job_id = 2, weight_id = 2, color = "000000", date = DateTime.Today.AddDays(-3) });

            //Job 3
            cards.Add(new Card() { id = 5, title = "Card 1", description = "Some description", job_id = 3, weight_id = 1, color = "FFFFFF", date = DateTime.Today.AddDays(-4) });

            return cards;
        } 
             
    }
}