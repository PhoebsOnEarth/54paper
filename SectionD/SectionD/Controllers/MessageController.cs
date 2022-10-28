using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SectionD.Models;
using SectionD.Services;
using SectionD.Data;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SectionD.Controllers
{
    
    public class MessageController : Controller
    {
        private MsgDbContext cxt;
        private MessageTracker tracker;
        public MessageController(MsgDbContext cxt,MessageTracker tracker)
        {
            this.cxt= cxt;
            this.tracker = tracker;
        }

        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }

        [HttpPost]
        public ViewResult Save(Message message)
        {
            tracker.add(message);
            return View(message);
        }

        public IActionResult Redeem()
        {
            return View();
        }

        public IActionResult Read(Message message)
        {
            if (Guid.Equals(tracker.Messages.FirstOrDefault().Key, message.Id))
            {
                tracker.Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
                return View(new Message()
                {
                    Id = tracker.Messages.FirstOrDefault().Key,
                    Text = tracker.Messages.FirstOrDefault().Value
                });
            }
            tracker.Delete();
            return View();
        }

        public IActionResult CountDown()
        {
            Response.ContentType = "text/event-stream";
            while(true)
            {
                Response.WriteAsync("data: true\n\n"); ; 
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

