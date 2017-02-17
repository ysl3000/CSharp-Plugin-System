﻿using PluginLoadingTest.pluginloading;

namespace PluginLoadingTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var pluginLoader = new PluginLoader<Plugin>("./plugins/");

            pluginLoader.Enable();

            pluginLoader.Disable();
        }
    }
}
