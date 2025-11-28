namespace Core
{
    public class GuessNumberService
    {
        private static readonly Random _random = new Random();

        private int _secretNumber;
        private int _attemptsLeft = 5;
        private int _winsCount = 0;
        private int _min = 1;
        private int _max = 100;
        private const int DefaultAttempts = 5;

        public int AttemptsLeft => _attemptsLeft;
        public int WinsCount => _winsCount;
        public int Min => _min;
        public int Max => _max;
        public bool IsNumberGenerated { get; private set; } = false;

        public void GenerateNumber(int min, int max)
        {
            if (min >= max)
                throw new ArgumentException("Мінімальне число має бути меншим за максимальне.");

            _min = min;
            _max = max;
            _secretNumber = _random.Next(_min, _max + 1);
            _attemptsLeft = DefaultAttempts;
            IsNumberGenerated = true;
        }


        public string Guess(int number)
        {
            if (!IsNumberGenerated)
                return "Спочатку згенеруйте число!";

            if (_attemptsLeft <= 0)
                return $"Спроби закінчились! Загадане число було: {_secretNumber}";

            _attemptsLeft--;

            if (number == _secretNumber)
            {
                _winsCount++;
                IsNumberGenerated = false;
                return "Ви вгадали! Так тримати!";
            }

            if (_attemptsLeft == 0)
            {
                var lostNumber = _secretNumber;
                IsNumberGenerated = false;
                ResetStreak(); 
                return $"Ви програли! Загадане число було: {lostNumber}";
            }

            return number < _secretNumber ? "Більше ↑" : "Менше ↓";
        }



        public void ResetStreak()
        {
            _winsCount = 0;
        }
    }
}