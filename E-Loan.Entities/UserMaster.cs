﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace E_Loan.Entities
{
    public class UserMaster
    {
        /// <summary>
        /// Use this class for User and Identity manager
        /// </summary>
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public IdProofType? IdproofTypes { get; set; }
        public string IdProofNumber { get; set; }
        public bool Enabled { get; set; }
    }
}
