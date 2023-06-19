namespace ConceptOBack.Models
{
    public class User
    {
        public int Id { get; set; }

        /// <summary>
        ///  Имя пользователя
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Пользователь может задать описание
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Список персонажей
        /// </summary>
        public ICollection<Character>? Characters { get; set; }
    }
}
