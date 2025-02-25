﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagementSystem
{
    internal class ResourceManager
    {
        public List<Resource> Resources { get; private set; }

        public ResourceManager()
        {
            Resources = new List<Resource>();
        }

        public void AddResource(Resource resource)
        {
            if (Resources.Any(r => r.Name == resource.Name && r.Location == resource.Location))
            {
                throw new ArgumentException($"Zasób {resource.Name} w lokalizacji {resource.Location} już istnieje.");
            }

            Resources.Add(resource);
        }

        public void AllocateResource(string resourceName, string user)
        {
            var resource = Resources.FirstOrDefault(r => r.Name == resourceName);
            if (resource == null) throw new ArgumentException($"Zasób {resourceName} nie został znaleziony.");

            resource.Allocate(user);
        }

        public void ReleaseResource(string resourceName)
        {
            var resource = Resources.FirstOrDefault(r => r.Name == resourceName);
            if (resource == null) throw new ArgumentException($"Zasób {resourceName} nie został znaleziony.");

            resource.Release();
        }
    }
}
