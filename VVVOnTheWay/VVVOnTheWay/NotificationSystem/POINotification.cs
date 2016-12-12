﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace VVVOnTheWay.NotificationSystem
{
    /// <summary>
    /// A implementation of the INotification interface for specific use with the PointOfInterest class
    /// </summary>
    class PoiNotification : INotification
    {
        /// <summary>
        /// The following property's are in order (from top to botton):
        /// Title: the title of the notification
        /// Audiopath: A filepath leading to the location of the audio file to be used in this notification.
        /// Image: The image this notification should display.
        /// Description: A description to be used with this notification.
        /// </summary>
        public string Title { get; }
        public string AudioPath { get; }
        public BitmapImage Image { get; }
        public string Description { get; }

        public PoiNotification(string title, string audio, string imagePath, string description)
        {
            Title = title;
            AudioPath = audio;
            this.Image = new BitmapImage((new Uri(imagePath)));
            Description = description;
        }
    }
}
