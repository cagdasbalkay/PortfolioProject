using System;

namespace PortfolioProject.Models
{
    public class UserImageMessageModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string SenderName { get; set; }
        public string Mail { get; set; }
        public string MessageContent { get; set; }
        public string ImageUrl { get; set; }
    }
}
