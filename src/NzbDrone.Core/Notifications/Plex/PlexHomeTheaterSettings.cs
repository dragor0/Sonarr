﻿using System;
using NzbDrone.Core.Annotations;
using NzbDrone.Core.Notifications.Xbmc;

namespace NzbDrone.Core.Notifications.Plex
{
    public class PlexHomeTheaterSettings : XbmcSettings
    {
        public PlexHomeTheaterSettings()
        {
            Port = 3005;
            Notify = true;
        }

        //These need to be kept in the same order as XBMC Settings, but we don't want them displayed

        [FieldDefinition(2, Label = "Username", Type = FieldType.Hidden)]
        public String Username { get; set; }

        [FieldDefinition(3, Label = "Password", Type = FieldType.Hidden)]
        public String Password { get; set; }

        [FieldDefinition(5, Label = "GUI Notification", Type = FieldType.Hidden)]
        public Boolean Notify { get; set; }

        [FieldDefinition(6, Label = "Update Library", HelpText = "Update Library on Download & Rename?", Type = FieldType.Hidden)]
        public Boolean UpdateLibrary { get; set; }

        [FieldDefinition(7, Label = "Clean Library", HelpText = "Clean Library after update?", Type = FieldType.Hidden)]
        public Boolean CleanLibrary { get; set; }

        [FieldDefinition(8, Label = "Always Update", HelpText = "Update Library even when a video is playing?", Type = FieldType.Hidden)]
        public Boolean AlwaysUpdate { get; set; }
    }
}
