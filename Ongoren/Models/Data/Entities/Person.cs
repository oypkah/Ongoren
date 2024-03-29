﻿using Ongoren.Core.Entity;
using Ongoren.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models.Data.Entities
{
    [Table("People")]
    public class Person : CoreEntity
    {
        [MaxLength(5)]
        public string WpOrRp { get; set; }
        [MaxLength(10)]
        public string ApplicationNo { get; set; }
        [MaxLength(15)]
        public string YKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime ImmigrationTrackingEndDate { get; set; }
        public DateTime MailSendDate { get; set; }
        public string ImmigrationFree { get; set; }
        public MailStatus MailStatus { get; set; }
    }
}
