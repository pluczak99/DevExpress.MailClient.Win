namespace MailClient.Data.Library.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;

    internal sealed class ToDoTaskConfiguration : EntityTypeConfiguration<ToDoTask>
    {
        public ToDoTaskConfiguration()
        {
            this.Property(s => s.Note).IsRequired();
            this.Property(s => s.Location).IsRequired();
            this.Property(s => s.StartDate).IsRequired();
            this.Property(s => s.EndDate).IsRequired();
        }
    }
}
