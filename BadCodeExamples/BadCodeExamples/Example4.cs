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

/// Для птиц выше нарушен принцип замещения Лисков (LSP), а именно
/// Перед выполнением наследования необходимо учитывать предварительные условия класса.
/// Выбранные птицы не умеют летать, поэтому не получится для них реализовать полёт.

    public class Pigeon : Bird
    {
        /// <inheritdoc />
        public override void Fly(int speed)
        {
            // голубь летит
        }
    }

}

/// В общем случае нарушен принцип
/// дважды отмерь и один раз отрежь (Measure Twice and Cut Once),
/// так как изначально не была проверена возможность выбранных птиц летать.