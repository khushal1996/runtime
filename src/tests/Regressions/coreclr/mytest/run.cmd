set COMPlus_TieredCompilation=0
set COMPlus_JitDumpTier0=1
set DOTNET_JitForceEvexEncoding=1
set DOTNET_JitStressEvexEncoding=1
set DOTNET_ENABLEINCOMPLETEISACLASS=1
set DOTNET_EnableAVX512F=1

set "COMPlus_JitDisasm=MakeSeparatorListVectorized"

C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Tests\Core_Root\corerun C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Regressions\coreclr\mytest\mytest\mytest.dll 5 7 > jit-diff.dasm
rem C:\Users\kmodi\Documents\Base_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Tests\Core_Root\corerun C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Regressions\coreclr\mytest\mytest\mytest.dll 5 7 > jit-base.dasm

set COMPlus_JitDisasm=""
set "COMPlus_JitDump=Main"

rem C:\Users\kmodi\Documents\Base_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Tests\Core_Root\corerun C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Regressions\coreclr\mytest\mytest\mytest.dll 5 7 > jit-base.txt
C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Tests\Core_Root\corerun C:\Users\kmodi\Documents\Git_repos\runtime\artifacts\tests\coreclr\windows.x64.Debug\Regressions\coreclr\mytest\mytest\mytest.dll 5 7 > jit-diff.txt