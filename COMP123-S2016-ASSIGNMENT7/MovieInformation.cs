using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COMP123_S2016_ASSIGNMENT7
{
    class MovieInformation
    {
        private string _MovieTitle;
        private double _cost;
        private string _category;
   
        private Bitmap _picture;

        public MovieInformation(string title, double cost, string category)
        {
            this._MovieTitle = title;
            this._cost = cost;
            this._category = category;
            
             this._picture = new Bitmap("../../images/" + title + ".jpg");
           

        }

    }
}
