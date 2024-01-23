namespace Bookify.Web.Core.Consts
{
    public static class Errors
    {
        public const string MaxLength = "Length cannot be more than {1} characters!";
        public const string Duplicated = "{0} with the same name is already exist!";
        public const string DuplicatedBook = "Book with the same title is already exists with the same author!";
        public const string NotAllowedExtensions = "Only .jpg, .png, .jpeg files are allowed!";
        public const string MaxSize = "Size cannot be more than 2 MB!";
        public const string NotAllowFutureDates = "Date cannot be in the future!";
        public const string InvalidRange = "{0} must be between {1} and {2}!";
    }
}
