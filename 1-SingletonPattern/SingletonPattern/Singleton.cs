using System;

namespace SingletonPattern
{

    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id;
        private static object _lockObject = new object();



        public Guid Id { get => _id; }//Sadece readonly olacak.

        public Singleton(Guid id)
        {
            _id = id;

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                //Burayı yapmamızın sebebi multithread uygulamalar için daha kullanıslı bir hale getirmiş olduk.
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton(Guid.NewGuid());  
                    }
                }
            }
            return _instance;
        }

        
    }
}
