using System;
using System.Linq;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new PlutoContext();
            //************************************** LINQ Extentions *************************************

            //Element operators
            var courses = context.Courses.OrderBy(c => c.Level).First();

            ////Partitioning "Paging"
            //var courses = context.Courses.Skip(10).Take(10);

            ////Cross Join
            //context.Authors.SelectMany(a => context.Courses, 
            //    (author, course) => new
            //        {
            //            AuthorName = author.Name,
            //            CourseName = course.Name
            //        }
            //    );


            ////Group Join 1
            //context.Authors.GroupJoin(context.Courses,
            //     a => a.Id,
            //     c => c.AuthorId,
            //    (author, course) => new
            //        {
            //            AuthorName = author.Name,
            //            CourseName = course
            //        }
            //    );

            ////Group Join 2 Counting Authers number of Courses
            //context.Authors.GroupJoin(context.Courses,
            //     a => a.Id,
            //     c => c.AuthorId,
            //    (author, course) => new
            //        {
            //            Author = author,
            //            Courses = course.Count()
            //        }
            //    );


            ////Inner Join
            //context.Courses.Join(context.Authors,
            //    c => c.Author,
            //    a => a.Id,
            //    (course, author) => new
            //        {
            //            CourseName = course.Name,
            //            AuthorName = author.Name
            //        }
            //    );






            ////GroupBy
            //var groups = context.Courses.GroupBy(c => c.Level);


            //foreach (var group in groups)
            //{
            //    Console.WriteLine("Key: " + group.Key);

            //    foreach (var course in group)
            //    {
            //        Console.WriteLine("\t" + course.Name);

            //    }
            //}



            ////Distinct
            //var tags = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .SelectMany(c => c.Tags)
            //    .Distinct();


            //foreach (var t in tags)
            //{
            //    Console.WriteLine(t.Name);
            //}


            ////Projection
            //var tags = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .SelectMany(c => c.Tags);


            //    foreach (var t in tags)
            //    {
            //        Console.WriteLine(t.Name);
            //    }


            ////Projection
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .Select(c => c.Tags);

            //foreach (var c in Courses)
            //{
            //    foreach (var tag in c)
            //    {
            //        Console.WriteLine(tag.Name);
            //    }
            //}

            ////Projection
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .Select(c => new
            //    {
            //        CourseName = c.Name,
            //        AuthorName = c.Author.Name
            //    });


            ////Order By
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name)
            //    .ThenByDescending(c => c.Level);

            ////WHERE
            //var Courses = context.Courses.Where(c => c.Level == 1);

            //************************************** LINQ Querys *************************************
            ////Cross Join
            //var query =
            //    from a in context.Authors
            //    from c in context.Courses
            //    select new { AuthorName = a.Name, CourseName = c.Name };

            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0} ({1})", item.AuthorName, item.CourseName);
            //}

            ////Group Join
            //var query =
            //    from a in context.Authors
            //    join c in context.Courses on a.Id equals c.AuthorId into g
            //    select new { AuthorName = a.Name, Courses = g.Count() };

            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0} ({1})", item.AuthorName, item.Courses);
            //}

            ////Join
            //var query =
            //    from c in context.Courses
            //    join a in context.Authors on c.AuthorId equals a.Id
            //    select new { CourseName = c.Name, AuthorName = a.Name };

            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0} {1}", item.CourseName, item.AutherName);
            //}


            ////Navigation properties
            //var query =
            //    from c in context.Courses
            //    select new { CourseName = c.Name, AutherName = c.Author.Name};

            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0} {1}", item.CourseName, item.AutherName);
            //}



            ////Group by Count
            //var query =
            //    from c in context.Courses
            //    group c by c.Level into g
            //    select g;

            //foreach (var item in query)
            //{
            //    Console.WriteLine("\t{0} ({1})", item.Key, item.Count());
            //}


            ////Group by
            //var query =
            //    from c in context.Courses
            //    group c by c.Level into g
            //    select g;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var c in item)
            //    {
            //        Console.WriteLine("\t{0}",c.Name);
            //    }
            //}


            ////Select to new anonyms object
            //var query =
            //    from c in context.Courses
            //    where c.Author.Id == 1
            //    orderby c.Level descending, c.Name
            //    select new { Name = c.Name, Author = c.Author.Name};

            ////ORDERBY
            //var query =
            //     from c in context.Courses
            //     where c.Author.Id == 1
            //     orderby c.Level descending, c.Name
            //     select c;


            /// WHERE
            //var query =
            //    from c in context.Courses
            //    where c.Level == 1 && c.Author.Id == 1
            //    select c;


            //// LINQ syntax
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("C#")
            //    orderby c.Name
            //    select c;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            ////Extension methode
            //var courses = context.Courses
            //    .Where(c => c.Name.Contains("C#"))
            //    .OrderBy(c => c.Name);

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
