using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Awesome.Model;
using Awesome.Data;

namespace Awesome.Data.SampleData
{
    public class AwesomeDatabaseInitializer : DropCreateDatabaseIfModelChanges<AwesomeDbContext>
    {
        protected override void Seed(AwesomeDbContext context)
        {
            //context.Movies.AddOrUpdate(r => r.MovieName,
            //    new Movie { MovieName = "Avatar", DirectorName = "James Cameron", ReleaseYear = "2009" },
            //                 new Movie { MovieName = "Titanic", DirectorName = "James Cameron", ReleaseYear = "1997" },
            //     new Movie { MovieName = "Die Another Day", DirectorName = "Lee Tamahori", ReleaseYear = "2002" },
            //     new Movie
            //     {
            //         MovieName = "Godzilla",
            //         DirectorName = "Gareth Edwards",
            //         ReleaseYear = "2014",
            //         Reviews = new List<ClassUnit>{
            //           //new ClassUnit{ReviewerRating=5,ReviewerComments="Excellent",ReviewerName="Rahul Sahay"}
            //         }
            //     });

        }
    }
}
