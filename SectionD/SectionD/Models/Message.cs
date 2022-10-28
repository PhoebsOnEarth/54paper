using System;
using Microsoft.EntityFrameworkCore;
namespace SectionD.Models
{
    public class Message
    {
        public Message()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
        public string Text { get; set; }

    }
}

