using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webplatform.Models
{
    public class TestModelBuilder
    {
        public List<Board> getBoards()
        {
            List<Board> board = new List<Board>();
            board.Add(new Board() { id = 1, name = "Kanbas", created_at = DateTime.Today, updated_at = DateTime.Today });
            board.Add(new Board() { id = 2, name = "Test", created_at = DateTime.Today, updated_at = DateTime.Today });
            board.Add(new Board() { id = 3, name = "Projekt", created_at = DateTime.Today, updated_at = DateTime.Today });
            return board;
        }

        public List<Job> getJobs()
        {
            List<Job> jobs = new List<Job>();
            //Board 1
            jobs.Add(new Job() { id = 1, title = "Job titel", board_id = 1, weight_id =  1 });
            jobs.Add(new Job() { id = 2, title = "Job titel2", board_id = 1, weight_id = 2 });
            jobs.Add(new Job() { id = 3, title = "Job titel3", board_id = 1, weight_id = 3 });

            //Board2
            jobs.Add(new Job() { id = 4, title = "Job titel 1", board_id = 2, weight_id = 1 });
            jobs.Add(new Job() { id = 5, title = "Job title 2", board_id = 2, weight_id = 2 });
            jobs.Add(new Job() { id = 6, title = "Job title 3", board_id = 2, weight_id = 3 });

            return jobs;
        }

        public List<Card> getCards()
        {
            List<Card> cards = new List<Card>();
            //Job 1
            cards.Add(new Card() { id = 1, title = "Card 1", description = "Some description", job_id = 1, weight_id = 1 });
            cards.Add(new Card() { id = 2, title = "Card 2", description = "Some description", job_id = 1, weight_id = 2 });

            //Job 2
            cards.Add(new Card() { id = 3, title = "Card 1", description = "Some description", job_id = 2, weight_id = 1 });
            cards.Add(new Card() { id = 4, title = "Card 2", description = "Some description", job_id = 2, weight_id = 2 });

            //Job 3
            cards.Add(new Card() { id = 5, title = "Card 1", description = "Some description", job_id = 3, weight_id = 1 });

            return cards;
        } 
             
    }
}