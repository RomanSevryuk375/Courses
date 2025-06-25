namespace H13_T1;

public class Program
{
    static void Main(string[] args)
    {
        var provider1 = new NewsProvider("GlobalInform");
        var provider2 = new NewsProvider("FactPulse");
        var provider3 = new NewsProvider("NewsNectar");

        var Roman = new Client("Roman", provider1, Category.Humor, Category.Sports);
        var Denis = new Client("Denis", provider3, Category.Humor);

        provider3.Notify(Category.Humor, "Админ на работе — как маг: его никто не видит, но если что-то сломается — сразу появляется");
        provider1.Notify(Category.Sports, "12-летний гроссмейстер обыграл трёх чемпионов мира за один день, при этом одновременно решая уравнения по математике!");
        provider2.Notify(Category.Politics, "Громкое заявление: международная коалиция предлагает ввести единую криптовалюту для глобального голосования на выборах будущего!");
        provider1.Notify(Category.Politics, "Шок на выборах: 92-летняя библиотекарь побеждает на пост мэра мегаполиса, пообещав вернуть тишину, порядок и бумажные книги!");
        provider2.Notify(Category.Sports, "Марафонец пробежал дистанцию задом наперёд и финишировал первым, не сбившись с курса ни разу!");
        provider3.Notify(Category.Humor, "Код ревью прошёл успешно — никто не понял, что делает функция, но название звучит убедительно!");


    }
}