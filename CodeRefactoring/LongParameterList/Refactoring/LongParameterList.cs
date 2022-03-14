
using System;
using System.Collections.Generic;

namespace CodeRefactoring.Refactoring.LongParameterList
{
    public class LongParameterList
    {
        public class DateRange
        {
            private DateTime _dateFrom;
            private DateTime _dateTo;

            public DateRange(DateTime dateFrom, DateTime dateTo)
            {
                _dateFrom = dateFrom;
                _dateTo = dateTo;
            }

            public DateTime DateFrom
            {
                get { return _dateFrom; }
            }
            public DateTime DateTo
            {
                get { return _dateTo; }
            }
        }

        public class ReservationsQuery
        {
            public DateRange DateRange { get; set; }
            public User User { get; set; }
            public int LocationId { get; set; }
            public LocationType LocationType { get; set; }
            public int? CustomerId { get; set; }
        }

        public IEnumerable<Reservation> GetReservations(
           ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(
            ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
