﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ATNET.Project
{
    public class DirectoryProjectItem:ProjectItem
    {
        public DirectoryProjectItem(IProject project)
            : base(project)
        {
 
        }

        public DirectoryProjectItem(IProject project, ItemType itemType)
            : base(project, itemType)
        { 

        }

        private IList<ProjectItem> items = new List<ProjectItem>();
        public IList<ProjectItem> Items
        {
            get { return items; }
        }

        public void AddProjectItem(ProjectItem item)
        {
            items.Add(item);
        }
    }
}