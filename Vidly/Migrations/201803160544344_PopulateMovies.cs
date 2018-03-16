namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('The Hangover',1,11-06-2009,20-06-2009,20,20)");
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('Die Hard',3,20-07-1988,20-06-2000,20,20)");
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('The Terminator',3,26-10-1984,20-06-2000,20,20)");
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('Toy Story',2,22-11-1995,20-06-2000,20,20)");            
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('Black Panther',3,16-02-2018,01-03-2018,20,20)");
            Sql("INSERT INTO Movies(Name,GenreTypesId,ReleaseDate,AvailableDate,NumberInStock,NumberAvailable) VALUES" +
                "('Titanic',5,19-12-1997,20-06-2000,20,20)");
        }
        
        public override void Down()
        {
        }
    }
}
