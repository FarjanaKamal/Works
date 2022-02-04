using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1
{
    
    public partial class UserProfilePage : System.Web.UI.Page
    {
        public int Flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login Page.aspx");
        }

        protected void ChangePhotoBtn_Click(object sender, EventArgs e)
        {
            //Initialization of the variables
            var RandomSelection = new Random();
            int RecentPhotoIndex=0, NewSelectedIndex;

            //An array of different photos URL
            string[] gallary = {"https://i.pinimg.com/originals/a6/58/32/a65832155622ac173337874f02b218fb.png" , 
                "https://cdn2.iconfinder.com/data/icons/circle-avatars-1/128/050_girl_avatar_profile_woman_suit_student_officer-512.png",
                "https://cdn.pixabay.com/photo/2021/01/04/10/41/icon-5887126_1280.png",
                "https://www.maxpixel.net/static/photo/1x/Icon-Female-Avatar-Female-Icon-Red-Icon-Avatar-6007530.png",
                "https://cdn3.vectorstock.com/i/1000x1000/01/77/businesswoman-character-avatar-icon-vector-12800177.jpg"};
            
            //Selecting the recent photo index 
            for(int i=0; i < gallary.Length; i++)
            {
                if(gallary[i]== ProfilePhoto.ImageUrl)
                {
                    RecentPhotoIndex = i;
                    break;
                }
                    
            }

            //Generating a random index for the photo and excluding the recent photo index   
            do
            {
                NewSelectedIndex = RandomSelection.Next(0, gallary.Length-1);
            } while(RecentPhotoIndex== NewSelectedIndex);
            ProfilePhoto.ImageUrl = gallary[NewSelectedIndex];          
        }
    }
}