namespace Course.Entities {
    class ElderlyPerson : Person {

        public double ElderlyBonus() {
            return Amount * 0.2;
        }
    }
}
