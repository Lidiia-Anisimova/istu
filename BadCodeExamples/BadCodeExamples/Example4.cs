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

    public class Pigeon : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            // голубь летит
        }
    }

}
