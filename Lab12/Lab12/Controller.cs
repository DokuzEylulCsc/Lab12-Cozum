using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class Controller : IController
    {
        private IModel model;
        private IView view;



        public void getRequestFromModel()
        {
            model.getRequest();
        }

        public void setView(IView v)
        {
            view = v;
        }

        public void setModel(IModel m)
        {
            model = m;
        }

        public void updateView(string input)
        {
            view.update(input);
        }
    }
}
