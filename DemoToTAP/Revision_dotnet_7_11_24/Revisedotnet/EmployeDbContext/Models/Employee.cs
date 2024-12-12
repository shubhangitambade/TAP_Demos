namespace EmployeDbContext.Models
{
    public class Employee
    {
        //[key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.FirstName + " " + this.LastName + " " + this.Email + " " + this.Contact;
        }
    }
}

/*Generally, that error means that your entity class and the database table are out of sync. Based on the entity class, the provider is trying to select a column that doesn't actually exist on the corresponding table in the database, which means you've likely added a property to the class and didn't do a migration to propagate that change to the database.

Long and short, you need to add a migration and update your database, or if you're going with a database-first approach, fix your database so that it matches your entity class or just rerun the scaffolding.*/
