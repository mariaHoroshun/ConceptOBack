namespace ConceptOBack.Models
{
    public class CharacterInfoModule
    {
        public int Id { get; set; }

        /// <summary>
        /// Название модуля
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Описание модуля
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// К какому персонажу пренадлежит
        /// </summary>
        public Character Character { get; set; } = null!;
    }
}
