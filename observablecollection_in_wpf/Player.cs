using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observablecollection_in_wpf
{
    //  1 first we make this class public
    public class Player
    {
        #region
        /* the role of observable collection in wpf is for maintaining collecttion of objects in winforms ,web or console applications 
         if have to make a list of students you should make a list of students or genric list of student so this case does not work in 
         wpf because wpf 'UI constantly needs notifycation from code behind or from your code
         */
        #endregion
        // 2 lets add two properties
        public int Id { get; set; }
        public string Name { get; set; }
        // 3  lets go the code behind we are not making MVVM for this demo
    }
}
