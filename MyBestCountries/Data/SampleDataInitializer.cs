using MyBestCountries.Data;
using MyBestCountries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBestCountries.Data
{
    public class SampleDataInitializer
    {
        private MyContriesContext _context;

        public SampleDataInitializer(MyContriesContext context)
        {
            _context = context;
        }
        public void InitializeData()
        {
            CreateVisits();
        }

        private void CreateVisits()
        {
            if (!_context.Visits.Any())
            {
                _context.Visits.Add(new Visit()
                {
                    Id = 0,
                    UserName = "sonwabilestarzuma@gmail.com",
                    Country = "France",
                    City = "Paris",
                    VisitDate = new DateTime(2014, 6, 4),
                    Duration = 31,
                    Notes = "Start of our round-the-world trip",
                    ForWork = false,
                    ForFun = true
                });

                _context.Visits.Add(new Visit()
                {
                    Id = 0,
                    UserName = "sonwabilestarzuma@gmail.com",
                    Country = "United Kingdom",
                    City = "London",
                    VisitDate = new DateTime(2014, 7, 2),
                    Duration = 28,
                    Notes = "Our visit to the UK",
                    ForWork = true,
                    ForFun = true
                });

                _context.Visits.Add(new Visit()
                {
                    Id = 0,
                    UserName = "sonwabilestarzuma@gmail.com",
                    Country = "France",
                    City = "Paris",
                    VisitDate = new DateTime(2014, 6, 4),
                    Duration = 31,
                    Notes = "Start of our round-the-world trip",
                    ForWork = false,
                    ForFun = true
                });

                _context.Visits.Add(new Visit()
                {
                    Id = 0,
                    UserName = "sonwabilestarzuma@gmail.com",
                    Country = "France",
                    City = "Paris",
                    VisitDate = new DateTime(2014, 6, 4),
                    Duration = 31,
                    Notes = "Start of our round-the-world trip",
                    ForWork = false,
                    ForFun = true
                });

                _context.SaveChanges();

            }
        }

    }
}


