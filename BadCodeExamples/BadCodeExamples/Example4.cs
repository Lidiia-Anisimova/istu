namespace BadCodeExamples
{
    // Нарушение SOLID - LSP. 
    // Классы-наследники должны быть заменяемы на базовый класс без изменения поведения программы.
    // В данном случае подклассы (пингвин, страус, киви), которые не могут летать,
    // ломают этот принцип, так как вызывают исключение при попытке полёта.
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
            // Пингвины не летают, но наследуют Fly
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
            // То же самое для страусов
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
            // И то же самое для Киви
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
