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
        private static Form2 _SliderPage1;
        private static Form3 _SliderPage2;
        private static EndPage _EndPage;

        private static int _testNo = 1;
        private static int currentTest = 1;



        public static Form1 StartPage
        {
            get
            {
                if (_StartPage == null)
                {
                    _StartPage = new Form1();
                }else if (currentTest != _testNo)
                {
                    _StartPage = new Form1();
                    _SliderPage1 = new Form2();
                    _SliderPage2 = new Form3();
                    currentTest = _testNo;
                }
                return _StartPage;
            }
        }

        public static Form2 SliderPage1
        {
            get
            {
                if (_SliderPage1 == null)
                {
                    _SliderPage1 = new Form2();
                }
                return _SliderPage1;
            }
        }

        public static Form3 SliderPage2
        {
            get
            {
                if (_SliderPage2 == null)
                {
                    _SliderPage2 = new Form3();
                }
                return _SliderPage2;
            }
        }

        public static EndPage LastPage
        {
            get
            {
                if (_EndPage == null)
                {
                    _EndPage = new EndPage();
                }
                return _EndPage;
            }
        }

        public static int TestNo
        {
            get { return _testNo; }
            set { _testNo = value; }
        }
    }
}
