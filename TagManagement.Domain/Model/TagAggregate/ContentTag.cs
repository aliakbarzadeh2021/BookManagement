namespace TagManagement.Domain.Model.TagAggregate
{
    internal class ContentTag : Tag
    {
        internal TagType TagType { get; set; }
    }

    internal enum TagType
    {
        Poem,
        Quran,
        Hadith
    }
}