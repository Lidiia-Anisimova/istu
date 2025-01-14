namespace BadCodeExamples
{
    public abstract class Bird
    {
        public virtual void Fly(int speed) //Нужно поменять название метода, чтобы подходило по смыслу. Т.к. у нас все птицы не умею летать
        {
            //реализация полёта
        }
    }

    /// <summary>
    /// Пингвин
    /// </summary>
    public class Penguin : Bird //так эти птички не умеют летать)
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
    public class Ostrich : Bird //так эти птички не умеют летать)
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
    public class Kiwi : Bird //так эти птички не умеют летать)
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            throw new Exception("Kiwi don't fly");
        }
    }

    public class Pigeon : Bird //так эти птички не умеют летать)
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            // голубь летит
        }
    }

}
