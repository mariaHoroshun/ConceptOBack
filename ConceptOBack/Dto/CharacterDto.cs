namespace ConceptOBack.Dto
{
    public class CharacterDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Обязательное описание
        /// </summary>
        public string BaseDescription { get; set; } = null!;
    }
}
