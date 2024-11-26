[![QuickFIX/N][1]](http://quickfixn.org)

![Build status](https://github.com/connamara/quickfixn/actions/workflows/dotnet.yml/badge.svg)
[![NuGet Version](https://img.shields.io/nuget/v/QuickFIXn.Core)](https://www.nuget.org/packages/QuickFIXn.Core/)

For tutorials on how to use QuickFIX/n, visit the [website](http://quickfixn.org/tutorial/creating-an-application.html).

This README is about setting up your system to do QuickFIX/n
development.

System Setup
------------

* This project uses .NET 6.

* All scripts are in Powershell, and should work on both Windows and Unix-based platforms.


Code Generation
---------------
DDTool is a C#-based tool for analyzing DataDictionary files and
regenerating the source for message and field classes.

Check out the DDTool directory to learn more, or you can just run this script:

```
pwsh scripts\Generate-Message-Sources.ps1
```


Build and Test
--------------
It is assumed that developers know how to use `dotnet` cli tools
or their IDE of choice.

The simplest spin-up instructions are:
* `dotnet build` - to build
* `dotnet test` - to run all unit and acceptance tests (which use NUnit)

To run *only* UTs or *only* ATs:
* `dotnet test UnitTests`
* `dotnet test AcceptanceTests`

To get more detail in the test ouput:
* `dotnet test -l "console;verbosity=detailed" AcceptanceTest`

To run a specific suite, use ``--filter``, e.g.
* `dotnet test --filter Fix44Test AcceptanceTest`
(`Fix44Test` is the `TestCaseSource` function in Fix44.cs)

AcceptanceTest logs are output to `bin/Debug/net6.0/log`.

CME Acceptance Tests
--------------
To run only the CME ATs:
* `dotnet test --filter CmeTest AcceptanceTest`

CME test scenario specs from [Belvedere Estimate](https://docs.google.com/document/d/1Z1RAcI8mKte8rwjsmdguLvdy2UL9rqxmbNTB2GOZCTg/edit?pli=1&tab=t.0):
* [2./12. Mid-Week Key Rotation](https://www.cmegroup.com/tools-information/webhelp/autocert-drop-copy4/Content/DCCGWKeyRot.html)
* [4. Beginning of Week Logon](https://www.cmegroup.com/tools-information/webhelp/autocert-drop-copy4/Content/LogonBeg.html)
* [8. Bi-Directional Resend Request](https://www.cmegroup.com/tools-information/webhelp/acp-dc-btec/Content/BiDirRes.html)
* [9. Process Real-Time Messages During Resend Response](https://www.cmegroup.com/tools-information/webhelp/acp-dc-btec/Content/RealTime.html)
* [11. Logon with Market Segment ID](https://www.cmegroup.com/tools-information/webhelp/autocert-drop-copy4/Content/LogonMarkSeg.html)


Credits
-------

![Connamara Systems](http://quickfixn.org/web/public/images/Connamara-Logo.png)

QuickFIXn is maintained and funded by [Connamara](http://connamara.com).

The names and logos for Connamara are trademarks of Connamara Systems, LLC.

Licensing
---------

This software is available under the QuickFIX Software License. Please see the [LICENSE](LICENSE) for the terms specified by the QuickFIX Software License.

[1]: http://quickfixn.org/web/public/images/qfn-logo/QuickFIX-n_logo-small.png
