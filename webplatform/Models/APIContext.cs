using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web;

namespace webplatform.Models
{
    public class APIContext
    {
        public List<Board> Boards()
        {
            List<Board> boards = new List<Board>();

            Task.Run(async () =>
            {
                try
                {
                    foreach (var board in await project_flux.API.Board.GetAvailableBoards())
                    {
                        boards.Add(new Board()
                        {
                            title = board.Name,
                            description = "",
                            id = board.Id,
                            jobs = Jobs(board.Id)
                        });
                    }
                }
                catch { }
            }).Wait();

            return boards;
        }

        public Board FindBoard(Guid BoardId)
        {
            Board board = new Board();
            Task.Run(async () =>
            {
                try
                {
                    var IBoard = await project_flux.API.Board.GetBoardByID(BoardId);
                    board.title = IBoard.Name;
                    board.description = "";
                    board.id = IBoard.Id;
                    //board.teamId = IBoard.TeamId;
                    board.jobs = Jobs(IBoard.Id);
                }
                catch { }
            }).Wait();
            return board;
        }

        public bool AddBoard(Board model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Board.Add(model.teamId, model.title);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();

            return false;
        }

        public bool UpdateBoard(Board model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Board.Update(model.id, model.title);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();

            return false;
        }

        public bool ArchiveBoard(Guid BoardId)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Board.Archive(BoardId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();

            return false;
        }

        public bool DeleteBoard(Guid BoardId)
        {
            Task.Run(async () =>
            {
                try
                {
                    //await project_flux.API.Board.Delete(BoardId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();

            return false;
        }

        public List<Job> Jobs(Guid BoardId)
        {
            List<Job> jobs = new List<Job>();
            Task.Run(async () =>
            {
                try
                {
                    foreach (var job in await project_flux.API.Job.GetJobsByBoardId(BoardId))
                    {
                        jobs.Add(new Job()
                        {
                            id = job.Id,
                            BoardId = BoardId,
                            title = job.Name,
                            Cards = Cards(job.Id)
                        });
                    }
                }
                catch { }
            }).Wait();

            return jobs;
        }

        public Job FindJob(Guid JobId)
        {
            var job = new Job();
            Task.Run(async () =>
            {
                try
                {
                    var iJob = await project_flux.API.Job.GetJobByID(JobId);
                    job.id = iJob.Id;
                    job.BoardId = iJob.BoardId;
                    job.title = iJob.Name;
                    job.Cards = Cards(iJob.Id);
                }
                catch { }
            }).Wait();

            return job;
        }

        public bool AddJob(Job model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Job.Add(model.BoardId, model.title);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();

            return false;
        }

        public bool UpdateJob(Job model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Job.Update(model.id, model.BoardId, model.title); 
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public bool ArchiveJob(Guid JobId)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Board.Archive(JobId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public bool DeleteJob(Guid JobId)
        {
            Task.Run(async () =>
            {
                try
                {
                    //await project_flux.API.Job.Delete(JobId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public List<Card> Cards(Guid JobId)
        {
            List<Card> cards = new List<Card>();
            int count = 0;

            Task.Run(async () =>
            {

                    foreach (var card in await project_flux.API.Card.GetCardsByJobId(JobId))
                    {
                        cards.Add(new Card()
                        {
                            id = card.Id,
                            job_id = JobId,
                            color = card.Color,
                            date = card.DueDate,
                            description = card.Description,
                            title = card.Name,
                            weight_id = card.Weight
                        });
                        count += 1;
                    }

            }).Wait();

            return cards;
        }

        public Card FindCard(Guid CardId)
        {
            Card card = new Card();
                Task.Run(async () =>
                {
                    try
                    {
                        var iCard = await project_flux.API.Card.GetCardByID(CardId);
                        card.id = iCard.Id;
                        card.color = iCard.Color;
                        card.date = iCard.DueDate;
                        card.title = iCard.Name;
                        card.description = iCard.Description;
                        card.job_id = iCard.JobId;
                        card.weight_id = iCard.Weight;
                    }
                    catch { }
                }).Wait();

            return card;
        }

        public bool AddCard(Card model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Card.Add(model.job_id, model.title, model.description, model.weight_id, model.date, model.color);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public bool UpdateCard(Card model)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Card.Update(model.id, model.job_id, model.title, model.description, model.weight_id, model.date, model.color);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public bool ArchiveCard(Guid CardId)
        {
            Task.Run(async () =>
            {
                try
                {
                    await project_flux.API.Card.Archive(CardId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }

        public bool DeleteCard(Guid CardId)
        {
            Task.Run(async () =>
            {
                try
                {
                    //await project_flux.API.Card.Delete(CardId);
                    return true;
                }
                catch
                {
                    return false;
                }
            }).Wait();
            return false;
        }
    }
}