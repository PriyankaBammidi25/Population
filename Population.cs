using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Population
{
 
    public class Population
    {
        int applicationId;
        int memberId;
        string firstname;
        string middlename;
        string lastname;
        string suffix;
        DateTime date;
        string gender;

        public int ApplicationId { get => applicationId; set => applicationId = value; }
        public int MemberId { get => memberId; set => memberId = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}