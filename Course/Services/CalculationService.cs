using System.Collections.Generic;
using Course.Entities;

namespace Course.Services {
    class CalculationService {

        public double TotalBonus(List<Person> people) {
            double sum = 0.0;
            foreach (Person person in people) {
                if (person is OrdinaryPerson) {
                    OrdinaryPerson p = (OrdinaryPerson)person;
                    sum += p.OrdinaryBonus();
                }
                if (person is ElderlyPerson) {
                    ElderlyPerson p = (ElderlyPerson)person;
                    sum += p.ElderlyBonus();
                }
            }
            return sum;
        }
    }
}
