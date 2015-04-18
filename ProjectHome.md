# **Wii Disc Image Backup Manager** #


---


## So... WHAT does it do?!? ##

This program is an attempt to take off from where Wii Backup Manager left off and keeps leaving off, don't get me wrong that program is great and until this is finished i will keep using it as it is the best currently available WBFS manager...

But it suffers from some issues such as
slow transfers sometimes taking crazy amounts of time to convert, copy and move..
chaotic behavior where it seemingly randomly decides to do or not do what you ask of it..
bugs where it looses data such as the MD5 hashes you waited 24 hours to calculate

and other frustrating issues such as

not automatically loading the folders you ask it to on start up until you click Add Folder once for every folder you have in the list.


---


## So... THERE is a plan right?!? ##

  * Provide an open source alternative to Wii Backup Manager
  * Have every feature that Wii Backup Manager has
  * Complete every task faster and more efficiently than Wii Backup Manager
  * Provide a plugin architecture exposing modular replacements and additions
  * Provide default plugins for several CD/DVD backup file formats
  * Provide default plugins for several file systems
  * Provide default plugins for several transfer methods and file operations
  * Provide default plugins for several data hash creation algorithms


---


## So... WHAT are the main features?!? ##

  * Read _FAT32, EXT2, NTFS_ & _WBFS_ filesystems
  * Plugin architecture allowing support for new filesystems added via plugin DLL files
  * Devices supported include hard drives, flash drives, CD drives, DVD drives, BLURAY drives
  * Plugin architecture allowing support for new devices added via plugin DLL files
  * Supports conversion of WBFS, cISO, ISO, WDF, CUE+BIN & NRG disc image file formats
  * Plugin architecture allowing support for new disc image file formats added via plugin DLL files
  * Verify disc image integrity with MD5 & SHA1 hashing
  * Plugin architecture allowing support for hashing methods added via plugin DLL files
  * Buffered & cached high speed Copying, Moving & Deleting of disc images
  * Plugin architecture allowing new transfer methods added via plugin DLL files
  * Disc image splitting system that breaks disc images into multiple parts based on the destination filesystem during moves and copies
<br>
And much much more....</li></ul>

<hr />

<h2>So... WHERE is this thing?!? ##

We are working on having the first source code folder layout and basic structure of the application along with the initial GUI and configuration systems in place.

This is almost done and i would imagine within a week we will have the first build available.

Do not expect hundreds of source commits and releases every day, there won't be.

We will strive to at least every 3 days commit the current code base.
We will attempt to meet release candidate milestones at least once a month.


---


## So... YOU want to contribute?!? ##

There are several ways you can help this project

  1. Donate to help the families of project developers let them work more on the code and less on the chores and dealing with kids
  1. Submit patches against the source code fixing bugs or adding features, all patches are reviewed and you will be notified if your patch was approved and if we will be using all or some of the patches content, if your patch fails to meet the criteria required you will be notified and given advice on how to update your patch and bring it up to code
  1. Join the project and directly work with the project owner to work through the feature creep, core code and bug fix lists


---


## So... YOU are submitting a patch?!? ##

it is super simple but there are some rules for writing code and creating patches you must follow in order to have your patch approved

  * Patches must be compiled and tested against the latest SVN
  * Each individual patch file must be for an individual bug fix, feature, enhancement or optimization, do not bundle several things into one patch file
  * Try and follow the coding style seen in the rest of the project, i know you want to rewrite it all in your style but you can't
  * Patches must supply either block comments or block XML comments for Methods, Fields, Classes, Structs, Delegates, Imports, Interfaces, Enumerations, Arrays, Collections, Defines & Constants
  * Avoid using defines and labels unless it will make code substantially smaller or faster to define out a block rather than have an if or switch instead
  * Don't reinvent the wheel, if there is a method, class or extension method somewhere in the project that does what you want, use it
  * We like extension methods if you want to expand, enhance or improve sealed, internal and inaccessible code awesome go for it
  * Eventually a complete coding style guide and naming convention will be placed on the wiki to help people not make mistakes that lead to patches being denied


---


## So.. WHAT are the latest important changes ##

### Version 0.1.0033 ###

  * Core Plugin Layout & Structure Completed
  * Initial Layout & Structure For Each Default Plugin Completed

### Version 0.1.0022 ###

  * Initial Code Layout & Structure Completed
  * Initial Native Method Wrappers Completed

### Version 0.1.0011 ###

  * Initial Main Window GUI Completed
  * Initial Settings & Configurations Completed


---


## So... A disclaimer?!? ##

Although we work ridiculously hard to make everything we code bug free and code tons of error checking, result monitoring and data verification as to prevent data loss or damage.

Sometimes unavoidable loss or damage does occur, due to unforeseen circumstances, bugs that are insanely sporadic in nature or bugs that only appear under very very specific conditions or environments.

The team and or individuals who created this waive responsibility should any of your data be lost and/or stolen and/or damaged by using this software either as it is intended to be used or otherwise.

We take no responsibility and provide no guarantee or warranty you use this software and any information provided by the software and this site at your own risk.

We maintain no liability and waive all responsibility for any reason you are inconvenience or in any way displeased by the inability to use this software or damage to your computer caused directly or indirectly by installing and/or running this software.

Basically if something you have gets lost, stolen, broken or in any way changes state due to installing, running, knowing about or just reading about this software or by following any instructions found in the software or this site it is not our fault you have been warned.


---


## So... ARE there any other plans?!? ##

  1. Finish and add more wiki pages
  1. Fully Document all code to an anal almost infuriating degree
  1. Optimize everything an order of magnitude higher than most WBFS managers even if it means writing assembler methods or batching and in-lining operations, using SSE and similar instruction sets for all math and calculation
  1. Make sure everything is thread sage and re-entrant then make sure at no time does the program freeze, if the GUI freezes we will move that operation out into a thread or throw it on the operation queue thread