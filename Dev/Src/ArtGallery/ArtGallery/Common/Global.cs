﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ArtGallery.Common
{
    public static class Global
    {
        public static string ContactMailTo
        {
            get
            {
                return ConfigurationManager.AppSettings["contactMailTo"].ToString();
            }
        }
        public static string ProfilePics
        {
            get
            {
                return ConfigurationManager.AppSettings["ProfilePics"].ToString();
            }
        }

        public static string ArtImages
        {
            get
            {
                return ConfigurationManager.AppSettings["ArtImages"].ToString();
            }
        }

        public static string ExhibitionImages
        {
            get
            {
                return ConfigurationManager.AppSettings["ExhibitionImages"].ToString();
            }
        }

        public static string EventImages
        {
            get
            {
                return ConfigurationManager.AppSettings["EventImages"].ToString();
            }
        }

        public static string FeaturedPartnerImages
        {
            get
            {
                return ConfigurationManager.AppSettings["FeaturedPartnerImages"].ToString();
            }
        }

        public static string CategoryImages
        {
            get
            {
                return ConfigurationManager.AppSettings["CategoryImages"].ToString();
            }
        }

        public static int PaginationSize
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["PaginationSize"]);
            }
        }

        public static string EmailFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["emailFrom"];
            }
        }

        public static string EmailSentFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["emailSentFrom"];
            }
        }

        public static string EmailPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["emailPassword"];
            }
        }

        public static string EmailSmtpClient
        {
            get
            {
                return ConfigurationManager.AppSettings["emailSmtpClient"];
            }
        }

        public static int EmailPort
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["emailPort"]);
            }
        }

        public static string DefaultCoverPic
        {
            get
            {
                return "~/Images/Default Images/CoverPic.png";
            }
        }

        public static string DefaultProfilePic
        {
            get
            {
                return "~/Images/Default Images/ProfilePic.png";
            }
        }

        public static string MailSignature
        {
            get
            {
                var msg = "Get in touch via social media or email.<br/><br/>" +
                        "artbrowserapp @gmail.com<br/>" +
                        "@ArtBrowserApp<br/>" +
                        "<a href='www.facebook.com/ArtBrowserApp'>www.facebook.com/ArtBrowserApp</a>";

                return msg;
            }
        }
    }
}