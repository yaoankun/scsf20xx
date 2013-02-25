'===============================================================================
' Microsoft patterns & practices
' CompositeUI Application Block
'===============================================================================
' Copyright � Microsoft Corporation.  All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
' FITNESS FOR A PARTICULAR PURPOSE.
'===============================================================================


Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
#If DEBUG Then
<Assembly: AssemblyConfiguration("Debug")> 
#Else
<assembly : AssemblyConfiguration ("Release")>
#End If

<Assembly: AssemblyTitle("EventBrokerQuickStart"), _
Assembly: AssemblyDescription("Microsoft Composite UI Event Broker QuickStart"), _
Assembly: AssemblyCulture(""), _
Assembly: CLSCompliant(True), _
Assembly: ComVisible(False), _
Assembly: ReflectionPermission(SecurityAction.RequestMinimum, Flags:=ReflectionPermissionFlag.MemberAccess)> 