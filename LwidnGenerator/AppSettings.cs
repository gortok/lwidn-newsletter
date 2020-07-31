﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LwidnGenerator
{
  public static class AppSettings
  {
    public static string ContactEmail { get; set; } = ConfigurationManager.AppSettings["ContactEmail"];

    public static string Title { get; set; } = ConfigurationManager.AppSettings["SiteTitle"];
    
    public static string Description { get; set; } = ConfigurationManager.AppSettings["SiteDescription"];

    public static string BaseRef { get; set; } = ConfigurationManager.AppSettings["BaseRef"];

    public static string ServerUrl { get; set; } = ConfigurationManager.AppSettings["ServerUrl"];


    public static string GoogleAnalytics { get; set; } = ConfigurationManager.AppSettings["GoogleAnalytics"];

    public static string Lang { get; set; } = ConfigurationManager.AppSettings["Lang"];
  }
}
