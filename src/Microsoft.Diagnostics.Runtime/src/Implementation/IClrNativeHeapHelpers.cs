﻿using System.Collections.Generic;

namespace Microsoft.Diagnostics.Runtime.Implementation
{
    internal interface IClrNativeHeapHelpers
    {
        IEnumerable<ClrNativeHeapInfo> EnumerateNativeHeaps(ClrAppDomain domain);
        IEnumerable<ClrNativeHeapInfo> EnumerateLoaderAllocatorNativeHeaps(ulong loaderAllocator);
        IEnumerable<ClrNativeHeapInfo> EnumerateThunkHeaps(ulong thunkHeapAddress);
    }
}
