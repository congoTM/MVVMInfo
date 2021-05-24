using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication
{
    public class MyViewModel : BaseINPC
    {
        private ObservableCollection<MyModel> listModels;
        public ObservableCollection<MyModel> ListModels
        {
            get { return listModels; }
            set 
            { 
                listModels = value;
                RaisePropertyChanged("ListModels");
            }
        }



        private MyModel currentModel;
        public MyModel CurrentModel
        {
            get { return currentModel; }
            set 
            {
                currentModel = value;
                RaisePropertyChanged("CurrentModel");

            }
        }

        //Construtor
        public MyViewModel()
        {

            ListModels = new ObservableCollection<MyModel>()
            {
                new MyModel()
                {
                    NumberId=1,
                    Title ="Title1"
                },
                new MyModel()
                {
                    NumberId=2,
                    Title ="Title2"
                } 
            };

            CurrentModel = ListModels.First();


        }

        public void Message()
        {
            MessageBox.Show(CurrentModel.NumberId.ToString());
        }
    }
}
