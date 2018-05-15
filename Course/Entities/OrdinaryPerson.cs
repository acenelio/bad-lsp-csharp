namespace Course.Entities {
    class OrdinaryPerson : Person {

        public double OrdinaryBonus() {
            return Amount * 0.1;
        }
    }
}
