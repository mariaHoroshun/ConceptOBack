﻿using ConceptOBack.Data;
using ConceptOBack.Models;

namespace ConceptOBack
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context) 
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            var settings = new List<Setting>()
            {
                new Setting()
                {
                    Name = "Эберрон (D&D)",
                    Description = "Эберрон совмещает в себе фэнтези с элементами нуарного детектива, а также приключенческой и научной фантастики: поездами, псионикой, воздушными кораблями и механическими разумными созданиями.",
                    UrlInfo = "https://rpg.fandom.com/ru/wiki/%D0%AD%D0%B1%D0%B5%D1%80%D1%80%D0%BE%D0%BD",
                    BackPictureUrl = "",
                    IconPictureUrl="",
                },
                new Setting()
                {
                    Name = "Spelljammer (D&D)",
                    Description = "Между мирами, заключёнными в хрустальные сферы, можно было путешествовать на кораблях с особыми устройствами— «волшебными кормилами». Корабли, оборудованные такими устройствами, способны перемещаться по пространству не только внутри сферы, но и между ними. ",
                    UrlInfo = "https://rpg.fandom.com/ru/wiki/Spelljammer",
                    BackPictureUrl = "",
                    IconPictureUrl="",
                },
                new Setting()
                {
                    Name = "Vampire: The Masquerade (WoD)",
                    Description = "В основе игрового процесса лежит детально проработанный аналог реального мира с огромной примесью сверхъестественных элементов.В главных ролях в большинстве случаев оказываются группировки сверхъестественных существ — оборотней, вампиров, демонов, призраков.",
                    UrlInfo = "https://rpg.fandom.com/ru/wiki/Vampire:_The_Masquerade",
                    BackPictureUrl = "",
                    IconPictureUrl="",
                },

                new Setting()
                {
                    Name = "Rogue Trader (Warhammer 40K)",
                    Description = "Персонажам игроков предлагается взять на себя роль команды (точнее, командиров — полная команда космического корабля в мире WH40K исчисляется тысячами) торгового корабля (который с тем же успехом может быть также пиратским кораблем, кораблем контрабандистов и совмещать с основной функцией прочие теневые операции)",
                    UrlInfo = "https://rpg.fandom.com/ru/wiki/Rogue_Trader",
                    BackPictureUrl = "",
                    IconPictureUrl="",
                },
                new Setting()
                {
                    Name = "Dark Heresy (Warhammer 40K)",
                    Description = "Персонажи играют за аколитов Инквизиции — могущественной организации, действующей по всему Империуму и занятой защитой человечества от внутренних угроз.",
                    UrlInfo = "https://rpg.fandom.com/ru/wiki/Dark_Heresy",
                    BackPictureUrl = "",
                    IconPictureUrl="",
                }
            };

            dataContext.Settings.AddRange(settings);

            var user = new List<User>()
            { 
                new User() 
                { 
                    Name = "funny",
                    Status = "Пустой тестовый юзер"

                },
            new User()
            {
                Name = "Marhor",
                Status = "Тестовый юзер тестирует тут всякие вещи",
                Characters = new List<Character>()
                {
                                            new Character()
                        {
                            Name = "The Everhungry Grisha",
                            BaseDescription = "В прошлом - великий кузнец и мерзавец, ныне - пустая оболочка, со страхом пытающаяся вспомнить своё прошлое. То самое мерзкое прошлое, которое вонзает свой кинжал тем глубже в душу, чем больше о нём узнают...",
                            CharacterInfos = new List<CharacterInfoModule>()
                            {
                                new CharacterInfoModule()
                                {
                                    Name = "Основная информация",
                                    Description =
                                    "Раса: Дроу \v" +
                                    "Класс: Варвар \v" +
                                    "Подкласс: Тотемный воин "
                                },
                                new CharacterInfoModule()
                                {
                                    Name = "Первая встреча",
                                    Description = "Смутная грязная фигура шатается под тяжёлыми каплями дождя, скрываясь от грозы и влаги под редкими выступами крыш домов. " +
                                    "От контейнера к контейнеру, ловя крыс и подбирая объедки с таверн и постоялых дворов. Медленно но верно, фигура встречает и вас."
                                },
                                new CharacterInfoModule()
                                {
                                    Name = "Характер",
                                    Description = "Молчаливый и нелюдивый, часто погружён в свои мысли и смотрит в одну точку. Иногда впадает в глодное безумие, и находится в нём, пока не вкусит живой плоти" +
                                    "склонен к вспышкам ярости в бою."
                                },
                                new CharacterInfoModule()
                                {
                                    Name = "Цель",
                                    Description = "Вспомнить своё прошлое, исправить ошибки, излечит сердца тех, кто ему когда-то доверял. Избавиться от ужасного неописуемого голода, который словно стервятник, налетает на измученную душу Гришы"
                                },

                            },
                            Setting = new Setting()
                            {
                                Name = "Er (DnD)",
                                Description = "Рассыпаные по Ер десятки архипелагов и континентов. Каждый несёт на себе историю. Любовь, предательство, отчаяние, одиночество - жестокий мир, в котором нет ничего более редкого, чем доброта и милосердие. И тем не менее, теперь вы - его часть. Интересно, как ваши поступки повлияют на него.",
                                UrlInfo = "https://dnd.su/?ysclid=lj4nvbqpxb910179179",
                            }
                        },
                    new Character()
                    {
                        Name = "S.H.A. - 5",
                        BaseDescription = "S.H.A. (second headmaster algorithm) - разработка отдела 'Дельта протокол' по искусственному пробуждению психотерической связи в мозгу делак. Но как обычно, все пошло не так...",
                        CharacterInfos = new List<CharacterInfoModule>()
                        {
                            new CharacterInfoModule()
                            {
                                Name = "Начало и первая итерация",
                                Description = "9.284.198.М40. Последние два десятилетия на Некромунде происходили варповые аномалии, затмевающие собой зов Великих, что по некоторым предположениям и отразилось на доме Делак как непривычный недостаток членов дома с естественной психотерической связью. Для банд, которые имели большую численность и базирование в больших городах-ульях, это обозначало более бережное отношение к мастерам теней, повышение конспирации и безопасности. Бандам, которые находились в отдалении грозило расформирование без наличия того, кто мог бы проводить волю Великих.\n 'Дельта протокол' переживали кризис после потери своего мастера теней Ксаутха. \n Причина сметри: Поражение электрическим током. Во время разогревания утреннего пайка субъект залез вилкой в нагревательный аппарат, когда тот работал на полной мощности. Те усилия, которые были приложены к созданию искусственной психосвязи не должны были уйти впустую. Было принято решение, что пересадка усовершенствованного мозга в новое тело будет проще, чем повторение операций."
                            },
                            new CharacterInfoModule()
                            {
                                Name = "Вторая итерация",
                                Description = "Причина сметри: Отравление от облизвания своего же отравленного смертельным ядом ножа."
                            },
                            new CharacterInfoModule()
                            {
                                Name = "Третья итерация",
                                Description = "Причина смерти: Со время 'мирных' переговоров с ячейкой дома Кавдор 'Несущие свет', был вызван для ритуала освящения. Который включал в себя хождение босиком по битому стеклу. Смерть от отравления крови."
                            },
                            new CharacterInfoModule()
                            {
                                Name = "Четвертая итерация",
                                Description = "Причина смерти: Смерть от анафилактический шока. Субъект поспорил с держателем таверны в нижнем подулье, что у него нет аллергии на терранские каштаны, и в качестве доказательства, употребил в пишу пол киллограма. Оказывается, у него была аллергия. "
                            },
                            new CharacterInfoModule()
                            {
                                Name = "Предательство и Lagy Gaga Civil War",
                                Description = "За последние пару итераций у субъета развилась странная привязанность к музыке древних времен. В особенности после добычи физических носителей с аудиозаписями исполнителя 'Lady Gaga'. К сожалению, у нас были в распоряжении мощные динамики, которые и были задействованы для вопроизведения данных аудио. Это было ужасно. Из-за повышенных чувств о"
                            },
                            new CharacterInfoModule()
                            {
                                Name = "Отстранение от командования и последующее жалкое сущетсвование",
                                Description = "После того, как для разрешения конфликта прибыли агенты и мастер теней, владеющей естественной психотерической связью, S.H.A. - 5 был отстранен от любях форм командования, а вся история не упоминалась под страхом возможного гнева Звездной Палаты из-за попыток подделать первородный дар Великих."
                            },
                        },
                        Setting = new Setting()
                        {
                            Name = "",
                            Description = "В почерневших промышленных ульях банды постоянно сражаются за контроль над территориями, Силовики борются за установление верховенства закона, а щупальца коварных культов пробираются сквозь население. Это мир, в котором самое большее, на что можно надеяться, — это выживание, поэтому он породил людей, которые умеют выживать.",
                            UrlInfo = "https://warhammer40k.fandom.com/ru/wiki/%D0%9D%D0%B5%D0%BA%D1%80%D0%BE%D0%BC%D1%83%D0%BD%D0%B4%D0%B0",
              BackPictureUrl = "",
                    IconPictureUrl="",
                        }
                    }
                }
            }
            };

            dataContext.Users.AddRange(user);
            dataContext.SaveChanges();
            }
        }
    }
