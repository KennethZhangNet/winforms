// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.MSInternal", "CA905:SystemAndMicrosoftNamespacesRequireApproval", Scope = "namespace", Target = "System.Windows.Forms.VisualStyles")]

namespace System.Windows.Forms.VisualStyles
{
    [SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    public enum ScrollBarArrowButtonState
    {
        UpNormal = 1,
        UpHot = 2,
        UpPressed = 3,
        UpDisabled = 4,
        DownNormal = 5,
        DownHot = 6,
        DownPressed = 7,
        DownDisabled = 8,
        LeftNormal = 9,
        LeftHot = 10,
        LeftPressed = 11,
        LeftDisabled = 12,
        RightNormal = 13,
        RightHot = 14,
        RightPressed = 15,
        RightDisabled = 16
    }
}