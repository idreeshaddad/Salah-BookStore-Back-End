namespace Acme.BookStore.Permissions;

public static class BookStorePermissions
{
    public const string GroupName = "BookStore";

    public static class Books
    {
        public const string Default = GroupName + ".Books"; // BookStore.Books (List, Details)
        public const string Create = Default + ".Create";   // BookStore.Books.Create
        public const string Edit = Default + ".Edit";       // BookStore.Books.Edit
        public const string Delete = Default + ".Delete";   // BookStore.Books.Delete
    }

    public static class Authors
    {
        public const string Default = GroupName + ".Authors"; // AuthorStore.Authors (List, Details)
        public const string Create = Default + ".Create";   // AuthorStore.Authors.Create
        public const string Edit = Default + ".Edit";       // AuthorStore.Authors.Edit
        public const string Delete = Default + ".Delete";   // AuthorStore.Authors.Delete
    }
}
