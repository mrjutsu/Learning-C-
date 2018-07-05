using System;
namespace Game
{
    class GameException : Exception
    {
        public GameException()
        {

        }

        public GameException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : GameException
    {
        // Default constructor automatically calls the default constructor of base class
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
