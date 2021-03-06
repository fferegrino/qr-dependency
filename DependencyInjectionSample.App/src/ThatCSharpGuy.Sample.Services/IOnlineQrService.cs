﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThatCSharpGuy.Sample.Services
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public interface IOnlineQrService
    {
        string Name { get; }

        string GetUrl(string data, int size);
    }
}
