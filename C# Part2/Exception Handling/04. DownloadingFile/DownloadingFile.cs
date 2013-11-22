﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
    /// <summary>
    /// We are using the WebClient class and it's method DownloadFile.
    /// Exceptions thrown by this method are available in MSDN. 
    /// </summary>
    class DownloadingFile
    {
        static void Main()
        {
            // the using block has the responsibility to free the resources when operation is over
            //replaces the finally part
            using (WebClient downloader = new WebClient())
            {
                try
                {
                    string remoteURI = "http://devbg.org/img/";
                    string image = "Logo-BASD.jpg";
                    string webResource = remoteURI + image;
                    Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", image, webResource);
                    downloader.DownloadFile(webResource, image);
                    Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", image, webResource);
                    // The file is successfully downloaded in 04. DownloadingFile/bin/debug folder
                    Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + AppDomain.CurrentDomain.BaseDirectory);
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("Destination unreachable");
                }
                catch (ArgumentNullException)
                {
                    Console.Error.WriteLine("Adress parameter is null");
                }
                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("Multiple threads called that method");
                }
            }
        }
    }
