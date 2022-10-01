using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Follow
    {
        public int Id { get; set; }
        public int? FollowerId { get; set; }
        public int? FollowerrId { get; set; }

        public virtual Usuario? Follower { get; set; }
        public virtual Usuario? Followerr { get; set; }
    }
}
