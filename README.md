# UnityRipper
Latest build: [![Build status](https://ci.appveyor.com/api/projects/status/rds46l7fn62377p7?svg=true)](https://ci.appveyor.com/project/mafaca/unityripper/branch/master)

Unity Ripper is a tool for extracting assets from assets files (CAB-*, *.assets, *.sharedAssets, etc.) and assets bundles (*.unity3d, *.assetbundle, etc.) into native Unity format.

## Export features
* Prefabs (GameObjects with transform components)
* Meshes
* Materials
* Shaders
* Texture (containers and raw only)
* AnimationClips (legacy, generic)
* Avatars
* TextAssets
* Components:
  * MeshRenderer
  * SkinnedMeshRenderer
  * Animation
  * Animator

## Structure
Solution consist of two project:
* UnityRipperCore 

   Core library. It's designed as an single module without any third party dependencies.
* UnityRipper

   Test console application. You can use it as an example for your own project.
This is command line console application. Drag and drop any resource file(s) to it to retrive assets. It will automaticly try to find resource dependencies, create 'Ripped' directory and extract all supported asset files into created folder.
This is a sample application and it won't get improved in any way.

### Requirements:

If you want to build solution you need:

.NET Framework 4.6.1 compiler with C# 7 syntax support (Visual Studio 2017)

If you want to only run binaries of sample project you need to install:

[.NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49982)
