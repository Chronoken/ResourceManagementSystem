using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagementSystem
{
    internal class Resource
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        public bool IsAllocated { get; private set; }
        public string AllocatedTo { get; private set; }

        public Resource(string name, string location)
        {
            Name = name;
            Location = location;
            IsAllocated = false;
        }

        public void Allocate(string user)
        {
            if (IsAllocated)
            {
                throw new InvalidOperationException($"Zasób {Name} jest już przydzielony użytkownikowi {AllocatedTo}.");
            }

            IsAllocated = true;
            AllocatedTo = user;
        }

        public void Release()
        {
            if (!IsAllocated)
            {
                throw new InvalidOperationException($"Zasób {Name} nie jest przydzielony.");
            }

            IsAllocated = false;
            AllocatedTo = null;
        }

        public override string ToString()
        {
            var status = IsAllocated ? $"Przydzielony użytkownikowi {AllocatedTo}" : "Dostępny";
            return $"{Name} ({Location}) - {status}";
        }
    }
}
