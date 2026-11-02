using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;

namespace TwitterClone.Application.Generics
{
    public class Response
    {
        public bool Success { get; set; }
        public Object? Data { get; set; }
    }

    public class test
    {
        public void run()
        {
            var res = new Response();

            res.Success = true;
            res.Data = new TweetDto      //upcasting the TweetDto object to Object
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Content = ""
            };

            TweetDto tweetDto = (TweetDto)res.Data;  //downcasting the object to TweetDto
        }
    }
}
