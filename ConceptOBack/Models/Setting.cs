
namespace ConceptOBack.Models
{
    public class Setting
    {
        public int Id { get; set; }

        /// <summary>
        /// Название сеттинга
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Ссылка на подробную информацию
        /// </summary>
        public string UrlInfo { get; set; } = null!;

        /// <summary>
        /// Принадлежащие к сеттингу персонажи
        /// </summary>
        public ICollection<Character>? Characters { get; set; }
    }
}
