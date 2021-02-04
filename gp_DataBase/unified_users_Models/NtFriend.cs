using System;
using System.Collections.Generic;

namespace gp_DataBase.unified_users_Models
{
    public partial class NtFriend
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? FriendId { get; set; }
        public string Description { get; set; }
        public DateTime? CreateTime { get; set; }
        public string MyFollow { get; set; }
        public string FollowMy { get; set; }
        public string FriendType { get; set; }
        public string Discipline { get; set; }
        public string Districtcounty { get; set; }
        public string Workshop { get; set; }
        public string School { get; set; }
        public string Teachinggroup { get; set; }
        public string FromUsersName { get; set; }
        public string FromUsersHeadimg { get; set; }
        public string ToUsersName { get; set; }
        public string ToUsersHeadimg { get; set; }
        public int? ProjectId { get; set; }
    }
}
