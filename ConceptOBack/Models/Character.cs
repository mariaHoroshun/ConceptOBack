namespace ConceptOBack.Models
{
    public class Character
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

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Автор персонажа
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Сеттинг, к которому пренадлежит персонаж
        /// </summary>
        public Setting Setting { get; set; } = null!;

        /// <summary>
        /// Дополнительные модули информации
        /// </summary>
        public ICollection<CharacterInfoModule>? CharacterInfos { get; set; }
    }
}
