using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGatheringApp
{
    class FormProvider
    {
        private static Form1 _StartPage;
        private static Form2 _SliderPage;

        public static Form1 StartPage
        {
            get
            {
                if (_StartPage == null)
                {
                    _StartPage = new Form1();
                }
                return _StartPage;
            }
        }

        public static Form2 SliderPage
        {
            get
            {
                if (_SliderPage == null)
                {
                    _SliderPage = new Form2();
                }
                return _SliderPage;
            }
        }
    }
}
