﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urgent_Manager.Model;

namespace Urgent_Manager.Controller
{
    public class WPCSController
    {
        private string path = "";
        UrgentController urgentController = new UrgentController();
        public WPCSController(string path)
        {
            this.path = path;
        }

        public bool DeleteUrgent(string leadCode,string unico)
        {

            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader stream = new StreamReader(file);
            int isUpdated = 0;
            try
            {
                string line = stream.ReadToEnd();
                string item = line.Substring(line.LastIndexOf("[JobTerminated]"));
                string[] lines = item.Split('\n');
                bool isFirstLineNull = true;
                foreach (string l in lines)
                {
                    if (l.Contains("="))
                    {
                        string[] items = new string[2];
                        items = l.Split('=');
                        if (items[0].Trim() == "ArticleKey")
                        {
                            if (leadCode == items[1].Trim())
                            {
                                urgentController.UpdateUrgent(UrgentModel.Status.Finished.ToString(), DateTime.Now.ToShortDateString(), unico);
                                isUpdated = 1;
                                break;
                            }
                        }
                        isFirstLineNull = false;
                    }
                    else
                    {
                        if (!isFirstLineNull)
                            break;
                    }
                }
                return isUpdated == 1 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
