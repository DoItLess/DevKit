using System;
using System.Collections.Generic;

namespace DoItLess.DotNet.DeviceId.Internal
{
    public class EncoderEqualityComparer : IEqualityComparer<IDeviceIdModule>
    {
        public bool Equals(IDeviceIdModule x, IDeviceIdModule y) => string.Equals(x?.Name, y?.Name, StringComparison.OrdinalIgnoreCase);

        public int GetHashCode(IDeviceIdModule obj) => obj.Name?.GetHashCode() ?? base.GetHashCode();
    }
}