namespace ProyectoDIAndres.Observer_Subject {

    abstract class Observer {

        private Subject mSubject;

        public Subject getSubject() {
            return mSubject;
        }

        public void setSubject(Subject subject) {
            mSubject = subject;
        }

        public abstract void actualizar();

    }

}