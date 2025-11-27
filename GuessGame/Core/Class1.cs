namespace Core
{
    public class GuessNumberService
    {
        private readonly Random _random = new Random();

        public int SecretNumber { get; private set; }
        public int AttemptsLeft { get; private set; }
        public int WinsCount { get; private set; }

        public bool IsNumberGenerated { get; private set; }

        public void GenerateNumber(int min, int max)
        {
            if (min >= max)
                throw new ArgumentException("Мінімальне число має бути меншим за максимальне.");

            SecretNumber = _random.Next(min, max + 1);
            AttemptsLeft = 5;
            IsNumberGenerated = true;
        }

        public string Guess(int number)
        {
            if (!IsNumberGenerated)
                return "Спочатку згенеруйте число!";

            if (AttemptsLeft <= 0)
                return "Спроби закінчились!";

            AttemptsLeft--;

            if (number == SecretNumber)
            {
                WinsCount++;
                IsNumberGenerated = false;
                return "Ви вгадали!";
            }
            else if (number > SecretNumber)
            {
                return "Число завелике!";
            }
            else
            {
                return "Число замале!";
            }
        }
    }
}