// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public interface ITestStoreFactory<out TTestStore>
        where TTestStore : TestStore
    {
        TTestStore CreateShared(string storeName);
    }
}
