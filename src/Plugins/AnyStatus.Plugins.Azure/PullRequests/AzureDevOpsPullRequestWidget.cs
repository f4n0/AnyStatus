﻿using AnyStatus.API.Widgets;
using System.ComponentModel;

namespace AnyStatus.Plugins.Azure.DevOps.PullRequests
{
    [Browsable(false)]
    public class AzureDevOpsPullRequestWidget : StatusWidget, IOpenInApp
    {
        public object PullRequestId { get; internal set; }
        public string URL { get; set; }
  }
}
