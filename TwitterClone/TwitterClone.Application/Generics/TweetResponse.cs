using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;

namespace TwitterClone.Application.Generics
{
    public class TweetResponse
    {
        public bool Success { get; set; }
        public TweetDto? Tweet { get; set; }
    }
}
