using System.Collections.Generic;

namespace ProyectoDIAndres.Observer_Subject {

    class Subject {

        private List<Observer> mobservers;
        
        public List<Observer> getObservers() {

            if(mobservers == null) {
                mobservers = new List<Observer>();
            }

            return mobservers;

        }

        public void setObservers(List<Observer> observersList) {
            mobservers = observersList;
        }

        public void attach(Observer ob) {
            mobservers.Add(ob);
        }

        public void detach(Observer ob) {
            mobservers.Remove(ob);
        }

        public void notify() {
            foreach (Observer ob in mobservers) {
                ob.actualizar();
            }
        }

    } 

}