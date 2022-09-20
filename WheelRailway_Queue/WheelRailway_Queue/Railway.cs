using System;
using System.Collections.Generic;

namespace WheelRailway_Q
{
    class Railway<T>
    {
        private T[] bufor;
        private int buforstart;
        private int buforend;

        public Railway() : this(volume: 5)
        {

        }

        public Railway(int volume)
        {
            bufor = new T[volume + 1];
            buforstart = 0;
            buforend = 0;
        }

        public void Save(T value)
        {
            bufor[buforend] = value;
            buforend = (buforend + 1) % bufor.Length;
        }

        public T Read()
        {
            var result = bufor[buforstart];
            buforstart = (buforstart + 1) % bufor.Length;
            return result;
        }

        public int Volume
        {
            get
            {
                return bufor.Length;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return buforstart == buforend;
            }
        }

        public bool IsFull
        {
            get
            {
                return (buforend + 1) % bufor.Length == buforstart;
            }
        }
    }
}
