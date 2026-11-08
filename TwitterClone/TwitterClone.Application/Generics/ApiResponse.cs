using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Generics
{
    public class ApiResponse<TDto> where TDto : class
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public TDto? Data { get; set; }
    }

    public class Verify
    {
        public void run()
        {
            var res = new ApiResponse<TweetDto>();
            res.Success = true;
            res.Data = new TweetDto
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Content = ""
            };

            var user = res.Data.UserId; 
        }
    }
}
