﻿using Dopamine.Common.Services.Playback;
using Microsoft.Practices.ServiceLocation;

namespace Dopamine.Common.Presentation.ViewModels
{
    public class VerticalVolumeControlsViewModel : VolumeControlsViewModel
    {
        #region Construction
        // Workaround to have inheritance with dependency injection
        public VerticalVolumeControlsViewModel() : base(ServiceLocator.Current.GetInstance<IPlaybackService>())
        {
        }
        #endregion
    }
}