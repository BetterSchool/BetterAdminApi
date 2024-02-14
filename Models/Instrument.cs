﻿namespace BetterSchoolAPI.Models
{
    public class Instrument
    {
        public int InstrumentID { get; set; }
        //Auto generated by the database
        public string InstrumentName { get; set; }
        public string InstrumentType { get; set; }
        public double Price { get; set; }
        //price per month
        public DateTime BookingDate { get; set; }
        public Guid PersonID { get; set; }
    }
}
