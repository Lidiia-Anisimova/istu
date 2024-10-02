namespace BadCodeExamples
{
    public abstract class Bird
    {
        public virtual void Fly(int speed)
        {
            //реализация полёта
        }
    }

    /// <summary>
    /// Пингвин
    /// </summary>
    public class Penguin : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            throw new Exception("Penguins don't fly");
        }
    }

    /// <summary>
    /// Страус
    /// </summary>
    public class Ostrich : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            throw new Exception("Ostrich don't fly");
        }
    }

    /// <summary>
    /// Киви
    /// </summary>
    public class Kiwi : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            throw new Exception("Kiwi don't fly");
        }
    }
    // возможно тут можно отнести в DRY, потому что у нас 3 класса птиц не летают, и всё у них одинаково...

    public class Pigeon : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            // голубь летит
        }
    }

}
//возможно еще принцип SOLID, есть класс отвечающий за полет птиц, но у многих птиц в экзэпшене стоит "don't fly", как будто лучше сделать класс для летающих
//и другой класс для не летающих птиц(SRP)
