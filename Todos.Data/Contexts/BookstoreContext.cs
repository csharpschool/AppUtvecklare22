namespace Todos.Data.Contexts;

public class DataContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Publisher> Publishers => Set<Publisher>();
    public DbSet<AuthorBook> AuthorBooks => Set<AuthorBook>();

    public DataContext(DbContextOptions<DataContext>
    options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<AuthorBook>()
            .HasKey(tt => new { tt.AuthorId, tt.BookId });
    }
}